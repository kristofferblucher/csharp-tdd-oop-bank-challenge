﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Transaction
    {
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }
        public TransactionType Type { get; set; }

        public Transaction(decimal amount, TransactionType type)
        {
            Date = DateTime.Now;
            Amount = amount;
            Type = type;
            


        }

    }
}
