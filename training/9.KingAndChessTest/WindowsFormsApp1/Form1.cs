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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCalculateFor_Click(object sender, EventArgs e)
        {
            int boxNumber = Convert.ToInt32(numericUpDownInput.Value);

            int paycheck = CalculatePaycheckFor(boxNumber);

            labelOutput.Text = paycheck.ToString();
        }

        private void ButtonCalculateWhile_Click(object sender, EventArgs e)
        {
            int boxNumber = Convert.ToInt32(numericUpDownInput.Value);

            int paycheck = CalculatePaycheckWhile(boxNumber);

            labelOutput.Text = paycheck.ToString();
        }

        /*private int CalculatePaycheckFor(int boxNumber)
        {
            int result = 0;
            int last = 0;

            for (int i = 0; i < boxNumber; i++) {
                if (i == 0)
                {
                    result += last = 1;
                }
                else {
                    result += last = last * 2;
                }
            }

            return result;
        }*/

        private int CalculatePaycheckFor(int boxNumber)
        {
            int result = 0;

            for (int i = 0; i < boxNumber; i++)
            {
                result += Convert.ToInt32(Math.Pow(2, i));
            }

            return result;
        }

        /*private int CalculatePaycheckWhile(int boxNumber)
        {
            int result = 0;
            int index = 0;
            int last = 0;

            while (index < boxNumber) {
                if (index == 0)
                {
                    result += last = 1;
                }
                else
                {
                    result += last = last * 2;
                }

                index++;
            }

            return result;
        }*/

        private int CalculatePaycheckWhile(int boxNumber)
        {
            int result = 0;
            int index = 0;
            int last = 0;

            while (index < boxNumber)
            {
                result += Convert.ToInt32(Math.Pow(2, index));

                index++;
            }

            return result;
        }
    }
}
