using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRG271
{
    public class Animal
    {
        public Animal(string id, string name, string species, int age, int score)
        {
            Id = id;
            Name = name;
            Species = species;
            Age = age;
            Score = score;
            SetStatus();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public int Score { get; set; }
        public string Status { get; set; }
        public string HousingUnit { get; set; }


        //SetStatus is gonna set the status and housing from the unit score (and both Add and Update use this so that we only write the rules once)
        public void SetStatus()
        {
            if (Score < 20)
            {
                Status = "Critical";
                HousingUnit = "Intensive Care Unit";
            }
            else if (Score < 40)
            {
                Status = "Serious";
                HousingUnit = "High-Dependency Ward";
            }
            else if (Score < 60)
            {
                Status = "Stable";
                HousingUnit = "Recovery Ward";
            }
            else if (Score < 80)
            {
                Status = "Recovering";
                HousingUnit = "Outdoor Enclosure";
            }
            else // 80 and above
            {
                Status = "Release-Ready";
                HousingUnit = "Pre-Release Camp";
            }
        }

        //when written to file its displayed as such like they asked us in the proj doc
        public string ToLine()
        {
            return Id + "|" + Name + "|" + Species + "|" + Age + "|" + Score + "|" + Status + "|" + HousingUnit;
        }


    }



}
