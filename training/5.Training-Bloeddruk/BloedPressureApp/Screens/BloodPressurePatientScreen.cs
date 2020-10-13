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
    public partial class BloodPressurePatient : Form
    {
        protected PatientModel patient;
        protected BloodPressureModel currentBloodPressure;

        List<BloodPressureModel> bloodPressures = new List<BloodPressureModel>();

        public BloodPressurePatient(PatientModel patient)
        {
            InitializeComponent();

            this.patient = patient;

            LoadBloedPressureList();
        }

        private void LoadBloedPressureList()
        {
            bloodPressures = SqliteDataAccess.LoadBloodPressureForPatient(patient);

            WireUpBloodPressuresList();
        }

        private void WireUpBloodPressuresList()
        {
            dataGridViewBloodPressures.AutoGenerateColumns = false;
            dataGridViewBloodPressures.DataSource = bloodPressures;
        }

        private void ButtonCalculateMAP_Click(object sender, EventArgs e)
        {
            BloodPressureModel bloodPressure = new BloodPressureModel
            {
                UpperPressure = Convert.ToInt32(numericUpDownUpperPressure.Value),
                UnderPressure = Convert.ToInt32(numericUpDownUnderPressure.Value),
            };
            bloodPressure.Result = CalculateBloodPressureResult(bloodPressure);
            bloodPressure.Notes = richTextBoxNotes.Text;
            currentBloodPressure = bloodPressure;

            labelMAN.Text = bloodPressure.MeanArterialPressure.ToString();
            labelResultScore.Text = bloodPressure.Result;
        }

        private string CalculateBloodPressureResult(BloodPressureModel bloodPressure)
        {
            int upperPressure = bloodPressure.UpperPressure;
            int underPressure = bloodPressure.UnderPressure;

            if (upperPressure >= 70 && upperPressure < 90)
            {
                if (underPressure >= 40 && underPressure < 60)
                {
                    return "Lage bloeddruk";
                }
                else if (underPressure >= 60 && underPressure < 80)
                {
                    return "Ideale bloeddruk";
                }
                else if (underPressure >= 80 && underPressure < 90)
                {
                    return "Pre hoge bloeddruk";
                }
                else if (underPressure >= 90 && underPressure < 100)
                {
                    return "Hoge bloeddruk";
                }
            }
            else if (upperPressure >= 90 && upperPressure < 120)
            {
                if (underPressure >= 40 && underPressure < 80)
                {
                    return "Ideale bloeddruk";
                }
                else if (underPressure >= 80 && underPressure < 90)
                {
                    return "Pre hoge bloeddruk";
                }
                else if (underPressure >= 90 && underPressure < 100)
                {
                    return "Hoge bloeddruk";
                }
            }
            else if (upperPressure >= 120 && upperPressure < 140)
            {
                if (underPressure >= 40 && underPressure < 90)
                {
                    return "Pre hoge bloeddruk";
                }
                else if (underPressure >= 90 && underPressure < 100)
                {
                    return "Hoge bloeddruk";
                }
            }
            else if (upperPressure >= 140 && upperPressure < 190)
            {
                return "Hoge bloeddruk";
            }

            return "";
        }

        private void ButtonAddBloodPressureToRecord_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.SaveBloodPressure(patient, currentBloodPressure);
            /*MessageBox.Show(currentBloodPressure.MeanArterialPressure.ToString());*/
        }

        private void ButtonRefreshPatientsDataViewGrid_Click(object sender, EventArgs e)
        {
            LoadBloedPressureList();
        }
    }
}
