using BasicAcct.Lib.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAcct.Tests.TestClasses
{
    public class TestCommand : ICommand
    {
        private List<string> stringList;
        private string message;

        public TestCommand(List<string> stringList, string message)
        {
            this.stringList = stringList;
            this.message = message;
        }
    }
}
