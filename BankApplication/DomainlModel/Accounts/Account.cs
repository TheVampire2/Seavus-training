using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainlModel.Delegates;
using DomainlModel.Helpers;

namespace DomainlModel
{/// <summary>
/// Account clas
/// </summary>
/// 
    
    public class Account : IAccount
    {
        #region Properties 
        /// <summary>
        /// ID of the account
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// Number of the account
        /// </summary>
        [FormatRestriction("XXXX-XXXX-XXXX-XXXX-XXXX",16)]
        public string  Number { get; private set; }
        /// <summary>
        /// Curency of acount
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Account amount
        /// </summary
        public CurrencyAmount Balance { get; protected set; }

        public event BalanceChaged OnBalanceChanged;

        #endregion
        #region Methods
        /// <summary>
        /// Basic constructor of the element
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Number"></param>
        /// <param name="Currency"></param>
        public Account(int ID, string Number, string Currency)
        {
            this.ID = ID;
            this.Number = Number;
            this.Currency = Currency;
            CurrencyAmount bal = new CurrencyAmount();
            bal.Amount = 300000;
            bal.Currency = Currency;
            this.Balance = bal;
            OnBalanceChanged += AcountHelper.LogBalanceChanged; 
        }

        

        /// <summary>
        /// Debit amount of the account
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>Transaction status</returns>
        public  virtual TransactionStatus DebitAmount(CurrencyAmount amount)
        {
            return DebitTransactionCheck(amount);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>Transaction status</returns>
        public virtual TransactionStatus CreditAmount(CurrencyAmount amount)
        {
            return CredtTransactionCheck(amount);
           
        }
        /// <summary>
        /// Checks if the transaction is valid
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        private TransactionStatus CredtTransactionCheck(CurrencyAmount amount)
        {
            if (amount.Currency == Balance.Currency)
            {
                CurrencyAmount ca = new CurrencyAmount();
                ca.Amount = Balance.Amount + amount.Amount;
                ca.Currency = Currency;
                Balance = ca;
                OnBalanceChanged(this, new BalanceChangedEventArguments(this, amount));
                return TransactionStatus.Completed;
            }
            else
                throw new CurrencyMissmatchException();
        }
        /// <summary>
        /// Checks if the transaction is valid
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        private TransactionStatus DebitTransactionCheck(CurrencyAmount amount)
        {
            if (amount.Currency == Balance.Currency)
            {

                if (Balance.Amount > amount.Amount)
                {
                    CurrencyAmount ca = new CurrencyAmount();
                    ca.Amount = Balance.Amount - amount.Amount;
                    ca.Currency = Currency;
                    Balance = ca;
                    OnBalanceChanged(this, new BalanceChangedEventArguments(this, amount));
                    return TransactionStatus.Completed;
                }
                else
                {
                    
                    return TransactionStatus.Failed;
                }

            }
            else
            {
                throw new CurrencyMissmatchException();
            }
        }
        public override string ToString()
        {
            return Number;
        }
        #endregion

    }
   
}
