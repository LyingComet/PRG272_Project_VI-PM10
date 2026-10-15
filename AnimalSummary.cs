using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Project_PRG271
{
    // Calculates results independently of the form and file system.
    public class AnimalSummary
    {
        public int Total { get; private set; }
        public string AverageAge { get; private set; }
        public string AverageScore { get; private set; }
        public int Critical { get; private set; }
        public int Serious { get; private set; }
        public int Stable { get; private set; }
        public int Recovering { get; private set; }
        public int ReleaseReady { get; private set; }

        public static AnimalSummary Calculate(List<Animal> animals)
        {
            if (animals == null) throw new ArgumentNullException(nameof(animals));
            return new AnimalSummary
            {
                Total = animals.Count,
                AverageAge = animals.Count == 0 ? "N/A" :
                    animals.Average(a => a.Age).ToString("F2", CultureInfo.InvariantCulture),
                AverageScore = animals.Count == 0 ? "N/A" :
                    animals.Average(a => a.Score).ToString("F2", CultureInfo.InvariantCulture),
                Critical = animals.Count(a => a.Status == "Critical"),
                Serious = animals.Count(a => a.Status == "Serious"),
                Stable = animals.Count(a => a.Status == "Stable"),
                Recovering = animals.Count(a => a.Status == "Recovering"),
                ReleaseReady = animals.Count(a => a.Status == "Release-Ready")
            };
        }
    }
}
