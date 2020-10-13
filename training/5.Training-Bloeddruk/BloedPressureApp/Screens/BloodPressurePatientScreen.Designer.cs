namespace BloedPressureApp
{
    partial class BloodPressurePatient
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
            this.labelAddPatientTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPatientName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownUpperPressure = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBoxNotes = new System.Windows.Forms.RichTextBox();
            this.buttonAddBloodPressureToRecord = new System.Windows.Forms.Button();
            this.labelResultScore = new System.Windows.Forms.Label();
            this.labelResultScoreBefore = new System.Windows.Forms.Label();
            this.labelMAN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownUnderPressure = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewBloodPressures = new System.Windows.Forms.DataGridView();
            this.buttonRefreshPatientsDataViewGrid = new System.Windows.Forms.Button();
            this.UpperPressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnderPressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aantekeningen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpperPressure)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnderPressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBloodPressures)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddPatientTitle
            // 
            this.labelAddPatientTitle.AutoSize = true;
            this.labelAddPatientTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddPatientTitle.Location = new System.Drawing.Point(28, 28);
            this.labelAddPatientTitle.Name = "labelAddPatientTitle";
            this.labelAddPatientTitle.Size = new System.Drawing.Size(124, 29);
            this.labelAddPatientTitle.TabIndex = 2;
            this.labelAddPatientTitle.Text = "Bloeddruk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient:";
            // 
            // labelPatientName
            // 
            this.labelPatientName.AutoSize = true;
            this.labelPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientName.Location = new System.Drawing.Point(100, 74);
            this.labelPatientName.Name = "labelPatientName";
            this.labelPatientName.Size = new System.Drawing.Size(0, 20);
            this.labelPatientName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // numericUpDownUpperPressure
            // 
            this.numericUpDownUpperPressure.Location = new System.Drawing.Point(10, 41);
            this.numericUpDownUpperPressure.Maximum = new decimal(new int[] {
            190,
            0,
            0,
            0});
            this.numericUpDownUpperPressure.Minimum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numericUpDownUpperPressure.Name = "numericUpDownUpperPressure";
            this.numericUpDownUpperPressure.Size = new System.Drawing.Size(84, 22);
            this.numericUpDownUpperPressure.TabIndex = 6;
            this.numericUpDownUpperPressure.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bovendruk";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.richTextBoxNotes);
            this.groupBox1.Controls.Add(this.buttonAddBloodPressureToRecord);
            this.groupBox1.Controls.Add(this.labelResultScore);
            this.groupBox1.Controls.Add(this.labelResultScoreBefore);
            this.groupBox1.Controls.Add(this.labelMAN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDownUnderPressure);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownUpperPressure);
            this.groupBox1.Location = new System.Drawing.Point(33, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 338);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Aantekeningen";
            // 
            // richTextBoxNotes
            // 
            this.richTextBoxNotes.Location = new System.Drawing.Point(10, 220);
            this.richTextBoxNotes.Name = "richTextBoxNotes";
            this.richTextBoxNotes.Size = new System.Drawing.Size(386, 83);
            this.richTextBoxNotes.TabIndex = 14;
            this.richTextBoxNotes.Text = "";
            // 
            // buttonAddBloodPressureToRecord
            // 
            this.buttonAddBloodPressureToRecord.Location = new System.Drawing.Point(10, 309);
            this.buttonAddBloodPressureToRecord.Name = "buttonAddBloodPressureToRecord";
            this.buttonAddBloodPressureToRecord.Size = new System.Drawing.Size(231, 23);
            this.buttonAddBloodPressureToRecord.TabIndex = 10;
            this.buttonAddBloodPressureToRecord.Text = "Toevoegen aan dossier";
            this.buttonAddBloodPressureToRecord.UseVisualStyleBackColor = true;
            this.buttonAddBloodPressureToRecord.Click += new System.EventHandler(this.ButtonAddBloodPressureToRecord_Click);
            // 
            // labelResultScore
            // 
            this.labelResultScore.AutoSize = true;
            this.labelResultScore.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelResultScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultScore.Location = new System.Drawing.Point(257, 82);
            this.labelResultScore.Name = "labelResultScore";
            this.labelResultScore.Size = new System.Drawing.Size(13, 20);
            this.labelResultScore.TabIndex = 13;
            this.labelResultScore.Text = ".";
            // 
            // labelResultScoreBefore
            // 
            this.labelResultScoreBefore.AutoSize = true;
            this.labelResultScoreBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultScoreBefore.Location = new System.Drawing.Point(161, 82);
            this.labelResultScoreBefore.Name = "labelResultScoreBefore";
            this.labelResultScoreBefore.Size = new System.Drawing.Size(90, 20);
            this.labelResultScoreBefore.TabIndex = 12;
            this.labelResultScoreBefore.Text = "Resultaat: ";
            // 
            // labelMAN
            // 
            this.labelMAN.AutoSize = true;
            this.labelMAN.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelMAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMAN.Location = new System.Drawing.Point(383, 41);
            this.labelMAN.Name = "labelMAN";
            this.labelMAN.Size = new System.Drawing.Size(13, 20);
            this.labelMAN.TabIndex = 11;
            this.labelMAN.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gemiddelde arteriële druk =";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "MAP Berekenen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonCalculateMAP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Onderdruk";
            // 
            // numericUpDownUnderPressure
            // 
            this.numericUpDownUnderPressure.Location = new System.Drawing.Point(10, 105);
            this.numericUpDownUnderPressure.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownUnderPressure.Name = "numericUpDownUnderPressure";
            this.numericUpDownUnderPressure.Size = new System.Drawing.Size(84, 22);
            this.numericUpDownUnderPressure.TabIndex = 8;
            this.numericUpDownUnderPressure.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // dataGridViewBloodPressures
            // 
            this.dataGridViewBloodPressures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBloodPressures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBloodPressures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UpperPressure,
            this.UnderPressure,
            this.Result,
            this.Aantekeningen});
            this.dataGridViewBloodPressures.Location = new System.Drawing.Point(493, 74);
            this.dataGridViewBloodPressures.Name = "dataGridViewBloodPressures";
            this.dataGridViewBloodPressures.RowHeadersWidth = 51;
            this.dataGridViewBloodPressures.RowTemplate.Height = 24;
            this.dataGridViewBloodPressures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBloodPressures.Size = new System.Drawing.Size(509, 371);
            this.dataGridViewBloodPressures.TabIndex = 9;
            // 
            // buttonRefreshPatientsDataViewGrid
            // 
            this.buttonRefreshPatientsDataViewGrid.Location = new System.Drawing.Point(918, 28);
            this.buttonRefreshPatientsDataViewGrid.Name = "buttonRefreshPatientsDataViewGrid";
            this.buttonRefreshPatientsDataViewGrid.Size = new System.Drawing.Size(84, 30);
            this.buttonRefreshPatientsDataViewGrid.TabIndex = 10;
            this.buttonRefreshPatientsDataViewGrid.Text = "Verversen";
            this.buttonRefreshPatientsDataViewGrid.UseVisualStyleBackColor = true;
            this.buttonRefreshPatientsDataViewGrid.Click += new System.EventHandler(this.ButtonRefreshPatientsDataViewGrid_Click);
            // 
            // UpperPressure
            // 
            this.UpperPressure.DataPropertyName = "UpperPressure";
            this.UpperPressure.HeaderText = "Bovendruk";
            this.UpperPressure.MinimumWidth = 6;
            this.UpperPressure.Name = "UpperPressure";
            this.UpperPressure.ReadOnly = true;
            // 
            // UnderPressure
            // 
            this.UnderPressure.DataPropertyName = "UnderPressure";
            this.UnderPressure.HeaderText = "Onderdruk";
            this.UnderPressure.MinimumWidth = 6;
            this.UnderPressure.Name = "UnderPressure";
            this.UnderPressure.ReadOnly = true;
            // 
            // Result
            // 
            this.Result.DataPropertyName = "Result";
            this.Result.HeaderText = "Resultaat";
            this.Result.MinimumWidth = 6;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            // 
            // Aantekeningen
            // 
            this.Aantekeningen.DataPropertyName = "Notes";
            this.Aantekeningen.HeaderText = "Notes";
            this.Aantekeningen.MinimumWidth = 6;
            this.Aantekeningen.Name = "Aantekeningen";
            this.Aantekeningen.ReadOnly = true;
            // 
            // BloodPressurePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 463);
            this.Controls.Add(this.buttonRefreshPatientsDataViewGrid);
            this.Controls.Add(this.dataGridViewBloodPressures);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPatientName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAddPatientTitle);
            this.Name = "BloodPressurePatient";
            this.Text = "Bloeddruk";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpperPressure)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnderPressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBloodPressures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddPatientTitle;
        public System.Windows.Forms.Label labelPatientName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownUpperPressure;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownUnderPressure;
        private System.Windows.Forms.Button buttonAddBloodPressureToRecord;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label labelMAN;
        public System.Windows.Forms.Label labelResultScore;
        public System.Windows.Forms.Label labelResultScoreBefore;
        private System.Windows.Forms.DataGridView dataGridViewBloodPressures;
        private System.Windows.Forms.Button buttonRefreshPatientsDataViewGrid;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBoxNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpperPressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnderPressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aantekeningen;
    }
}