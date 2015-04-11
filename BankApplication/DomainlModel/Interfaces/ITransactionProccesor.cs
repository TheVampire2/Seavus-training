using DomainlModel.Delegates;
using System.Collections.Generic;

namespace DomainlModel
{
    public interface ITransactionProccesor
    {
        IList<TransactionLogEntry> TransactionalLog { get; set; }
        TransactionStatus transactionProcces(IAccount accountFrom,IAccount accountTo, TransactionType transactionType, CurrencyAmount amount);
        TransactionStatus ProccessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, List<IAccount> acounts);
        TransactionLogEntry LastTransaction { get; }
        int TransactionCount { get; }
        TransactionLogEntry this[int number] { get;  }
        TransactionalLogger ExternalLogger { get; set; }
        string balanceChangedCheck();
    }
}