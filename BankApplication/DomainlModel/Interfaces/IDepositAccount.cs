using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainlModel
{
    public interface IDepositAccount : IAccount
    {
        TimePeriod Period { get; }
        InterestRate Interest { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
        ITransactionAccount TransactionAccount { get; }
    }
}
