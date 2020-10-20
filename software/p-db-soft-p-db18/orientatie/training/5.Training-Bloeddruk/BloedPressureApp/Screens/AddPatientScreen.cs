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
    public partial class AddPatientScreen : Form
    {
        public AddPatientScreen()
        {
            InitializeComponent();
        }

        private bool StorePatient()
        {
            PatientGender gender = (PatientGender)(-1);

            if (radioButtonGenderMale.Checked) {
                gender = PatientGender.Male;
            } else if (radioButtonGenderFemale.Checked)
            {
                gender = PatientGender.Female;
            }

            PatientModel patient = new PatientModel
            {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Birthdate = dateTimePickerBirthdate.Value.ToShortDateString(),
                Gender = gender
            };

            PatientValidator validator = new PatientValidator();

            ValidationResult results = validator.Validate(patient);

            if (results.IsValid == false) {
                MessageBox.Show(results.Errors[0].ToString());

                return false;
            }

            SqliteDataAccess.SavePatient(patient);

            ResetForm();

            return true;
        }

        private void ResetForm()
        { 
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            dateTimePickerBirthdate.Value = DateTime.Now;
        }

        private void ButtonOnClickSavePatient(object sender, EventArgs e)
        {
            StorePatient();
        }

        private void ButtonOnClickSavePatientAndClose(object sender, EventArgs e)
        {
            if (StorePatient()) {
                Close();
            }
        }

        private void ButtonOnClickResetForm(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
