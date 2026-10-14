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
            if (FileHandler.LinesSkipped > 0)
            {
                MessageBox.Show(FileHandler.LinesSkipped + " Line/s Skipped"); 
            }
        }

        private void RefreshGrid()
        {
            animals = FileHandler.Load();

            //emptying grid so no double results
            dgvAnimals.DataSource = null;
            dgvAnimals.DataSource = animals;

            //grid highlights foirst row by itself so clear it otherwise delete might remove a row usedr never picked
            dgvAnimals.ClearSelection();
            dgvAnimals.CurrentCell = null;
        }

        //Add button: validate the inputs, append ONE line to animals.txt, then show the result
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //same validation method Update uses; checkUnique = true because this is a new ID
            ValidationResult result = AnimalValidator.Validate(txtId.Text, txtName.Text, txtSpecies.Text,
                txtAge.Text, txtScore.Text, animals, true);

            if (!result.IsValid)
            {
                //nothing is saved; name the problem and send the cursor back to that box
                MessageBox.Show(result.Message, "Please fix this field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FocusField(result.Field);
                return;
            }

            Animal newAnimal = result.Animal;

            string errorMessage;
            if (!FileHandler.AppendAnimal(newAnimal, out errorMessage))
            {
                //keep what the user typed so they can try again after fixing the file problem
                MessageBox.Show(errorMessage, "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(newAnimal.Id + " (" + newAnimal.Name + ") was added." + Environment.NewLine + Environment.NewLine +
                "Status: " + newAnimal.Status + Environment.NewLine +
                "Housing Unit: " + newAnimal.HousingUnit,
                "Animal added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshGrid();
            ClearInputs();
        }

        //puts the cursor in the box that failed validation and highlights what is in it
        private void FocusField(AnimalField field)
        {
            TextBox box;
            switch (field)
            {
                case AnimalField.Id: box = txtId; break;
                case AnimalField.Name: box = txtName; break;
                case AnimalField.Species: box = txtSpecies; break;
                case AnimalField.Age: box = txtAge; break;
                case AnimalField.Score: box = txtScore; break;
                default: return;
            }

            box.Focus();
            box.SelectAll();
        }

        //empties all the input boxes and puts the cursor back in Animal ID (Clear/Update can reuse this)
        private void ClearInputs()
        {
            txtId.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            txtAge.Clear();
            txtScore.Clear();
            txtId.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvAnimals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        }
    }
}

