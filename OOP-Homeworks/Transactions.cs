using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homeworks
{
    public class Transactions
    {
        public decimal Amount {get;}
        public DateTime Date { get; }

        public Transactions (decimal amount, DateTime date)
        {
            this.Amount = amount;
            this.Date = date;
        }
    }
}
