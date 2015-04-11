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
        public InterestRate Interest { get; set; }
        public DateTime  StartDate{ get; set; }
        public DateTime EndDate { get; set; }

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
