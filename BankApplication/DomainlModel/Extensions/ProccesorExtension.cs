using DomainlModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainlModel.Extensions
{
    public static class ProccesorExtension
    {
        /// <summary>
        /// Extension that will charge additional fee of the last transaction made 
        /// </summary>
        /// <param name="proccesor"></param>
        /// <param name="amount"></param>
        /// <param name="accounts"></param>
        /// <returns></returns>
        public static TransactionStatus ChargeProcessingFee(this ITransactionProccesor proccesor, CurrencyAmount amount, IList<IAccount> accounts)
        {
            proccesor.feeCharged = true;
            return proccesor.ProccessGroupTransaction(TransactionType.Debit, amount, accounts);
        }
    }
}
