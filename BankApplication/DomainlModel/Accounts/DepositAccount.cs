using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainlModel
{
    /// <summary>
    /// Definition for deposit account 
    /// </summary>
    [AccountMetadata("Deposit Account","No limitations")]
    public class DepositAccount : Account,IDepositAccount
    {
        /// <summary>
        /// Period of the account 
        /// </summary>
        public TimePeriod Period { get; set; }
        /// <summary>
        /// Interest rate from this account
        /// </summary>
        public InterestRate Interest { get; set; }
        /// <summary>
        /// Starting date of account 
        /// </summary>
        public DateTime  StartDate{ get; set; }
        /// <summary>
        /// Ending date of account
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// Corresponding transaction account
        /// </summary>
        public ITransactionAccount TransactionAccount { get; set; }

        public DepositAccount(int ID, string number,string currency,TimePeriod Period,InterestRate Interest, DateTime StartDate, DateTime EndDate, ITransactionAccount TransactionAccount) : base(ID,number,currency)
        {
            this.Period = Period;
            this.Interest = Interest;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.TransactionAccount = TransactionAccount;
        }
     

    }

    
}
