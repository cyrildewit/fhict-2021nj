using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChallengeBankAccount
{
    public partial class BankAccountForm : Form
    {
        private BankAccount bankAccountLeft;
        private BankAccount bankAccountRight;
        private List<Transaction> transactions;

        public BankAccountForm()
        {
            InitializeComponent();

            bankAccountLeft = new BankAccount("Duck, Dagobert");
            bankAccountRight = new BankAccount("Gans, Gijs");
            transactions = new List<Transaction>() { };

            showViewData();
        }

        private void showViewData()
        {
            printBalanceBankAccountLeft();
            printBalanceBankAccountRight();
            listBoxTransactions.Items.Clear();
            foreach (Transaction transaction in transactions) {
                listBoxTransactions.Items.Add(transaction.ToString());
            }
        }

        private void buttonWithdrawLeftBankAccount_Click(object sender, EventArgs e)
        {
            int ammount;

            if (int.TryParse(textBoxWithdrawLeftBankAccount.Text, out ammount)) {
                bankAccountLeft.withdraw(ammount);
            }

            textBoxWithdrawLeftBankAccount.ResetText();

            printBalanceBankAccountLeft();
        }

        private void buttonDepositLeftBankAccount_Click(object sender, EventArgs e)
        {
            int ammount;

            if (int.TryParse(textBoxDepositLeftBankAccount.Text, out ammount))
            {
                bankAccountLeft.deposit(ammount);
            }

            textBoxDepositLeftBankAccount.ResetText();

            printBalanceBankAccountLeft();
        }

        private void buttonTransferLeftBankAccount_Click(object sender, EventArgs e)
        {
            int ammount;

            if (int.TryParse(textBoxTransferLeftBankAccount.Text, out ammount))
            {
                bankAccountLeft.transfer(bankAccountRight, ammount);
                this.transactions.Add(new Transaction(bankAccountLeft, bankAccountRight, ammount));
                listBoxTransactions.Items.Add("dd");
                showViewData();
            }

            textBoxTransferLeftBankAccount.ResetText();

            printBalanceBankAccountLeft();
            printBalanceBankAccountRight();
        }

        

        private void buttonWithdrawRightBankAccount_Click(object sender, EventArgs e)
        {
            int ammount;

            if (int.TryParse(textBoxWithdrawRightBankAccount.Text, out ammount))
            {
                bankAccountRight.withdraw(ammount);
            }

            textBoxWithdrawRightBankAccount.ResetText();

            printBalanceBankAccountRight();
        }

        private void buttonDepositRightBankAccount_Click(object sender, EventArgs e)
        {
            int ammount;

            if (int.TryParse(textBoxDepositRightBankAccount.Text, out ammount))
            {
                bankAccountRight.deposit(ammount);
            }

            textBoxDepositRightBankAccount.ResetText();

            printBalanceBankAccountRight();
        }

        private void buttonTransferRightBankAccount_Click(object sender, EventArgs e)
        {
            int ammount;

            if (int.TryParse(textBoxTransferRightBankAccount.Text, out ammount))
            {
                bankAccountRight.transfer(bankAccountLeft, ammount);
                this.transactions.Add(new Transaction(bankAccountRight, bankAccountLeft, ammount));
                showViewData();
            }

            textBoxTransferRightBankAccount.ResetText();

            printBalanceBankAccountLeft();
            printBalanceBankAccountRight();
        }

        private void printBalanceBankAccountLeft()
        {
            labelBalanceOutputLeftBankAccount.Text = bankAccountLeft.Balance.ToString("C");
        }

        private void printBalanceBankAccountRight()
        {
            labelBalanceOutputRightBankAccount.Text = bankAccountRight.Balance.ToString("C");
        }
    }
}
