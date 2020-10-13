using BloedPressureApp.Enums;
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
    public partial class HomeScreen : Form
    {
        List<PatientModel> patients = new List<PatientModel>();

        public HomeScreen()
        {
            InitializeComponent();

            LoadPatientsList();
        }

        private void LoadPatientsList()
        {
            patients = SqliteDataAccess.LoadPatients();

            WireUpPatientsList();
        }

        private void WireUpPatientsList()
        {
            dataGridViewPatients.AutoGenerateColumns = false;
            dataGridViewPatients.DataSource = patients;
        }

        private void ButtonRefreshPatientsDataViewGrid_Click(object sender, EventArgs e)
        {
            LoadPatientsList();
        }

        private void ButtonAddPatient_Click(object sender, EventArgs e)
        {
            AddPatientScreen addPatientScreen = new AddPatientScreen();
            addPatientScreen.ShowDialog();
        }

        private void DataGridViewPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                PatientModel patient = new PatientModel();
                patient.Id = Convert.ToInt32(dataGridViewPatients.CurrentRow.Cells[0].Value.ToString());
                patient.FirstName = dataGridViewPatients.CurrentRow.Cells[1].Value.ToString();
                patient.LastName = dataGridViewPatients.CurrentRow.Cells[2].Value.ToString();
                patient.Birthdate = dataGridViewPatients.CurrentRow.Cells[3].Value.ToString();

                ShowPatientScreen showPatientScreen = new ShowPatientScreen();
                showPatientScreen.patientId = Convert.ToInt32(dataGridViewPatients.CurrentRow.Cells[0].Value.ToString());
                showPatientScreen.textBoxFirstName.Text = dataGridViewPatients.CurrentRow.Cells[1].Value.ToString();
                showPatientScreen.textBoxLastName.Text = dataGridViewPatients.CurrentRow.Cells[2].Value.ToString();
                showPatientScreen.dateTimePickerBirthdate.Value = Convert.ToDateTime(dataGridViewPatients.CurrentRow.Cells[3].Value.ToString());

                if (dataGridViewPatients.CurrentRow.Cells[4].Value.ToString() == PatientGender.Male.ToString()) {
                    showPatientScreen.radioButtonGenderMale.Checked = true;
                    patient.Gender = PatientGender.Male;
                } else if (dataGridViewPatients.CurrentRow.Cells[4].Value.ToString() == PatientGender.Female.ToString()) { 
                    showPatientScreen.radioButtonGenderFemale.Checked = true;
                    patient.Gender = PatientGender.Female;
                }

                showPatientScreen.patient = patient;

                showPatientScreen.ShowDialog();
            }
        }
    }
}
