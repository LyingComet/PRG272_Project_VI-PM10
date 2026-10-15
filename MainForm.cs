using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            TextBox box;

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
        //Lander !! explanation required for this method
        private void LoadAnimaltoForm(Animal animal)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            string id = txtId.Text.Trim().ToUpper();
            Animal animal = animals.FirstOrDefault(x => x.Id == id);

            if (animal == null)
            {
                MessageBox.Show("Animal not found.");
                return;
            }

            LoadAnimaltoForm(animal);
        }

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
        // Lander here as well.
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
    }
}

