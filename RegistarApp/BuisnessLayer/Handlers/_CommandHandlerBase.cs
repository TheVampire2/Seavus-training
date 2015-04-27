using BuisnessLayer.Handlers;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Contracts.Handlers
{
    /// <summary>
    /// Abstract class for all command handlers
    /// </summary>
    internal abstract class CommandHandlerBase<TRequest,TResult> :  IHandler where TRequest : Command
                                                                    where TResult : CommandResult
    {
        
        /// <summary>
        /// Entry point of the handler
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public CommandResult Execute(Command command)
        {
            return ExecuteCommand((TRequest)command);
        }

        public abstract TResult ExecuteCommand(TRequest command);

        
    }
    
}
