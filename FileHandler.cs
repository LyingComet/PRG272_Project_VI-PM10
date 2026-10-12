using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace Project_PRG271
{
    //Data access class: everything that reads or writes animals.txt lives here
    public static class FileHandler
    {
        //file to be saved in same folder as exe
        public static string FilePath = Path.Combine(AppContext.BaseDirectory, "animals.txt");

        //bad lines skipped last time we loaded
        public static int LinesSkipped = 0;

        //UTF-8 without a BOM so the file matches the format the assessors use
        private static readonly Encoding FileEncoding = new UTF8Encoding(false);

        //reads animals.txt and returns the list of animals
        public static List<Animal> Load()
        {
            List<Animal> animals = new List<Animal>();
            LinesSkipped = 0;

            try
            {
                if (!File.Exists(FilePath))
                {
                    File.WriteAllText(FilePath, "");
                    return animals;
                }

                string[] lines = File.ReadAllLines(FilePath, FileEncoding);

                foreach (string line in lines)
                {
                    Animal animal;
                    if (!TryParseLine(line, out animal))
                    {
                        LinesSkipped++;
                        continue;
                    }

                    //skip if we already got an animal using this ID
                    bool alreadyThere = false;
                    foreach (Animal a in animals)
                    {
                        if (a.Id == animal.Id)
                        {
                            alreadyThere = true;
                        }
                    }

                    if (alreadyThere)
                    {
                        LinesSkipped++;
                        continue;
                    }

                    animals.Add(animal);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("animals.txt is being used by another program");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No permission to read animals.txt");
            }

            return animals;
        }

        //turns one line of the file into an Animal; returns false if the line is malformed
        //(used by Load and RewriteAnimal so both follow exactly the same rules)
        public static bool TryParseLine(string line, out Animal animal)
        {
            animal = null;

            string[] parts = line.Split('|');
            if (parts.Length != 7)
            {
                return false;
            }

            //makes ID prefixes capitals
            string id = parts[0].Trim().ToUpper();
            if (!IsValidId(id))
            {
                return false;
            }

            //age/score must be whole nums
            int age;
            int score;
            bool ageIsNumber = int.TryParse(parts[3].Trim(), out age);
            bool scoreIsNumber = int.TryParse(parts[4].Trim(), out score);
            if (!ageIsNumber || !scoreIsNumber)
            {
                return false;
            }

            //must be inbetween 0 and 100
            if (age < 0 || age > 100 || score < 0 || score > 100)
            {
                return false;
            }

            //status and housing unit worked out from score
            animal = new Animal(id, parts[1].Trim(), parts[2].Trim(), age, score);
            return true;
        }

        //checks if id looks the way it should eg) WR-0001
        public static bool IsValidId(string id)
        {
            if (id.Length != 7)
            {
                return false;
            }

            if (!id.StartsWith("WR-"))
            {
                return false;
            }

            //last 4 chars must be digit
            for (int i = 3; i < 7; i++)
            {
                if (id[i] < '0' || id[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }

        //adds ONE new line to the end of animals.txt without touching the existing lines
        //returns true if it worked; otherwise errorMessage explains what went wrong
        public static bool AppendAnimal(Animal animal, out string errorMessage)
        {
            errorMessage = "";

            try
            {
                string newLine = animal.ToLine() + Environment.NewLine;

                //if the last line has no line break (eg. a file typed by hand), add one first
                //otherwise the new record would be glued onto the end of the last record
                if (File.Exists(FilePath) && !EndsWithLineBreak())
                {
                    newLine = Environment.NewLine + newLine;
                }

                //AppendAllText creates the file if it is missing
                File.AppendAllText(FilePath, newLine, FileEncoding);
                return true;
            }
            //specific exceptions first: FileNotFound/DirectoryNotFound inherit from IOException
            catch (DirectoryNotFoundException)
            {
                errorMessage = "The animal was NOT saved. The folder for animals.txt could not be found.";
            }
            catch (UnauthorizedAccessException)
            {
                errorMessage = "The animal was NOT saved. animals.txt is read-only or you do not have permission to change it.";
            }
            catch (IOException)
            {
                errorMessage = "The animal was NOT saved. animals.txt is being used by another program. Close it and try again.";
            }
            return false;
        }

        //rewrites animals.txt with ONE record changed (Update) or removed (Delete)
        //pass the new version of the animal to update it, or null to delete it
        //every other line (including skipped/malformed ones) is written back exactly as it was
        public static bool RewriteAnimal(string id, Animal updatedAnimal, out string errorMessage)
        {
            errorMessage = "";

            try
            {
                string[] lines = File.ReadAllLines(FilePath, FileEncoding);
                List<string> newLines = new List<string>();
                bool found = false;

                foreach (string line in lines)
                {
                    //only the FIRST valid line with this ID is the record shown in the grid
                    Animal current;
                    if (!found && TryParseLine(line, out current) && current.Id == id.ToUpper())
                    {
                        found = true;

                        if (updatedAnimal != null)
                        {
                            newLines.Add(updatedAnimal.ToLine());
                        }
                        //when updatedAnimal is null we leave the line out, which deletes it
                        continue;
                    }

                    newLines.Add(line);
                }

                if (!found)
                {
                    errorMessage = "Animal " + id + " was not found in animals.txt. Nothing was changed.";
                    return false;
                }

                File.WriteAllLines(FilePath, newLines, FileEncoding);
                return true;
            }
            //specific exceptions first: FileNotFound/DirectoryNotFound inherit from IOException
            catch (FileNotFoundException)
            {
                errorMessage = "No changes were saved. animals.txt could not be found.";
            }
            catch (DirectoryNotFoundException)
            {
                errorMessage = "No changes were saved. The folder for animals.txt could not be found.";
            }
            catch (UnauthorizedAccessException)
            {
                errorMessage = "No changes were saved. animals.txt is read-only or you do not have permission to change it.";
            }
            catch (IOException)
            {
                errorMessage = "No changes were saved. animals.txt is being used by another program. Close it and try again.";
            }
            return false;
        }

        //checks whether animals.txt ends with a line break (an empty file counts as yes)
        private static bool EndsWithLineBreak()
        {
            using (FileStream stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                if (stream.Length == 0)
                {
                    return true;
                }

                //jump to the last byte and read it
                stream.Seek(-1, SeekOrigin.End);
                return stream.ReadByte() == '\n';
            }
        }
    }
}
