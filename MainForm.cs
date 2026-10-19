using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_PRG271
{
    public partial class MainForm : Form
    {

        //animals that showing on grid
        private List<Animal> animals = new List<Animal>();
        private FileHandler handler = new FileHandler();
        private Animal selectedAnimal = null;
        private bool editMode = false;
        public MainForm()
        {
            InitializeComponent();
            InitializeSummary();
            dgvAnimals.AutoGenerateColumns = false;
        }

        //run when main form has been opened
        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();

            //tells the user about the bad lines and its ONLY here so its gonna show once
            if (handler.LinesSkipped > 0)
            {
                MessageBox.Show(handler.LinesSkipped + " line(s) in animals.txt could not be read, so they were skipped.");
            }
        }

        private void RefreshGrid()
        {
            animals = handler.Load();

            //emptying grid so no double results
            dgvAnimals.DataSource = null;
            dgvAnimals.DataSource = animals;

            //grid highlights foirst row by itself so clear it otherwise delete might remove a row usedr never picked
            dgvAnimals.ClearSelection();
            dgvAnimals.CurrentCell = null;
        }

        // checks the inputs, saves the new animal and shows its status and housing
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim().ToUpper();
            string name = txtName.Text.Trim();
            string species = txtSpecies.Text.Trim();
            string age = txtAge.Text.Trim();
            string score = txtScore.Text.Trim();

            AnimalValidator validator = new AnimalValidator();
            string message = validator.Validate(id, name, species, age, score, animals, true);

            if (message != "")
            {
                MessageBox.Show(message, "Check your details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FocusField(validator.ErrorField);
                return;
            }

            Animal animal = new Animal(id, name, species, int.Parse(age), int.Parse(score));

            if (!handler.AddAnimal(animal))
            {
                return;
            }

            MessageBox.Show(animal.Name + " the " + animal.Species + " has been added." + Environment.NewLine + Environment.NewLine +
                "Status: " + animal.Status + Environment.NewLine +
                "Housing Unit: " + animal.HousingUnit, "Animal added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshGrid();
            ClearInputs();
        }

        // puts the cursor back in the box that has the mistake
        private void FocusField(string field)
        {
            System.Windows.Forms.TextBox box;

            switch (field)
            {
                case "ID":
                    box = txtId;
                    break;
                case "Name":
                    box = txtName;
                    break;
                case "Species":
                    box = txtSpecies;
                    break;
                case "Age":
                    box = txtAge;
                    break;
                case "Score":
                    box = txtScore;
                    break;
                default:
                    return;
            }

            box.Focus();
            box.SelectAll();
        }

        // empties all the input boxes
        private void ClearInputs()
        {
            txtId.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            txtAge.Clear();
            txtScore.Clear();
            txtId.Focus();
        }
        //An method that loads the animals to the form for the search function
        public void LoadAnimaltoForm(Animal animal)
        {
            txtId.Text = animal.Id;
            txtName.Text = animal.Name;
            txtSpecies.Text = animal.Species;
            txtAge.Text = animal.Age.ToString();
            txtScore.Text = animal.Score.ToString();

            selectedAnimal = animal;
            editMode = true;
            txtId.ReadOnly = true;
            btnAdd.Enabled = false;
            btnSaveChanges.Enabled = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvAnimals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)

                return;
            
            Animal animal = (Animal)dgvAnimals.Rows[e.RowIndex].DataBoundItem;
            LoadAnimaltoForm(animal);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //searches for the id add it to be edited and then also highlights the data.
        private void btnSearch_Click(object sender, EventArgs e)
        {

            string id = txtSearchId.Text.Trim().ToUpper();

            foreach (Animal animal in animals)
            {
                if (animal.Id.Trim().ToUpper() == id)
                {
                    LoadAnimaltoForm(animal);

                    for (int i = 0; i < dgvAnimals.Rows.Count; i++)
                    {
                        Animal rowAnimal =
                            (Animal)dgvAnimals.Rows[i].DataBoundItem;

                        if (rowAnimal.Id == animal.Id)
                        {
                            dgvAnimals.ClearSelection();
                            dgvAnimals.Rows[i].Selected = true;
                            dgvAnimals.CurrentCell =
                                dgvAnimals.Rows[i].Cells[0];
                            break;
                        }
                    }

                    return;
                }
            }

            MessageBox.Show("Animal not found.");
        }




        
        //Clears the cache in the textboxes
        private void btnClear_Click(object sender, EventArgs e)
        {
            selectedAnimal = null;
            editMode = false;
            txtId.ReadOnly = false;
            btnAdd.Enabled = true;
            btnSaveChanges.Enabled = false;

            ClearInputs();
            dgvAnimals.ClearSelection();
        }
        // Checks if the animal is here before it can update the changes to the text file.
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (selectedAnimal == null) 
            {
                MessageBox.Show("Please load an animal before save");
                
                return;
            }

            string id = txtId.Text.Trim().ToUpper();
            string name = txtName.Text.Trim().ToUpper();
            string species = txtSpecies.Text.Trim().ToUpper();
            string age = txtAge.Text.Trim().ToUpper();
            string score = txtScore.Text.Trim().ToUpper();

            AnimalValidator validator = new AnimalValidator();

            string message = validator.Validate(id, name, species, age, score, animals, false);

            //checks if string is empty somewhere and displays where the value isn't
            if (!string.IsNullOrEmpty(message)) 
            { 
            
            MessageBox.Show(message);
                FocusField(validator.ErrorField);
            return;
            }

            Animal updatedAnimal = new Animal(id, name, species, int.Parse(age), int.Parse(score));

            handler.UpdateAnimal(updatedAnimal);

            MessageBox.Show("Animal updated");

            //refreshes grid and loads it again
            RefreshGrid();
            btnClear_Click(sender, e);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAnimals.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select an animal to delete.",
                    "No animal selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            Animal animal = dgvAnimals.SelectedRows[0].DataBoundItem as Animal;

            if (animal == null)
            {
                MessageBox.Show("Could not identify the selected animal.");
                return;
            }

            DialogResult result = MessageBox.Show(
            "Delete " + animal.Id + " (" + animal.Name +
            ")? This cannot be undone.",
            "Confirm deletion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            bool clearForm = selectedAnimal != null &&
                             selectedAnimal.Id == animal.Id;

            if (!handler.DeleteAnimal(animal.Id))
            {
                return;
            }

            if (clearForm)
            {
                btnClear_Click(sender, e);
            }
            //got help here (google and youtube here)
            RefreshGrid();

            MessageBox.Show(
                animal.Name + " was deleted successfully.",
                "Animal deleted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {
            List<Animal> currentAnimals = handler.Load();

            int total = currentAnimals.Count;
            double averageAge = 0;
            double averageScore = 0;

            int critical = 0;
            int serious = 0;
            int stable = 0;
            int recovering = 0;
            int releaseReady = 0;

            foreach (Animal animal in currentAnimals)
            {
                averageAge += animal.Age;
                averageScore += animal.Score;

                switch (animal.Status)
                {
                    case "Critical":
                        critical++;
                        break;
                    case "Serious":
                        serious++;
                        break;
                    case "Stable":
                        stable++;
                        break;
                    case "Recovering":
                        recovering++;
                        break;
                    case "Release-Ready":
                        releaseReady++;
                        break;
                }
            }

            if (total > 0)
            {
                averageAge /= total;
                averageScore /= total;

                lblAvgAgeValue.Text = averageAge.ToString("F2",
                    System.Globalization.CultureInfo.InvariantCulture);
                lblAvgScoreValue.Text = averageScore.ToString("F2",
                    System.Globalization.CultureInfo.InvariantCulture);
            }
            else
            {
                lblAvgAgeValue.Text = "N/A";
                lblAvgScoreValue.Text = "N/A";
            }

            lblTotalValue.Text = total.ToString();
            lblCriticalValue.Text = critical.ToString();
            lblSeriousValue.Text = serious.ToString();
            lblStableValue.Text = stable.ToString();
            lblRecoveringValue.Text = recovering.ToString();
            lblReleaseReadyValue.Text = releaseReady.ToString();

            string path = System.IO.Path.Combine(
                AppContext.BaseDirectory, "summary.txt");

            try
            {
                List<string> lines = new List<string>();

                lines.Add("BAOBAB RIDGE WILDLIFE REHABILITATION CENTRE");
                lines.Add("ANIMAL SUMMARY REPORT");
                lines.Add("Generated: " +
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                lines.Add("Total animals:    " + total);

                string ageText = total == 0
                    ? "N/A"
                    : averageAge.ToString("F2",
                        System.Globalization.CultureInfo.InvariantCulture);

                string scoreText = total == 0
                    ? "N/A"
                    : averageScore.ToString("F2",
                        System.Globalization.CultureInfo.InvariantCulture);

                lines.Add("Average age (years):      " + ageText);
                lines.Add("Average recovery score:   " + scoreText);
                lines.Add("Animals per status:");
                lines.Add("Critical:               " + critical);
                lines.Add("Serious:                " + serious);
                lines.Add("Stable:                 " + stable);
                lines.Add("Recovering:             " + recovering);
                lines.Add("Release-Ready:          " + releaseReady);

                System.IO.File.WriteAllLines(path, lines,
                    System.Text.Encoding.UTF8);

                MessageBox.Show(
                    "Summary generated successfully.",
                    "Summary Report",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Could not write summary.txt. Check whether the file is open or in use.");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Could not write summary.txt because you do not have permission.");
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}

