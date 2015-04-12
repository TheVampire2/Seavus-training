using DomainlModel.Delegates;
using DomainlModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainlModel
{
    [AccountMetadata("Simple transaction account", "No limitations")]
    public class TransactionAccount : Account, ITransactionAccount
    {
        /// <summary>
        /// Limit of the account
        /// </summary>
        public CurrencyAmount Limit { get; set; }

        /// <summary>
        /// Event fired when balance changed
        /// </summary>
        public event BalanceChaged OnBalanceChanged;
        public TransactionAccount(int ID, string number, string currency, CurrencyAmount limit)
            : base(ID, number, currency)
        {
            this.Limit = limit;
            OnBalanceChanged += AcountHelper.LogBalanceChanged;
        }

        public override TransactionStatus DebitAmount(CurrencyAmount amount)
        {
            if (amount.Currency == Balance.Currency)
            {
                if ((Balance.Amount - amount.Amount) <= Limit.Amount)
                {
                    CurrencyAmount amountDiff = new CurrencyAmount();
                    amountDiff.Amount = Limit.Amount - (Balance.Amount - amount.Amount);
                    throw new LimitOverreachedException(amountDiff);
                }
                CurrencyAmount ca = new CurrencyAmount();
                ca.Amount = Balance.Amount - amount.Amount;
                ca.Currency = Currency;
                Balance = ca;
                OnBalanceChanged(this, new BalanceChangedEventArguments(this, amount));
                return TransactionStatus.Completed;
            }
            else
                throw new CurrencyMissmatchException();

        }

    }
}
