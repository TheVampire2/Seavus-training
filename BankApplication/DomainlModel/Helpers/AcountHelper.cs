using DomainlModel.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainlModel.Helpers
{
   public static class AcountHelper
    {   
       /// <summary>
       /// field that is generated for the new id 
       /// </summary>
        private static int s_AccountId;
        public static List<string> s_balanceChangedLog;
        
        static AcountHelper()
        {
            s_AccountId = 0;
            s_balanceChangedLog = new List<string>();
            
        }
       /// <summary>
       /// Genereates fresh new id
       /// </summary>
       /// <returns></returns>
        public static int GenerateAccountId()
        {
            return s_AccountId++;
        }
       /// <summary>
       /// Generates fresh new account number
       /// </summary>
       /// <param name="accountType"></param>
       /// <param name="accountId"></param>
       /// <returns></returns>
        public static string GenerateAccountNumber<IAccount>(long accountId)
        {
            if (typeof(IAccount) == typeof(ITransactionAccount))
                return "TR0000" + accountId;
            else if (typeof(IAccount) == typeof(IDepositAccount))
                return "DP0000" + accountId;
            else if (typeof(IAccount) == typeof(ILoanAccount))
                return "LN0000" + accountId;
            return "null";
        }
       /// <summary>
       /// Logging the transaction 
       /// </summary>
       /// <param name="acoount"></param>
       /// <param name="type"></param>
       /// <param name="amount"></param>
        public static void LogTransaction(IAccount acoount, TransactionType type, CurrencyAmount amount)
        {
            if(amount.Currency == "$" && amount.Amount > 20000)
            {
                Console.WriteLine(String.Format("Number:{0}, Type:{1}, Amount: {2} {3}", acoount.Number, type.ToString(), amount.Amount,amount.Currency));
            }
        }
       /// <summary>
       /// Notify national bank 
       /// </summary>
       /// <param name="acoount"></param>
       /// <param name="type"></param>
       /// <param name="amount"></param>
        public static void NotifyNationalBank(IAccount acoount, TransactionType type, CurrencyAmount amount)
        {
            if (amount.Currency == "$" && amount.Amount > 25000)
            {

                Console.WriteLine("Carefull, 25 000 MKD is big money");
            }
        }
       /// <summary>
       /// Log the balance change in specific account
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="eventArgs"></param>
        public static void LogBalanceChanged(Object sender, BalanceChangedEventArguments eventArgs)
        {
            s_balanceChangedLog.Add(String.Format("New balance of the Account with Account No.: {0} is {1} {2}", eventArgs.Account.Number, eventArgs.Account.Balance.Amount, eventArgs.Account.Balance.Currency));
            Console.WriteLine(String.Format("New balance of the Account with Account No.: {0} is {1} {2}", eventArgs.Account.Number, eventArgs.Account.Balance.Amount, eventArgs.Account.Balance.Currency));
        }
       /// <summary>
       /// Method for logging specific exception 
       /// </summary>
       /// <param name="e"></param>
        public static void LogException(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
