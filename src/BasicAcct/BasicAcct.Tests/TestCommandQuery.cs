﻿using BasicAcct.Lib.General;
using BasicAcct.Tests.TestClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BasicAcct.Tests
{
    public class TestCommandQuery
    {
        [Fact]
        public void CheckIfCommandIsNull()
        {
            CommandDispatcher cd = new CommandDispatcher();
            var exception = Record.Exception(() => cd.Execute<TestCommand>(null));

            Assert.NotNull(exception);
            Assert.IsType<ArgumentNullException>(exception);
        }
    }
}
