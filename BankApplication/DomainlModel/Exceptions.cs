using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainlModel
{
    /// <summary>
    /// currency missmatch exception class
    /// </summary>
    public class CurrencyMissmatchException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Error occured: Currency missmatch";
            }
        }
    }
    /// <summary>
    /// Limit overreached exception class
    /// </summary>
    public class LimitOverreachedException : ApplicationException
    {
        private CurrencyAmount Amount { get; set; }

        public LimitOverreachedException(CurrencyAmount amount)
        {
            Amount = amount;
        }
        public override string Message
        {
            get
            {
                return String.Format("The limit of the acount was overreached by: {0} {1} ", Amount.Amount, Amount.Currency);
            }
        }
        
    }
    /// <summary>
    /// UI exceptions wraper
    /// </summary>
    public class UserInterfaceException : ApplicationException
    {
        public Exception exception;

        public string friendlyMessage;

       
        public UserInterfaceException(string p, Exception ex)
        {
            // TODO: Complete member initialization
            this.friendlyMessage = p;
            this.exception = ex;
        }


    }
    /// <summary>
    /// Buisness logic exeption wrapper
    /// </summary>
    public class BuisnessLogicException : ApplicationException
    {
        public Exception exception;
        public BuisnessLogicException(Exception exception)
        {
            // TODO: Complete member initialization
            this.exception = exception;
        }

    }

    
}
