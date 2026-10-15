using System;
using System.Collections.Generic;
using System.Text;

namespace Project_PRG271
{
    public class AnimalValidator
    {
        private string errorField;

        // starts with no field marked as wrong
        public AnimalValidator()
        {
            this.errorField = "";
        }

        public string ErrorField { get => errorField; set => errorField = value; }

        // checks all the inputs and returns an error message, or "" if everything is correct
        public string Validate(string id, string name, string species, string age, string score, List<Animal> animals, bool checkUnique)
        {
            errorField = "";

            if (id == "")
            {
                errorField = "ID";
                return "Please enter an Animal ID, for example WR-0007.";
            }

            if (!IsValidId(id))
            {
                errorField = "ID";
                return "Animal ID is incorrect, it should be WR- followed by 4 numbers.";
            }

            if (checkUnique)
            {
                foreach (Animal animal in animals)
                {
                    if (animal.Id == id)
                    {
                        errorField = "ID";
                        return id + " is already being used by " + animal.Name + ". Please choose a different ID.";
                    }
                }
            }

            string message = CheckText("name", name);
            if (message != "")
            {
                errorField = "Name";
                return message;
            }

            message = CheckText("species", species);
            if (message != "")
            {
                errorField = "Species";
                return message;
            }

            message = CheckNumber("age", age);
            if (message != "")
            {
                errorField = "Age";
                return message;
            }

            message = CheckNumber("recovery score", score);
            if (message != "")
            {
                errorField = "Score";
                return message;
            }

            return "";
        }

        // checks that the ID is WR- followed by 4 numbers
        public bool IsValidId(string id)
        {
            if (id.Length != 7)
            {
                return false;
            }

            if (!id.StartsWith("WR-"))
            {
                return false;
            }

            for (int i = 3; i < 7; i++)
            {
                if (id[i] < '0' || id[i] > '9')
                {
                    return false;
                }
            }

            return true;
        }

        // checks the name or species is filled in, not too long and has no |
        private string CheckText(string fieldName, string text)
        {
            if (text == "")
            {
                return "Please enter the animal's " + fieldName + ".";
            }

            if (text.Length > 30)
            {
                return "The " + fieldName + " is too long. Please keep it to 30 characters or less.";
            }

            if (text.Contains("|"))
            {
                return "The " + fieldName + " cannot contain the | character. Please remove it.";
            }

            return "";
        }

        // checks the age or score is a whole number from 0 to 100
        private string CheckNumber(string fieldName, string text)
        {
            if (text == "")
            {
                return "Please enter the animal's " + fieldName + ".";
            }

            int number;

            try
            {
                number = int.Parse(text);
            }
            catch (Exception)
            {
                return "The " + fieldName + " must be a whole number, like 5. Decimals and letters are not allowed.";
            }

            if (number < 0 || number > 100)
            {
                return "The " + fieldName + " must be a number between 0 and 100.";
            }

            return "";
        }
    }
}
