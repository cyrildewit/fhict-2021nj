using BloedPressureApp.Enums;
using BloedPressureApp.Validators;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloedPressureApp
{
    public partial class ShowPatientScreen : Form
    {
        public int patientId;
        public PatientModel patient;

        public ShowPatientScreen()
        {
            InitializeComponent();
        }

        private bool UpdatePatient()
        {
            PatientGender gender = (PatientGender)(-1);

            if (radioButtonGenderMale.Checked)
            {
                gender = PatientGender.Male;
            }
            else if (radioButtonGenderFemale.Checked)
            {
                gender = PatientGender.Female;
            }

            PatientModel localPatient = new PatientModel
            {
                Id = patientId,
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Birthdate = dateTimePickerBirthdate.Value.ToShortDateString(),
                Gender = gender
            };

            PatientValidator validator = new PatientValidator();

            ValidationResult results = validator.Validate(localPatient);

            if (results.IsValid == false)
            {
                MessageBox.Show(results.Errors[0].ToString());

                return false;
            }

            patient = localPatient;

            SqliteDataAccess.UpdatePatient(localPatient);

            return true;
        }

        private void ButtonOnClickSavePatient(object sender, EventArgs e)
        {
            UpdatePatient();
        }

        private void ButtonOnClickSavePatientAndClose(object sender, EventArgs e)
        {
            if (UpdatePatient()) {
                Close();
            }
        }

        private void ButtonOnClickDeletePatient(object sender, EventArgs e)
        {
            DialogResult dialogConfirmPatientDeleteResult = MessageBox.Show("Weet u zeker dat u deze patiënt uit het register wilt verwijderen? Deze actie is permanent en kan niet ongedaan worden gemaakt.", "Patiënt verwijderen", MessageBoxButtons.YesNo);
            
            if (dialogConfirmPatientDeleteResult == DialogResult.Yes) {
                PatientModel patient = new PatientModel
                {
                    Id = patientId,
                };

                SqliteDataAccess.DeletePatient(patient);
                Close();
            }
        }

        private void ButtonBloodPressureApp_Click(object sender, EventArgs e)
        {
            BloodPressurePatient bloedPressurePatient = new BloodPressurePatient(patient);
            bloedPressurePatient.ShowDialog();
        }
    }
}
