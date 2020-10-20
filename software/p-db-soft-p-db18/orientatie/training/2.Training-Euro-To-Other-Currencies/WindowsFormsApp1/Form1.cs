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
        protected Currency[] currencies;

        protected int selectedCurrency = 0;
        public EuroDollarConverterApp()
        {
            InitializeComponent();

            this.currencies = new Currency[]{
                new Currency("Amerikaanse Dollar", "$", 1.18m),
                new Currency("Britse Pond", "\u00A3", 0.89m),
                new Currency("Chinese Yuan", "\u00a5", 8.08m),
                new Currency("Deense Kroon", "DKK", 7.74m),
                new Currency("Russische roebel", "\u20bd", 88.99m)
            };

            foreach (Currency currency in currencies) {
                comboBoxCurrencies.Items.Add(currency.GetName());
            }

            comboBoxCurrencies.SelectedIndex = 0;
        }

        private void ConvertCustomCurrencyToEuro(object sender, EventArgs e)
        {
            decimal dollarAmount = 1;
            decimal exchangeRate = GetCurrentEuroCurrencyExchangeRate();

            try
            {
                dollarAmount = Convert.ToDecimal(textBoxInputCustomCurrency.Text);
            }
            catch (Exception)
            {
                ShowGeneralErrorMessage();
            }

            textBoxInputEuro.Text = Convert.ToString(dollarAmount / exchangeRate);
        }

        private void ConvertEuroToCustomCurrency(object sender, EventArgs e)
        {
            decimal euroAmount = 1;
            decimal exchangeRate = GetCurrentEuroCurrencyExchangeRate();

            try
            {
                euroAmount = Convert.ToDecimal(textBoxInputEuro.Text);
            }
            catch (Exception)
            {
                ShowGeneralErrorMessage();
            }

            textBoxInputCustomCurrency.Text = Convert.ToString(euroAmount * exchangeRate);
        }


        private void ShowErrorMessage(String message = "")
        {
            MessageBox.Show(message, "Er is iets fout gegaan");
        }

        private void ShowGeneralErrorMessage()
        {
            ShowErrorMessage("Graag alleen getallen invoeren. Decimalen kunnen met een komma worden aangegeven (voorbeeld: 2,5 of 1,32).");
        }

        private void comboBoxCurrencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCurrency = comboBoxCurrencies.SelectedIndex;
            labelCustomCurrencySymbol.Text = currencies[selectedCurrency].GetSymbol();
        }

        private decimal GetCurrentEuroCurrencyExchangeRate()
        {
            return currencies[selectedCurrency].GetEuroExchangeRate();
        }
    }
}
