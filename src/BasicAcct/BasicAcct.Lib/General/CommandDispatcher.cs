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
           if(command == null)
            {
                throw new ArgumentNullException("Missing or null command");
            }

            throw new NotImplementedException();
        }
    }
}
