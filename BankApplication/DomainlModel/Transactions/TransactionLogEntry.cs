﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainlModel
{
    /// <summary>
    /// Class for representing transaction entry
    /// </summary>
    public class TransactionLogEntry
    {
        private TransactionType TransactionType { get; set; }
        private CurrencyAmount Amount { get; set; }
        public List<IAccount> Accounts { get; set; }
        public TransactionStatus Status { get; set; }
        public TransactionLogEntry(TransactionType type, CurrencyAmount amount,List<IAccount> acounts)
        {
            TransactionType = type;
            Amount = amount;
            Accounts = acounts;
        }
        public override string ToString()
        {
            if(Accounts.Count > 1)
                return String.Format("Type:{0},Amount:{1} {2},Status: {3}, From:{4}, To:{5}", TransactionType, Amount.Amount, Amount.Currency, Status,Accounts[0].Number,Accounts[1].Number);
            else
                return String.Format("Type:{0},Amount:{1} {2},Status: {3}, From:{4}", TransactionType, Amount.Amount, Amount.Currency, Status,Accounts[0].Number);
        }

    }
}
