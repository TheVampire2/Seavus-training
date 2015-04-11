﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainlModel
{
    /// <summary>
    /// Balance structure 
    /// </summary>
    public struct CurrencyAmount
    {
        /// <summary>
        /// Amount of balance
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// Currency         /// </summary>
        public string Currency { get; set; }

    }
    /// <summary>
    /// Enum for transaaction statuses
    /// </summary>
    public enum TransactionStatus : byte
    {
        None,
        Completed,
        CompletedWithWarning,
        Failed
    }
    public enum TransactionType : byte
    {
        None,
        Transfer,
        Debit,
        Credit
    }
    public struct InterestRate
    {
        public decimal Percent { get; set; }
        public UnitOfTime Unit { get; set; }

    }

    public struct TimePeriod
    {
        public int Period { get; set; }
        public UnitOfTime Unit { get; set; }
    }

    public enum UnitOfTime : byte
    {
        None,
        Day,
        Month,
        Year

    }
    [Flags]
    public enum CreateAccountType : byte
    {
        None = 0,
        TransactionAccount = 1,
        DepositAccoiunt = 2,
        LoanAccount = 4,
        All = TransactionAccount | DepositAccoiunt | LoanAccount
    }

}
