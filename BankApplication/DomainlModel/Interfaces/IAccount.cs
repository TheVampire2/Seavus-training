using System;

namespace DomainlModel
{
    public interface IAccount
    {
        int ID { get; }
        string Number { get; }
        string Currency { get; }
        CurrencyAmount Balance { get; }
        TransactionStatus CreditAmount(CurrencyAmount amount);
        TransactionStatus DebitAmount(CurrencyAmount amount);

        event Delegates.BalanceChaged OnBalanceChanged;

    }
}