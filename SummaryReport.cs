using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace Project_PRG271
{
    public static class SummaryReport
    {
        public static string ReportPath
        {
            get { return Path.Combine(AppContext.BaseDirectory, "summary.txt"); }
        }

        public static string Format(AnimalSummary summary, DateTime generated)
        {
            StringBuilder report = new StringBuilder();
            report.AppendLine("BAOBAB RIDGE WILDLIFE REHABILITATION CENTRE");
            report.AppendLine("ANIMAL SUMMARY REPORT");
            report.AppendLine("Generated: " + generated.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture));
            report.AppendLine(new string('-', 39));
            AddRow(report, "Total animals:", summary.Total.ToString(CultureInfo.InvariantCulture));
            AddRow(report, "Average age (years):", summary.AverageAge);
            AddRow(report, "Average recovery score:", summary.AverageScore);
            report.AppendLine(new string('-', 39));
            report.AppendLine("Animals per status:");
            AddRow(report, "  Critical:", summary.Critical.ToString(CultureInfo.InvariantCulture));
            AddRow(report, "  Serious:", summary.Serious.ToString(CultureInfo.InvariantCulture));
            AddRow(report, "  Stable:", summary.Stable.ToString(CultureInfo.InvariantCulture));
            AddRow(report, "  Recovering:", summary.Recovering.ToString(CultureInfo.InvariantCulture));
            AddRow(report, "  Release-Ready:", summary.ReleaseReady.ToString(CultureInfo.InvariantCulture));
            return report.ToString();
        }

        private static void AddRow(StringBuilder report, string label, string value)
        {
            // Values begin in column 26, matching Section 5.2 of the brief.
            report.AppendLine(label.PadRight(25) + value);
        }

        public static void Save(AnimalSummary summary, DateTime generated)
        {
            // Overwrites the previous report. UI handler catches file errors.
            File.WriteAllText(ReportPath, Format(summary, generated), new UTF8Encoding(false));
        }
    }
}
