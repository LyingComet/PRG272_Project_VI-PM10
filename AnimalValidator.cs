using System.Collections.Generic;
using System.Globalization;

namespace Project_PRG271
{
    //the input boxes a validation error can point to (None = no error)
    public enum AnimalField
    {
        None,
        Id,
        Name,
        Species,
        Age,
        Score
    }

    //result of checking the form: either a valid Animal, or the field that is wrong + why
    public class ValidationResult
    {
        public AnimalField Field { get; set; } = AnimalField.None;
        public string Message { get; set; } = "";
        public Animal Animal { get; set; }

        //valid when no field was flagged
        public bool IsValid
        {
            get { return Field == AnimalField.None; }
        }
    }

    //business rules for animal input; Add AND Update both call Validate so the rules exist only once
    public static class AnimalValidator
    {
        private const int MaxTextLength = 30;
        private const int MinNumber = 0;
        private const int MaxNumber = 100;

        //checks every input (trimmed) in form order and stops at the first problem
        //checkUnique = true for Add (ID must be new), false for Update (the ID is the animal being edited)
        public static ValidationResult Validate(string idText, string nameText, string speciesText,
            string ageText, string scoreText, List<Animal> existingAnimals, bool checkUnique)
        {
            //trim everything first, and make the ID upper case (wr-0007 -> WR-0007)
            string id = (idText ?? "").Trim().ToUpper();
            string name = (nameText ?? "").Trim();
            string species = (speciesText ?? "").Trim();
            string age = (ageText ?? "").Trim();
            string score = (scoreText ?? "").Trim();

            //--- Animal ID ---
            if (id == "")
            {
                return Fail(AnimalField.Id, "Animal ID is required.");
            }
            if (!FileHandler.IsValidId(id))
            {
                return Fail(AnimalField.Id, "Animal ID must be WR- followed by exactly 4 digits, e.g. WR-0007.");
            }
            if (checkUnique && IdExists(id, existingAnimals))
            {
                return Fail(AnimalField.Id, "Animal ID " + id + " already exists. Each animal needs a unique ID.");
            }

            //--- Name and Species ---
            string textError = CheckText("Name", name);
            if (textError != "")
            {
                return Fail(AnimalField.Name, textError);
            }

            textError = CheckText("Species", species);
            if (textError != "")
            {
                return Fail(AnimalField.Species, textError);
            }

            //--- Age and Recovery Score ---
            int ageValue;
            string numberError = CheckWholeNumber("Age", age, out ageValue);
            if (numberError != "")
            {
                return Fail(AnimalField.Age, numberError);
            }

            int scoreValue;
            numberError = CheckWholeNumber("Recovery Score", score, out scoreValue);
            if (numberError != "")
            {
                return Fail(AnimalField.Score, numberError);
            }

            //all good: the Animal constructor calls SetStatus, so status + housing are calculated here
            ValidationResult result = new ValidationResult();
            result.Animal = new Animal(id, name, species, ageValue, scoreValue);
            return result;
        }

        //builds a failed result that names the bad field
        private static ValidationResult Fail(AnimalField field, string message)
        {
            ValidationResult result = new ValidationResult();
            result.Field = field;
            result.Message = message;
            return result;
        }

        //true if another animal already uses this ID
        private static bool IdExists(string id, List<Animal> existingAnimals)
        {
            if (existingAnimals == null)
            {
                return false;
            }

            foreach (Animal a in existingAnimals)
            {
                if (a.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        //Name/Species rule: required, 1-30 characters, no | (the | separates fields in animals.txt)
        //returns "" when the text is fine, otherwise the error message
        private static string CheckText(string fieldName, string value)
        {
            if (value == "")
            {
                return fieldName + " is required.";
            }
            if (value.Length > MaxTextLength)
            {
                return fieldName + " must be 30 characters or fewer (you typed " + value.Length + ").";
            }
            if (value.Contains("|"))
            {
                return fieldName + " cannot contain the | character.";
            }
            return "";
        }

        //Age/Score rule: required whole number from 0 to 100 (no decimals, letters, + or - signs)
        //returns "" when the text is fine, otherwise the error message
        private static string CheckWholeNumber(string fieldName, string value, out int number)
        {
            number = 0;

            if (value == "")
            {
                return fieldName + " is required.";
            }

            //NumberStyles.None only allows the digits 0-9, so "4.5", "abc" and "-3" are all rejected
            if (!int.TryParse(value, NumberStyles.None, CultureInfo.InvariantCulture, out number))
            {
                return fieldName + " must be a whole number (no decimals or letters).";
            }
            if (number < MinNumber || number > MaxNumber)
            {
                return fieldName + " must be between 0 and 100.";
            }
            return "";
        }
    }
}
