using BasicAcct.Lib.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAcct.Tests.TestClasses
{
    public class TestCommandHandler : ICommandHandler<TestCommand>
    {
        public void Execute(TestCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
