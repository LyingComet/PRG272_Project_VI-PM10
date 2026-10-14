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
            this.grpSearch.Location = new System.Drawing.Point(12, 12);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(298, 80);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search by Animal ID";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(205, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 34);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchId
            // 
            this.txtSearchId.Location = new System.Drawing.Point(6, 32);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(193, 22);
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
            this.grpDetails.Location = new System.Drawing.Point(12, 98);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(298, 320);
            this.grpDetails.TabIndex = 1;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Animal Details";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(215, 252);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 35);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.Location = new System.Drawing.Point(82, 252);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(127, 35);
            this.btnSaveChanges.TabIndex = 7;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 252);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 35);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSpecies
            // 
            this.txtSpecies.Location = new System.Drawing.Point(142, 106);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(137, 22);
            this.txtSpecies.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(142, 147);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(137, 22);
            this.txtAge.TabIndex = 4;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(142, 186);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(137, 22);
            this.txtScore.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(142, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(137, 22);
            this.txtId.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(142, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 22);
            this.txtName.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(9, 39);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(67, 16);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Animal ID:";
            this.lblId.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(9, 186);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(108, 16);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Recovery Score:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(9, 147);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(82, 16);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age (Years):";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(9, 112);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(60, 16);
            this.lblSpecies.TabIndex = 1;
            this.lblSpecies.Text = "Species:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
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
            this.dgvAnimals.Location = new System.Drawing.Point(368, 12);
            this.dgvAnimals.MultiSelect = false;
            this.dgvAnimals.Name = "dgvAnimals";
            this.dgvAnimals.ReadOnly = true;
            this.dgvAnimals.RowHeadersVisible = false;
            this.dgvAnimals.RowHeadersWidth = 51;
            this.dgvAnimals.RowTemplate.Height = 24;
            this.dgvAnimals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnimals.Size = new System.Drawing.Size(872, 406);
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
            this.btnDelete.Location = new System.Drawing.Point(368, 433);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(205, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblSeriousValue);
            this.grpSummary.Controls.Add(this.lblStableValue);
            this.grpSummary.Controls.Add(this.lblRecoveringValue);
            this.grpSummary.Controls.Add(this.lblReleaseReadyValue);
            this.grpSummary.Controls.Add(this.lblCriticalValue);
            this.grpSummary.Controls.Add(this.lblAvgScoreValue);
            this.grpSummary.Controls.Add(this.lblAvgAgeValue);
            this.grpSummary.Controls.Add(this.lblTotalValue);
            this.grpSummary.Controls.Add(this.btnGenerateSummary);
            this.grpSummary.Location = new System.Drawing.Point(370, 490);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(869, 271);
            this.grpSummary.TabIndex = 4;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary Report";
            // 
            // lblSeriousValue
            // 
            this.lblSeriousValue.AutoSize = true;
            this.lblSeriousValue.Location = new System.Drawing.Point(513, 80);
            this.lblSeriousValue.Name = "lblSeriousValue";
            this.lblSeriousValue.Size = new System.Drawing.Size(56, 16);
            this.lblSeriousValue.TabIndex = 8;
            this.lblSeriousValue.Text = "Serious:";
            // 
            // lblStableValue
            // 
            this.lblStableValue.AutoSize = true;
            this.lblStableValue.Location = new System.Drawing.Point(513, 129);
            this.lblStableValue.Name = "lblStableValue";
            this.lblStableValue.Size = new System.Drawing.Size(49, 16);
            this.lblStableValue.TabIndex = 7;
            this.lblStableValue.Text = "Stable:";
            this.lblStableValue.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblRecoveringValue
            // 
            this.lblRecoveringValue.AutoSize = true;
            this.lblRecoveringValue.Location = new System.Drawing.Point(513, 177);
            this.lblRecoveringValue.Name = "lblRecoveringValue";
            this.lblRecoveringValue.Size = new System.Drawing.Size(80, 16);
            this.lblRecoveringValue.TabIndex = 6;
            this.lblRecoveringValue.Text = "Recovering:";
            // 
            // lblReleaseReadyValue
            // 
            this.lblReleaseReadyValue.AutoSize = true;
            this.lblReleaseReadyValue.Location = new System.Drawing.Point(513, 226);
            this.lblReleaseReadyValue.Name = "lblReleaseReadyValue";
            this.lblReleaseReadyValue.Size = new System.Drawing.Size(107, 16);
            this.lblReleaseReadyValue.TabIndex = 5;
            this.lblReleaseReadyValue.Text = "Release-Ready:";
            // 
            // lblCriticalValue
            // 
            this.lblCriticalValue.AutoSize = true;
            this.lblCriticalValue.Location = new System.Drawing.Point(513, 37);
            this.lblCriticalValue.Name = "lblCriticalValue";
            this.lblCriticalValue.Size = new System.Drawing.Size(50, 16);
            this.lblCriticalValue.TabIndex = 4;
            this.lblCriticalValue.Text = "Critical:";
            this.lblCriticalValue.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblAvgScoreValue
            // 
            this.lblAvgScoreValue.AutoSize = true;
            this.lblAvgScoreValue.Location = new System.Drawing.Point(19, 211);
            this.lblAvgScoreValue.Name = "lblAvgScoreValue";
            this.lblAvgScoreValue.Size = new System.Drawing.Size(163, 16);
            this.lblAvgScoreValue.TabIndex = 3;
            this.lblAvgScoreValue.Text = "Average Recovery Score:";
            // 
            // lblAvgAgeValue
            // 
            this.lblAvgAgeValue.AutoSize = true;
            this.lblAvgAgeValue.Location = new System.Drawing.Point(19, 143);
            this.lblAvgAgeValue.Name = "lblAvgAgeValue";
            this.lblAvgAgeValue.Size = new System.Drawing.Size(135, 16);
            this.lblAvgAgeValue.TabIndex = 2;
            this.lblAvgAgeValue.Text = "Average Age (years):";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(19, 80);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(92, 16);
            this.lblTotalValue.TabIndex = 1;
            this.lblTotalValue.Text = "Total Animals:";
            this.lblTotalValue.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGenerateSummary
            // 
            this.btnGenerateSummary.Location = new System.Drawing.Point(10, 24);
            this.btnGenerateSummary.Name = "btnGenerateSummary";
            this.btnGenerateSummary.Size = new System.Drawing.Size(157, 29);
            this.btnGenerateSummary.TabIndex = 0;
            this.btnGenerateSummary.Text = "Generate Summary";
            this.btnGenerateSummary.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 783);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvAnimals);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpSearch);
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
    }
}