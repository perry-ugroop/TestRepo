using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BasicAcct.Tests
{
    public class TestSample
    {
        [Fact]
        public void TestIfXunitWorks()
        {
            Assert.Equal(4, 2 + 2);
        }
    }
}
