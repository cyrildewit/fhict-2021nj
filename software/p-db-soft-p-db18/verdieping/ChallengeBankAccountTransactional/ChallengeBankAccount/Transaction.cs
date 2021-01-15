using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeBankAccount
{
    class Transaction
    {
        private BankAccount sender;
        private BankAccount receiver;
        private int amount;
        private DateTime createdAt;

        public Transaction(BankAccount sender, BankAccount receiver, int amount) {
            this.sender = sender;
            this.receiver = receiver;
            this.amount = amount;
            createdAt = new DateTime();
        }
        
        public override string ToString()
        {
            return sender.Name + " heeft " + amount.ToString("C") + " overgeboekt naar " + receiver.Name + " op " + createdAt.ToString();
        }
    }
}
