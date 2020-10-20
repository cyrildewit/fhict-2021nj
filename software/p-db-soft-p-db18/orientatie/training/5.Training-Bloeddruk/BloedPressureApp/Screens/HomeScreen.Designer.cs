namespace BloedPressureApp
{
    partial class HomeScreen
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
            this.labelPatientTitle = new System.Windows.Forms.Label();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.buttonAddPatient = new System.Windows.Forms.Button();
            this.buttonRefreshPatientsDataViewGrid = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPatientTitle
            // 
            this.labelPatientTitle.AutoSize = true;
            this.labelPatientTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientTitle.Location = new System.Drawing.Point(32, 29);
            this.labelPatientTitle.Name = "labelPatientTitle";
            this.labelPatientTitle.Size = new System.Drawing.Size(114, 29);
            this.labelPatientTitle.TabIndex = 0;
            this.labelPatientTitle.Text = "Patiënten";
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.Birthdate,
            this.Gender});
            this.dataGridViewPatients.Location = new System.Drawing.Point(37, 77);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.RowHeadersWidth = 51;
            this.dataGridViewPatients.RowTemplate.Height = 24;
            this.dataGridViewPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatients.Size = new System.Drawing.Size(649, 361);
            this.dataGridViewPatients.TabIndex = 1;
            this.dataGridViewPatients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPatients_CellDoubleClick);
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.Location = new System.Drawing.Point(444, 29);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(152, 30);
            this.buttonAddPatient.TabIndex = 2;
            this.buttonAddPatient.Text = "Patiënt toevoegen";
            this.buttonAddPatient.UseVisualStyleBackColor = true;
            this.buttonAddPatient.Click += new System.EventHandler(this.ButtonAddPatient_Click);
            // 
            // buttonRefreshPatientsDataViewGrid
            // 
            this.buttonRefreshPatientsDataViewGrid.Location = new System.Drawing.Point(602, 29);
            this.buttonRefreshPatientsDataViewGrid.Name = "buttonRefreshPatientsDataViewGrid";
            this.buttonRefreshPatientsDataViewGrid.Size = new System.Drawing.Size(84, 30);
            this.buttonRefreshPatientsDataViewGrid.TabIndex = 3;
            this.buttonRefreshPatientsDataViewGrid.Text = "Verversen";
            this.buttonRefreshPatientsDataViewGrid.UseVisualStyleBackColor = true;
            this.buttonRefreshPatientsDataViewGrid.Click += new System.EventHandler(this.ButtonRefreshPatientsDataViewGrid_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Voornaam";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Achternaam";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Birthdate
            // 
            this.Birthdate.DataPropertyName = "Birthdate";
            this.Birthdate.HeaderText = "Geboortedatum";
            this.Birthdate.MinimumWidth = 6;
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Geslacht";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRefreshPatientsDataViewGrid);
            this.Controls.Add(this.buttonAddPatient);
            this.Controls.Add(this.dataGridViewPatients);
            this.Controls.Add(this.labelPatientTitle);
            this.Name = "HomeScreen";
            this.Text = "Patiënten Register";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPatientTitle;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.Button buttonAddPatient;
        private System.Windows.Forms.Button buttonRefreshPatientsDataViewGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
    }
}

