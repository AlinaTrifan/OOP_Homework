using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homeworks
{
    public class BankAccount
    {
        private decimal balance;
        private List<Transactions> allTransactions = new List<Transactions>();
        private static int iBan = 1234567890;
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Amount of balance need to be positive", "balance");
                }
                this.balance = value;
            }
        }

        public BankAccount(string owner, decimal initialBalance)
        {
            this.Owner = owner;
            this.balance = initialBalance;
            this.Number = iBan.ToString();
            iBan++;
        }

        public void Withdrawals(decimal amount, DateTime date)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount of withdrawals need to be positive", "amount");
            if ((Balance - amount) < 0)
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            var withdrawal = new Transactions(-amount, date);
            allTransactions.Add(withdrawal);
        }

        public void MakeDeposit(decimal amount, DateTime date)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount of deposit must be positive", "amount");
            }
            var deposit = new Transactions(amount, date);
            allTransactions.Add(deposit);
        }
    }
}
