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
        public IList<TransactionLogEntry> TransactionalLog { get; set; }
        public TransactionalLogger ExternalLogger { get; set; }

        private static ITransactionProccesor sTransactionProccesor;

        public IList<string> balanceChangeLog;

        #endregion
        /// <summary>
        /// Method for gettin the TransactionProccesor
        /// </summary>
        /// <returns>Singleto instance of Transaction Proccesor</returns>
        public static ITransactionProccesor GetTransactionProccesor()
        {
            return sTransactionProccesor;
        }
        #region Constructors
        static TransactionProccesor()
        {
            sTransactionProccesor = new TransactionProccesor();
        }
        private TransactionProccesor()
        {
            TransactionalLog = new List<TransactionLogEntry>();
            balanceChangeLog = new List<string>();
            ExternalLogger += Helpers.AcountHelper.LogTransaction;
            ExternalLogger += Helpers.AcountHelper.NotifyNationalBank;
        }
        #endregion
        #region TransactionLogMethods
        public TransactionLogEntry LastTransaction
        {
            get
            {
                if (TransactionalLog.Count == 0)
                    return null;
                return TransactionalLog.Last();
            }
        }

        public int TransactionCount
        {
            get
            {
                return TransactionalLog.Count;
            }
        }

        public TransactionLogEntry this[int number]
        {
            get
            {
                if (number > TransactionalLog.Count)
                    return null;
                return TransactionalLog[number];
            }
        }
        private void LogTransaction(TransactionLogEntry entry)
        {
            TransactionalLog.Add(entry);
        }
        private void CallExternalLogger(IAccount acount, TransactionType type, CurrencyAmount amount)
        {
            ExternalLogger(acount, type, amount);
        }
        #endregion
        #region Transaction Proccesors
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
        public TransactionStatus ProccessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, List<IAccount> acounts)
        {
            TransactionLogEntry entry;
            entry = new TransactionLogEntry(transactionType, amount, new List<IAccount>());
            
            
            if (transactionType == TransactionType.Transfer || transactionType == TransactionType.None)
                return TransactionStatus.Failed;

            bool flag = true;

            foreach (IAccount acount in acounts)
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
        private bool checkAvailabilityCredit(IAccount accountTo, CurrencyAmount amount)
        {
            if (accountTo.CreditAmount(amount) == TransactionStatus.Completed)
                return true;
            return false;
        }

        private bool checkAvailabilityDebit(IAccount accountFrom, CurrencyAmount amount)
        {
            if (accountFrom.DebitAmount(amount) == TransactionStatus.Completed)
                return true;
            return false;
        }
        public string balanceChangedCheck()
        {
            if(Helpers.AcountHelper.balanceChangedLog.Count > 0)
             return Helpers.AcountHelper.balanceChangedLog.Last();
            return null;
        }
        #endregion
        #endregion







       
    }
}
