using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EuroDollarConverterApp : Form
    {
        public EuroDollarConverterApp()
        {
            InitializeComponent();
        }

        private void ConvertDollarToEuro(object sender, EventArgs e)
        {
            decimal dollarAmount = 1;
            decimal exchangeRate = numericUpDownExchangeRate.Value;

            try
            {
                dollarAmount = Convert.ToDecimal(textBoxInputDollar.Text);
            }
            catch (Exception)
            {
                ShowGeneralErrorMessage();
            }

            textBoxInputEuro.Text = Convert.ToString(dollarAmount / exchangeRate);
        }

        private void ConvertEuroToDollar(object sender, EventArgs e)
        {
            decimal euroAmount = 1;
            decimal exchangeRate = numericUpDownExchangeRate.Value;

            try
            {
                euroAmount = Convert.ToDecimal(textBoxInputEuro.Text); 
            }
            catch (Exception)
            {
                ShowGeneralErrorMessage();
            }

            textBoxInputDollar.Text = Convert.ToString(euroAmount * exchangeRate);
        }


        private void ShowErrorMessage(String message = "")
        {
            MessageBox.Show(message, "Er is iets fout gegaan");
        }

        private void ShowGeneralErrorMessage()
        {
            ShowErrorMessage("Graag alleen getallen invoeren. Decimalen kunnen met een komma worden aangegeven (voorbeeld: 2,5 of 1,32).");
        }
    }
}
