using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeBankAccount
{
    class BankAccount
    {
        private int accountNumber;
        private string name;
        private int balance; // in cents
        private AccountType accountType;
        private static int nextFreeAccountNumber = 2001;

        public int AccountNumber
        {
            get { return accountNumber; }
        }

        public string Name
        {
            get { return name; }
        }

        public int Balance
        {
            get { return balance; }
        }

        public AccountType AccountType
        {
            get { return accountType; }
        }

        public BankAccount(string name)
        {
            accountNumber = nextFreeAccountNumber;
            this.name = name;
            balance = 0;

            ++nextFreeAccountNumber;
        }

        public BankAccount(string name, int balance, AccountType accountType)
        {
            accountNumber = nextFreeAccountNumber;
            this.name = name;
            this.balance = balance;
            this.accountType = accountType;

            ++nextFreeAccountNumber;
        }

        public void withdraw(int ammount)
        {
            if (ammount < 0) {
                return;
            }

            if (accountType == AccountType.Debit && (balance - ammount) < 0) {
                return;
            }

            this.balance -= ammount;
        }

        public void deposit(int ammount)
        {
            if (ammount < 0)
            {
                return;
            }

            this.balance += ammount;
        }

        public void sendTransfer(BankAccount receiver, int ammount)
        {
            if (ammount < 0)
            {
                return;
            }

            if (accountType == AccountType.Debit && (balance - ammount) < 0)
            {
                return;
            }

            this.balance -= ammount;

            receiver.receiveTransfer(this, ammount);
        }

        public void receiveTransfer(BankAccount sender, int ammount)
        {
            if (ammount < 0)
            {
                return;
            }

            balance += ammount;
        }
    }
}
