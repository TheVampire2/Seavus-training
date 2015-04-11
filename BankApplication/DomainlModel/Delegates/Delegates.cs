using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainlModel.Delegates
{   
    /// <summary>
    /// Delegate for transactional logger
    /// </summary>
    /// <param name="acoount"></param>
    /// <param name="type"></param>
    /// <param name="amount"></param>
    public delegate void TransactionalLogger(IAccount acoount, TransactionType type, CurrencyAmount amount);
    /// <summary>
    /// Delegate for Balance change
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="eventArgs"></param>
    public delegate void BalanceChaged(Object sender, BalanceChangedEventArguments eventArgs);

    /// <summary>
    /// Delegate for account adding event
    /// </summary>
    /// <param name="account"></param>
    public delegate void AccountAddedEventHandler(IAccount account);
    /// <summary>
    /// Class for Balance changed event arguments
    /// </summary>
    ///
    public class BalanceChangedEventArguments : System.EventArgs
    {
        public IAccount Account { get; private set; }
        public CurrencyAmount Change { get;private set; }
        
        public BalanceChangedEventArguments(IAccount account,CurrencyAmount amount)
        {
            this.Account = account;
            this.Change = amount;
        }
    }
}
