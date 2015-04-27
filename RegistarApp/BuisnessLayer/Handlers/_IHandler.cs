using BuisnessLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Handlers
{
    internal interface IHandler
    {
        CommandResult Execute(Command command);
    }
}
