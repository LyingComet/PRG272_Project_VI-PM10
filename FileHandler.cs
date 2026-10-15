using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Project_PRG271
{
    public class FileHandler
    {
        private string path = Path.Combine(AppContext.BaseDirectory, "animals.txt");
        private int linesSkipped;

        // starts with no skipped lines
        public FileHandler()
        {
            this.linesSkipped = 0;
        }

        public int LinesSkipped { get => linesSkipped; set => linesSkipped = value; }

        // reads every animal from the file into a list and counts the bad lines
        public List<Animal> Load()
        {
            List<Animal> animals = new List<Animal>();
            linesSkipped = 0;

            try
            {
                if (!File.Exists(path))
                {
                    File.Create(path).Close();
                    return animals;
                }

                using (StreamReader reader = new StreamReader(path))
                {
                    string text;
                    while ((text = reader.ReadLine()) != null)
                    {
                        Animal animal = LineToAnimal(text);

                        if (animal == null)
                        {
                            linesSkipped++;
                            continue;
                        }

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
                            linesSkipped++;
                            continue;
                        }

                        animals.Add(animal);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("The animals could not be loaded because you do not have permission to open animals.txt.");
            }
            catch (IOException)
            {
                MessageBox.Show("The animals could not be loaded because animals.txt is open in another program. Close it and try again.");
            }

            return animals;
        }

        // adds one animal to the end of the file
        public bool AddAnimal(Animal animal)
        {
            try
            {
                string line = animal.ToLine();

                if (File.Exists(path))
                {
                    string allText;
                    using (StreamReader reader = new StreamReader(path))
                    {
                        allText = reader.ReadToEnd();
                    }

                    if (allText != "" && !allText.EndsWith("\n"))
                    {
                        line = Environment.NewLine + line;
                    }
                }

                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(line);
                }

                return true;
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(animal.Name + " was not saved because the folder for animals.txt could not be found.");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(animal.Name + " was not saved because animals.txt is read-only. Untick read-only on the file and try again.");
            }
            catch (IOException)
            {
                MessageBox.Show(animal.Name + " was not saved because animals.txt is open in another program. Close it and try again.");
            }

            return false;
        }

        // replaces one animal in the file with its new details
        public bool UpdateAnimal(Animal animal)
        {
            return RewriteFile(animal.Id, animal);
        }

        // removes one animal from the file
        public bool DeleteAnimal(string id)
        {
            return RewriteFile(id, null);
        }

        // writes the file again with only one animal changed or removed
        private bool RewriteFile(string id, Animal newAnimal)
        {
            List<string> lines = new List<string>();
            bool found = false;

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string text;
                    while ((text = reader.ReadLine()) != null)
                    {
                        Animal animal = LineToAnimal(text);

                        if (!found && animal != null && animal.Id == id)
                        {
                            found = true;

                            if (newAnimal != null)
                            {
                                lines.Add(newAnimal.ToLine());
                            }

                            continue;
                        }

                        lines.Add(text);
                    }
                }

                if (!found)
                {
                    MessageBox.Show(id + " could not be found in animals.txt, so nothing was changed.");
                    return false;
                }

                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    foreach (string line in lines)
                    {
                        writer.WriteLine(line);
                    }
                }

                return true;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Nothing was changed because animals.txt could not be found.");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Nothing was changed because the folder for animals.txt could not be found.");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Nothing was changed because animals.txt is read-only. Untick read-only on the file and try again.");
            }
            catch (IOException)
            {
                MessageBox.Show("Nothing was changed because animals.txt is open in another program. Close it and try again.");
            }

            return false;
        }

        // turns one line from the file into an animal, or null if the line is wrong
        private Animal LineToAnimal(string text)
        {
            string[] strings = text.Split('|');

            if (strings.Length != 7)
            {
                return null;
            }

            string id = strings[0].Trim().ToUpper();
            AnimalValidator validator = new AnimalValidator();

            if (!validator.IsValidId(id))
            {
                return null;
            }

            int age, score;

            try
            {
                age = int.Parse(strings[3].Trim());
                score = int.Parse(strings[4].Trim());
            }
            catch (Exception)
            {
                return null;
            }

            if (age < 0 || age > 100 || score < 0 || score > 100)
            {
                return null;
            }

            string name = strings[1].Trim();
            string species = strings[2].Trim();

            return new Animal(id, name, species, age, score);
        }



        public bool UpdatetAnimal( Animal updatedAnimal)
        {
            List<Animal> animals = Load();
            List<string> lines = new List<string>();

            for (int i = 0; i < animals.Count; i++)
            { 
                if(animals[i].Id == updatedAnimal.Id)
                {
                    animals[i] = updatedAnimal;
                    break;
                }

            }

            foreach (Animal animal in animals)
            { 
                lines.Add(animal.Id + "|" + animal.Name + "|" + animal.Species + "|" + animal.Age + "|" + animal.Score + "|" + animal.Status + "|" + animal.HousingUnit);

            }

            File.WriteAllLines(path, lines);

            return true;
        }
    }
}
