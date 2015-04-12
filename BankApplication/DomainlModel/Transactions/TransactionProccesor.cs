using DomainlModel.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainlModel
{
    public class TransactionProccesor : ITransactionProccesor
    {

       
        #region Properties
        /// <summary>
        /// List of all Log entries
        /// </summary>
        public IList<TransactionLogEntry> TransactionalLog { get; set; }
        /// <summary>
        /// Specific event logger
        /// </summary>
        public TransactionalLogger ExternalLogger { get; set; }
        /// <summary>
        /// Singleton implementation - field
        /// </summary>
        private static ITransactionProccesor sTransactionProccesor;
        /// <summary>
        /// list of all balance changings
        /// </summary>
        public IList<string> balanceChangeLog;

        /// <summary>
        /// Indicates whereas the fee is charged or not
        /// </summary>
        public bool feeCharged { get; set; }

        #endregion
        /// <summary>
        /// Method for gettin the TransactionProccesor
        /// </summary>
        /// <returns>Singleton instance of Transaction Proccesor</returns>
        
        public static ITransactionProccesor GetTransactionProccesor()
        {
            return sTransactionProccesor;
        }

        #region Constructors

        static TransactionProccesor()
        {
            // init of the singleton instance
            sTransactionProccesor = new TransactionProccesor();
        }
        private TransactionProccesor()
        {
            ///init of members and events
            TransactionalLog = new List<TransactionLogEntry>();
            balanceChangeLog = new List<string>();
            ExternalLogger += Helpers.AcountHelper.LogTransaction;
            ExternalLogger += Helpers.AcountHelper.NotifyNationalBank;
        }
        #endregion

        #region TransactionLogMethods
        /// <summary>
        /// Property that returns the last trasnaction made
        /// </summary>
        public TransactionLogEntry LastTransaction
        {
            get
            {
                if (TransactionalLog.Count == 0)
                    return null;
                return TransactionalLog.Last();
            }
        }
        /// <summary>
        /// Property that returns the count of transactions
        /// </summary>
        public int TransactionCount
        {
            get
            {
                return TransactionalLog.Count;
            }
        }
        /// <summary>
        /// Indexer for the list of Log entries
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public TransactionLogEntry this[int number]
        {
            get
            {
                if (number > TransactionalLog.Count)
                    return null;
                return TransactionalLog[number];
            }
        }
        /// <summary>
        /// Logs specific transaction
        /// </summary>
        /// <param name="entry"></param>
        private void LogTransaction(TransactionLogEntry entry)
        {
            TransactionalLog.Add(entry);
        }
        /// <summary>
        /// Logging specific transaction via External logger
        /// </summary>
        /// <param name="acount"></param>
        /// <param name="type"></param>
        /// <param name="amount"></param>
        private void CallExternalLogger(IAccount acount, TransactionType type, CurrencyAmount amount)
        {
            ExternalLogger(acount, type, amount);
        }
        #endregion

        #region Transaction Proccesors
        /// <summary>
        /// Transaction proccesing method
        /// </summary>
        /// <param name="accountFrom"> from account</param>
        /// <param name="accountTo"> to account ( transfer transaction )</param>
        /// <param name="transactionType"> type </param>
        /// <param name="amount"> Currency amount type </param>
        /// <returns></returns>
        public TransactionStatus transactionProcces(IAccount accountFrom, IAccount accountTo, TransactionType transactionType, CurrencyAmount amount)
        {
            TransactionLogEntry entry;
            List<IAccount> list = new List<IAccount>();
            list.Add(accountFrom);
            
            entry = new TransactionLogEntry(transactionType, amount, list);
            if (transactionType == TransactionType.Transfer)
            {
                list.Add(accountTo);
                if (checkAvailabilityDebit(accountFrom, amount) && checkAvailabilityCredit(accountTo, amount))
                {
                    entry.Status = TransactionStatus.Completed;
                    LogTransaction(entry);
                    CallExternalLogger(accountFrom, transactionType, amount);
                    return TransactionStatus.Completed;
                }
                entry.Status = TransactionStatus.Failed;
                LogTransaction(entry);
                return TransactionStatus.Failed;
            }
            else if(transactionType == TransactionType.Debit)
            {
                entry.Status = accountFrom.DebitAmount(amount);
                LogTransaction(entry);
                CallExternalLogger(accountFrom, transactionType, amount);
                return entry.Status;   
            }
            else if(transactionType == TransactionType.Credit)
            {
                entry.Status = accountFrom.CreditAmount(amount);
                LogTransaction(entry);
                CallExternalLogger(accountFrom, transactionType, amount);
                return entry.Status;
            }

            return TransactionStatus.None;
        }
        /// <summary>
        /// Method for procesing multiple transactions
        /// </summary>
        /// <param name="transactionType">type </param>
        /// <param name="amount">Curency amount</param>
        /// <param name="acounts"> Account list</param>
        /// <returns></returns>
        public TransactionStatus ProccessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IList<IAccount> accounts)
        {
            TransactionLogEntry entry;
            entry = new TransactionLogEntry(transactionType, amount, new List<IAccount>());
            
            
            if (transactionType == TransactionType.Transfer || transactionType == TransactionType.None)
                return TransactionStatus.Failed;

            bool flag = true;

            foreach (IAccount acount in accounts)
            {
                if (acount == null)
                    continue;

                entry.Status = transactionProcces(acount, acount, transactionType, amount);
                entry.Accounts = new List<IAccount>();
                entry.Accounts.Add(acount);

                if (entry.Status == TransactionStatus.Failed)
                    flag = false;
                LogTransaction(entry);
                CallExternalLogger(acount, transactionType, amount);

            }
            if (flag)
                return TransactionStatus.Completed;
            else
                return TransactionStatus.CompletedWithWarning;
        }
        #region Checks
        /// <summary>
        /// Checks if the transaction is posibles
        /// </summary>
        /// <param name="accountTo"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        private bool checkAvailabilityCredit(IAccount accountTo, CurrencyAmount amount)
        {
            if (accountTo.CreditAmount(amount) == TransactionStatus.Completed)
                return true;
            return false;
        }
        /// <summary>
        /// Checks if the transaction is possible
        /// </summary>
        /// <param name="accountFrom"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        private bool checkAvailabilityDebit(IAccount accountFrom, CurrencyAmount amount)
        {
            if (accountFrom.DebitAmount(amount) == TransactionStatus.Completed)
                return true;
            return false;
        }
        /// <summary>
        /// Returns last balance change
        /// </summary>
        /// <returns></returns>
        public string balanceChangedCheck()
        {
            if(Helpers.AcountHelper.s_balanceChangedLog.Count > 0)
             return Helpers.AcountHelper.s_balanceChangedLog.Last();
            return null;
        }
        #endregion
        #endregion







       
    }
}
