using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Project_PRG271
{
    public partial class MainForm
    {
        // Call once, immediately after InitializeComponent() in MainForm.cs.
        private void InitializeSummary()
        {
            btnGenerateSummary.Click += btnGenerateSummary_Click;
        }

        private void ShowSummary(AnimalSummary summary)
        {
            lblTotalValue.Text = "Total Animals: " + summary.Total;
            lblAvgAgeValue.Text = "Average Age (years): " + summary.AverageAge;
            lblAvgScoreValue.Text = "Average Recovery Score: " + summary.AverageScore;
            lblCriticalValue.Text = "Critical: " + summary.Critical;
            lblSeriousValue.Text = "Serious: " + summary.Serious;
            lblStableValue.Text = "Stable: " + summary.Stable;
            lblRecoveringValue.Text = "Recovering: " + summary.Recovering;
            lblReleaseReadyValue.Text = "Release-Ready: " + summary.ReleaseReady;
        }

        // Read the current file directly so a read failure cannot become a false empty report.
        // Reuse the team's parser and duplicate-ID behaviour.
        private static List<Animal> ReadSummaryAnimals()
        {
            List<Animal> records = new List<Animal>();
            HashSet<string> ids = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (string line in File.ReadAllLines(FileHandler.FilePath))
            {
                Animal animal;
                if (FileHandler.TryParseLine(line, out animal) && ids.Add(animal.Id))
                    records.Add(animal);
            }
            return records;
        }

        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {
            try
            {
                AnimalSummary summary = AnimalSummary.Calculate(ReadSummaryAnimals());
                ShowSummary(summary);
                SummaryReport.Save(summary, DateTime.Now);

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Cannot generate the summary because animals.txt is missing. Restore it and try again.", "Summary error");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("The data or report folder could not be found. Check the folder and try again.", "Summary error");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Cannot access animals.txt or write summary.txt. Check file permissions and read-only settings.", "Summary error");
            }
            catch (IOException)
            {
                MessageBox.Show("Cannot read the data or save the report. Close programs using these files, check the disk, and try again.", "Summary error");
            }
        }
    }
}
