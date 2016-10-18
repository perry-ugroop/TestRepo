using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAcct.Lib.General
{
    public class CommandDispatcher : ICommandDispatcher
    {
        public void Execute<TCommand>(TCommand command) 
            where TCommand : ICommand
        {
            throw new NotImplementedException();
        }
    }
}
