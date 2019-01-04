using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homeworks
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        private static int accountNumber = 1234567890;
        private List<Transactions> allTransactions = new List<Transactions>();
        private int count = 0;

        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
            set
            {
                this.Balance = Balance;
            }
        }


        public BankAccount (string name, int initialBalance)
        {
            MakeDeposit(initialBalance, DateTime.Now);
            this.Owner = name;
            this.Number = accountNumber.ToString();
            accountNumber++;
        }
        

        public void MakeDeposit(decimal amount, DateTime date)
        {
            if (count == 1)
            {
                throw new NotSupportedException("This account has been closed");
            }
            else
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Amount of deposit must be positive", "amount");
                }
                var deposit = new Transactions(amount, date);
                allTransactions.Add(deposit);
            }

        }

        public void MakeWithdrawal(decimal amount, DateTime date)
        {
            if (count == 1)
            {
                throw new NotSupportedException("This account has been closed");
            }
            else
            {
                if (amount <= 0)
                    throw new ArgumentException("Amount of withdrawals needs to be positive", "amount");
                if ((Balance - amount) < 0)
                    throw new InvalidOperationException("Not sufficient funds for this withdrawal");
                var withdrawal = new Transactions(-amount, date);
                allTransactions.Add(withdrawal);
            }

        }

        public void CloseAccount()
        {
            if (count == 1)
            {
                throw new NotSupportedException("This account has been closed");
            }
            else
            {
                if (Balance > 0)
                {
                    Console.WriteLine($"The sum {Balance} was extracted in order to close the account");
                    MakeWithdrawal(Balance, DateTime.Now);

                }
                Console.WriteLine($"The bank account {this.Number} was closed");
                count++;
            }
        }
    }
}
