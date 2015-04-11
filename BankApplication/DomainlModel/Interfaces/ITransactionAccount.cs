namespace DomainlModel
{
    public interface ITransactionAccount : IAccount
    { 
        CurrencyAmount Limit { get;  } 
    }
}