namespace BloedPressureApp
{
    partial class ShowPatientScreen
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerBirthdate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDeletePatient = new System.Windows.Forms.Button();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.radioButtonGenderMale = new System.Windows.Forms.RadioButton();
            this.radioButtonGenderFemale = new System.Windows.Forms.RadioButton();
            this.buttonBloodPressureApp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAddPatientTitle
            // 
            this.labelAddPatientTitle.AutoSize = true;
            this.labelAddPatientTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddPatientTitle.Location = new System.Drawing.Point(36, 34);
            this.labelAddPatientTitle.Name = "labelAddPatientTitle";
            this.labelAddPatientTitle.Size = new System.Drawing.Size(173, 29);
            this.labelAddPatientTitle.TabIndex = 1;
            this.labelAddPatientTitle.Text = "Patiënt dossier";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(41, 101);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(222, 22);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(38, 81);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(73, 17);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "Voornaam";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(38, 135);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(84, 17);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Achternaam";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(41, 155);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(222, 22);
            this.textBoxLastName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Geboortedatum";
            // 
            // dateTimePickerBirthdate
            // 
            this.dateTimePickerBirthdate.Location = new System.Drawing.Point(41, 211);
            this.dateTimePickerBirthdate.Name = "dateTimePickerBirthdate";
            this.dateTimePickerBirthdate.Size = new System.Drawing.Size(222, 22);
            this.dateTimePickerBirthdate.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Opslaan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonOnClickSavePatient);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Opslaan en sluiten";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonOnClickSavePatientAndClose);
            // 
            // buttonDeletePatient
            // 
            this.buttonDeletePatient.BackColor = System.Drawing.Color.Red;
            this.buttonDeletePatient.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDeletePatient.Location = new System.Drawing.Point(33, 399);
            this.buttonDeletePatient.Name = "buttonDeletePatient";
            this.buttonDeletePatient.Size = new System.Drawing.Size(99, 23);
            this.buttonDeletePatient.TabIndex = 11;
            this.buttonDeletePatient.Text = "Verwijderen";
            this.buttonDeletePatient.UseVisualStyleBackColor = false;
            this.buttonDeletePatient.Click += new System.EventHandler(this.ButtonOnClickDeletePatient);
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.labelGender);
            this.groupBoxGender.Controls.Add(this.radioButtonGenderMale);
            this.groupBoxGender.Controls.Add(this.radioButtonGenderFemale);
            this.groupBoxGender.Location = new System.Drawing.Point(36, 239);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(227, 100);
            this.groupBoxGender.TabIndex = 16;
            this.groupBoxGender.TabStop = false;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(6, 18);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(64, 17);
            this.labelGender.TabIndex = 14;
            this.labelGender.Text = "Geslacht";
            // 
            // radioButtonGenderMale
            // 
            this.radioButtonGenderMale.AutoSize = true;
            this.radioButtonGenderMale.Location = new System.Drawing.Point(9, 47);
            this.radioButtonGenderMale.Name = "radioButtonGenderMale";
            this.radioButtonGenderMale.Size = new System.Drawing.Size(56, 21);
            this.radioButtonGenderMale.TabIndex = 12;
            this.radioButtonGenderMale.Text = "Man";
            this.radioButtonGenderMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonGenderFemale
            // 
            this.radioButtonGenderFemale.AutoSize = true;
            this.radioButtonGenderFemale.Location = new System.Drawing.Point(9, 74);
            this.radioButtonGenderFemale.Name = "radioButtonGenderFemale";
            this.radioButtonGenderFemale.Size = new System.Drawing.Size(68, 21);
            this.radioButtonGenderFemale.TabIndex = 13;
            this.radioButtonGenderFemale.Text = "Vrouw";
            this.radioButtonGenderFemale.UseVisualStyleBackColor = true;
            // 
            // buttonBloodPressureApp
            // 
            this.buttonBloodPressureApp.Location = new System.Drawing.Point(346, 91);
            this.buttonBloodPressureApp.Name = "buttonBloodPressureApp";
            this.buttonBloodPressureApp.Size = new System.Drawing.Size(133, 42);
            this.buttonBloodPressureApp.TabIndex = 17;
            this.buttonBloodPressureApp.Text = "Bloeddruk";
            this.buttonBloodPressureApp.UseVisualStyleBackColor = true;
            this.buttonBloodPressureApp.Click += new System.EventHandler(this.ButtonBloodPressureApp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Toepassingen";
            // 
            // ShowPatientScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBloodPressureApp);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.buttonDeletePatient);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerBirthdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelAddPatientTitle);
            this.Name = "ShowPatientScreen";
            this.Text = "Patiënt dossier";
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddPatientTitle;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDeletePatient;
        public System.Windows.Forms.TextBox textBoxFirstName;
        public System.Windows.Forms.TextBox textBoxLastName;
        public System.Windows.Forms.DateTimePicker dateTimePickerBirthdate;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.Label labelGender;
        public System.Windows.Forms.RadioButton radioButtonGenderMale;
        public System.Windows.Forms.RadioButton radioButtonGenderFemale;
        private System.Windows.Forms.Button buttonBloodPressureApp;
        private System.Windows.Forms.Label label2;
    }
}