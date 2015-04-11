using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainlModel
{
    [AccountMetadata("Loan Account", "Limit parametar is set manually")]
    public class LoanAccount : DepositAccount,ILoanAccount
    {
        private int loanAccountId;
        private string p1;
        private string p2;
        private TimePeriod tP;
        private InterestRate iR;
        private DateTime dateTime1;
        private DateTime dateTime2;
        private ITransactionAccount ta;

        public LoanAccount(int ID, string number, string currency, TimePeriod Period, InterestRate Interest, DateTime StartDate, DateTime EndDate, ITransactionAccount TransactionAccount) 
            : base(ID,number,currency,Period,Interest,StartDate,EndDate,TransactionAccount)
        {
            
        }

        

        /// <summary>
        /// Debit amount of the account
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>Transaction status</returns>
        override public TransactionStatus DebitAmount(CurrencyAmount amount)
        {
            return base.CreditAmount(amount);
        }
        /// <summary>
        /// Credit amount 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>Transaction status</returns>
        override public TransactionStatus CreditAmount(CurrencyAmount amount)
        {
            return base.DebitAmount(amount);
        }
       
        
    }
}
