namespace Project_PRG271
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvAnimals = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHousingUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblSeriousValue = new System.Windows.Forms.Label();
            this.lblStableValue = new System.Windows.Forms.Label();
            this.lblRecoveringValue = new System.Windows.Forms.Label();
            this.lblReleaseReadyValue = new System.Windows.Forms.Label();
            this.lblCriticalValue = new System.Windows.Forms.Label();
            this.lblAvgScoreValue = new System.Windows.Forms.Label();
            this.lblAvgAgeValue = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.btnGenerateSummary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpSearch.SuspendLayout();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).BeginInit();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtSearchId);
            this.grpSearch.Location = new System.Drawing.Point(9, 10);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(2);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(2);
            this.grpSearch.Size = new System.Drawing.Size(224, 65);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search by Animal ID";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(154, 21);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 28);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchId
            // 
            this.txtSearchId.Location = new System.Drawing.Point(4, 26);
            this.txtSearchId.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(146, 20);
            this.txtSearchId.TabIndex = 0;
            this.txtSearchId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.btnClear);
            this.grpDetails.Controls.Add(this.btnSaveChanges);
            this.grpDetails.Controls.Add(this.btnAdd);
            this.grpDetails.Controls.Add(this.txtSpecies);
            this.grpDetails.Controls.Add(this.txtAge);
            this.grpDetails.Controls.Add(this.txtScore);
            this.grpDetails.Controls.Add(this.txtId);
            this.grpDetails.Controls.Add(this.txtName);
            this.grpDetails.Controls.Add(this.lblId);
            this.grpDetails.Controls.Add(this.lblScore);
            this.grpDetails.Controls.Add(this.lblAge);
            this.grpDetails.Controls.Add(this.lblSpecies);
            this.grpDetails.Controls.Add(this.lblName);
            this.grpDetails.Location = new System.Drawing.Point(9, 80);
            this.grpDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpDetails.Size = new System.Drawing.Size(224, 260);
            this.grpDetails.TabIndex = 1;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Animal Details";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(161, 205);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(48, 28);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.Location = new System.Drawing.Point(62, 205);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(95, 28);
            this.btnSaveChanges.TabIndex = 7;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 205);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 28);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSpecies
            // 
            this.txtSpecies.Location = new System.Drawing.Point(106, 86);
            this.txtSpecies.Margin = new System.Windows.Forms.Padding(2);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(104, 20);
            this.txtSpecies.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(106, 119);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(104, 20);
            this.txtAge.TabIndex = 4;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(106, 151);
            this.txtScore.Margin = new System.Windows.Forms.Padding(2);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(104, 20);
            this.txtScore.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(106, 29);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(104, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 58);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(104, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(7, 32);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(55, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Animal ID:";
            this.lblId.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(7, 151);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(87, 13);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Recovery Score:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(7, 119);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(65, 13);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age (Years):";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(7, 91);
            this.lblSpecies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(48, 13);
            this.lblSpecies.TabIndex = 1;
            this.lblSpecies.Text = "Species:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 63);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // dgvAnimals
            // 
            this.dgvAnimals.AllowUserToAddRows = false;
            this.dgvAnimals.AllowUserToDeleteRows = false;
            this.dgvAnimals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colSpecies,
            this.colAge,
            this.colScore,
            this.colStatus,
            this.colHousingUnit});
            this.dgvAnimals.Location = new System.Drawing.Point(276, 10);
            this.dgvAnimals.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAnimals.MultiSelect = false;
            this.dgvAnimals.Name = "dgvAnimals";
            this.dgvAnimals.ReadOnly = true;
            this.dgvAnimals.RowHeadersVisible = false;
            this.dgvAnimals.RowHeadersWidth = 51;
            this.dgvAnimals.RowTemplate.Height = 24;
            this.dgvAnimals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnimals.Size = new System.Drawing.Size(654, 330);
            this.dgvAnimals.TabIndex = 2;
            this.dgvAnimals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnimals_CellContentClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Animal ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colSpecies
            // 
            this.colSpecies.DataPropertyName = "Species";
            this.colSpecies.HeaderText = "Species";
            this.colSpecies.MinimumWidth = 6;
            this.colSpecies.Name = "colSpecies";
            this.colSpecies.ReadOnly = true;
            // 
            // colAge
            // 
            this.colAge.DataPropertyName = "Age";
            this.colAge.HeaderText = "Age";
            this.colAge.MinimumWidth = 6;
            this.colAge.Name = "colAge";
            this.colAge.ReadOnly = true;
            // 
            // colScore
            // 
            this.colScore.DataPropertyName = "Score";
            this.colScore.HeaderText = "Recovery Score";
            this.colScore.MinimumWidth = 6;
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colHousingUnit
            // 
            this.colHousingUnit.DataPropertyName = "HousingUnit";
            this.colHousingUnit.HeaderText = "Housing Unit";
            this.colHousingUnit.MinimumWidth = 6;
            this.colHousingUnit.Name = "colHousingUnit";
            this.colHousingUnit.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(276, 352);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.label8);
            this.grpSummary.Controls.Add(this.label7);
            this.grpSummary.Controls.Add(this.label6);
            this.grpSummary.Controls.Add(this.label5);
            this.grpSummary.Controls.Add(this.label4);
            this.grpSummary.Controls.Add(this.label3);
            this.grpSummary.Controls.Add(this.label2);
            this.grpSummary.Controls.Add(this.label1);
            this.grpSummary.Controls.Add(this.lblSeriousValue);
            this.grpSummary.Controls.Add(this.lblStableValue);
            this.grpSummary.Controls.Add(this.lblRecoveringValue);
            this.grpSummary.Controls.Add(this.lblReleaseReadyValue);
            this.grpSummary.Controls.Add(this.lblCriticalValue);
            this.grpSummary.Controls.Add(this.lblAvgScoreValue);
            this.grpSummary.Controls.Add(this.lblAvgAgeValue);
            this.grpSummary.Controls.Add(this.lblTotalValue);
            this.grpSummary.Controls.Add(this.btnGenerateSummary);
            this.grpSummary.Location = new System.Drawing.Point(278, 398);
            this.grpSummary.Margin = new System.Windows.Forms.Padding(2);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Padding = new System.Windows.Forms.Padding(2);
            this.grpSummary.Size = new System.Drawing.Size(652, 220);
            this.grpSummary.TabIndex = 4;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary Report";
            // 
            // lblSeriousValue
            // 
            this.lblSeriousValue.AutoSize = true;
            this.lblSeriousValue.Location = new System.Drawing.Point(473, 65);
            this.lblSeriousValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeriousValue.Name = "lblSeriousValue";
            this.lblSeriousValue.Size = new System.Drawing.Size(13, 13);
            this.lblSeriousValue.TabIndex = 8;
            this.lblSeriousValue.Text = "0";
            // 
            // lblStableValue
            // 
            this.lblStableValue.AutoSize = true;
            this.lblStableValue.Location = new System.Drawing.Point(473, 105);
            this.lblStableValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStableValue.Name = "lblStableValue";
            this.lblStableValue.Size = new System.Drawing.Size(13, 13);
            this.lblStableValue.TabIndex = 7;
            this.lblStableValue.Text = "0";
            this.lblStableValue.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblRecoveringValue
            // 
            this.lblRecoveringValue.AutoSize = true;
            this.lblRecoveringValue.Location = new System.Drawing.Point(473, 142);
            this.lblRecoveringValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecoveringValue.Name = "lblRecoveringValue";
            this.lblRecoveringValue.Size = new System.Drawing.Size(13, 13);
            this.lblRecoveringValue.TabIndex = 6;
            this.lblRecoveringValue.Text = "0";
            // 
            // lblReleaseReadyValue
            // 
            this.lblReleaseReadyValue.AutoSize = true;
            this.lblReleaseReadyValue.Location = new System.Drawing.Point(473, 181);
            this.lblReleaseReadyValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReleaseReadyValue.Name = "lblReleaseReadyValue";
            this.lblReleaseReadyValue.Size = new System.Drawing.Size(13, 13);
            this.lblReleaseReadyValue.TabIndex = 5;
            this.lblReleaseReadyValue.Text = "0";
            // 
            // lblCriticalValue
            // 
            this.lblCriticalValue.AutoSize = true;
            this.lblCriticalValue.Location = new System.Drawing.Point(473, 31);
            this.lblCriticalValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCriticalValue.Name = "lblCriticalValue";
            this.lblCriticalValue.Size = new System.Drawing.Size(13, 13);
            this.lblCriticalValue.TabIndex = 4;
            this.lblCriticalValue.Text = "0";
            this.lblCriticalValue.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblAvgScoreValue
            // 
            this.lblAvgScoreValue.AutoSize = true;
            this.lblAvgScoreValue.Location = new System.Drawing.Point(152, 168);
            this.lblAvgScoreValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvgScoreValue.Name = "lblAvgScoreValue";
            this.lblAvgScoreValue.Size = new System.Drawing.Size(13, 13);
            this.lblAvgScoreValue.TabIndex = 3;
            this.lblAvgScoreValue.Text = "0";
            // 
            // lblAvgAgeValue
            // 
            this.lblAvgAgeValue.AutoSize = true;
            this.lblAvgAgeValue.Location = new System.Drawing.Point(125, 115);
            this.lblAvgAgeValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvgAgeValue.Name = "lblAvgAgeValue";
            this.lblAvgAgeValue.Size = new System.Drawing.Size(13, 13);
            this.lblAvgAgeValue.TabIndex = 2;
            this.lblAvgAgeValue.Text = "0";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(113, 65);
            this.lblTotalValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(13, 13);
            this.lblTotalValue.TabIndex = 1;
            this.lblTotalValue.Text = "0";
            this.lblTotalValue.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGenerateSummary
            // 
            this.btnGenerateSummary.Location = new System.Drawing.Point(8, 20);
            this.btnGenerateSummary.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateSummary.Name = "btnGenerateSummary";
            this.btnGenerateSummary.Size = new System.Drawing.Size(118, 24);
            this.btnGenerateSummary.TabIndex = 0;
            this.btnGenerateSummary.Text = "Generate Summary";
            this.btnGenerateSummary.UseVisualStyleBackColor = true;
            this.btnGenerateSummary.Click += new System.EventHandler(this.btnGenerateSummary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total Animals:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Average Age (years):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Average Recovery Score: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Critical: ";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Serious: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Stable: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Recovering: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Release-Ready: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 636);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvAnimals);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpSearch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baobab Ridge Wildlife Rehabilitation Records";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).EndInit();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvAnimals;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Button btnGenerateSummary;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblAvgScoreValue;
        private System.Windows.Forms.Label lblAvgAgeValue;
        private System.Windows.Forms.Label lblCriticalValue;
        private System.Windows.Forms.Label lblSeriousValue;
        private System.Windows.Forms.Label lblStableValue;
        private System.Windows.Forms.Label lblRecoveringValue;
        private System.Windows.Forms.Label lblReleaseReadyValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecies;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHousingUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}