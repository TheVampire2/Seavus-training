using BuisnessLayer.Contracts;
using BuisnessLayer.Contracts.Handlers;
using BuisnessLayer.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer
{
    /// <summary>
    /// Provides methods for invoking from other layers
    /// </summary>
    public class CommandInvoker 
    {
        /// <summary>
        /// Entry point for execution of different commands
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static TResult InvokeCommand<TRequest,TResult>(TRequest command)  where TRequest : Command 
                                                                                 where TResult : CommandResult
        {
            IHandler _handler = GetHandler<TRequest>();
             
            TResult _result = default(TResult);
            
            if(_handler != null)
            {
                _result = (TResult)_handler.Execute(command);
            }
            return _result;
        }

       /// <summary>
       /// Factory method for creating handlers depending of Command type
       /// </summary>
       /// <typeparam name="TRequest"></typeparam>
       /// <returns></returns>
       private static IHandler GetHandler<TRequest>()
        {
            if(typeof(TRequest) == typeof(BikeSearchCommand))
            {
                return new BikeSearchCommandHandler();
            }
            if (typeof(TRequest) == typeof(BikeAddCommand))
            {
                return new BikeAddCommandHandler();
            }
            return null;
        }
    }
}
