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

        public BankAccount(string name)
        {
            accountNumber = nextFreeAccountNumber;
            this.name = name;
            balance = 0;
            

            ++nextFreeAccountNumber;
        }

        public BankAccount(string name, int balance)
        {
            accountNumber = nextFreeAccountNumber;
            this.name = name;
            this.balance = balance;

            ++nextFreeAccountNumber;
        }

        public void withdraw(int ammount)
        {
            if (ammount < 0) {
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

        public void transfer(BankAccount receiver, int ammount)
        {
            this.withdraw(ammount);
            receiver.deposit(ammount);
        }
    }
}
