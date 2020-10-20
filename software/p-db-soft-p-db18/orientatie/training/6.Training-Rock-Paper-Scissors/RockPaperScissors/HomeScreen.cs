using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class HomeScreen : Form
    {
        private int wins = 0;
        private int draws = 0;
        private int loses = 0;
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer.Image = Properties.Resources.paper;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = groupBoxPlayer.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            string playerOption;
            string enemyOption;

            if (selectedRadioButton.Name == "radioButtonPaper")
            {
                playerOption = "paper";
                pictureBoxPlayer.Image = Properties.Resources.paper;
            }
            else if (selectedRadioButton.Name == "radioButtonRock")
            {
                playerOption = "rock";
                pictureBoxPlayer.Image = Properties.Resources.rock;
            }
            else {
                playerOption = "scissors";
                pictureBoxPlayer.Image = Properties.Resources.scissor;
            }

            Random rnd = new Random();
            int num = rnd.Next(3);

            if (num == 0)
            {
                enemyOption = "paper";
                radioButtonEnemyPaper.Checked = true;
                pictureBoxEnemy.Image = Properties.Resources.paper;
            }
            else if (num == 1)
            {
                enemyOption = "rock";
                radioButtonEnemyRock.Checked = true;
                pictureBoxEnemy.Image = Properties.Resources.rock;
            }
            else
            {
                enemyOption = "scissors";
                radioButtonEnemyScissors.Checked = true;
                pictureBoxEnemy.Image = Properties.Resources.scissor;
            }

            if (playerOption == enemyOption)
            {
                listBoxResults.Items.Add(playerOption + " - " + enemyOption + " - draw");
                draws++;
            }
            else {
                if (playerOption == "paper")
                {
                    if (enemyOption == "rock")
                    {
                        listBoxResults.Items.Add(playerOption + " - " + enemyOption + " - win");
                        wins++;
                    }
                    else {
                        listBoxResults.Items.Add(playerOption + " - " + enemyOption + " - lose");
                        loses++;
                    }
                }
                else if (playerOption == "rock")
                {
                    if (enemyOption == "scissors")
                    {
                        listBoxResults.Items.Add(playerOption + " - " + enemyOption + " - win");
                        wins++;
                    }
                    else
                    {
                        listBoxResults.Items.Add(playerOption + " - " + enemyOption + " - lose");
                        loses++;
                    }
                }
                else
                {
                    if (enemyOption == "paper")
                    {
                        listBoxResults.Items.Add(playerOption + " - " + enemyOption + " - win");
                        wins++;
                    }
                    else
                    {
                        listBoxResults.Items.Add(playerOption + " - " + enemyOption + " - lose");
                        loses++;
                    }
                }
            }

            labelWinsCount.Text = wins.ToString();
            labelDrawsCount.Text = draws.ToString();
            labelLosesCount.Text = loses.ToString();
        }
    }
}
