using HRM.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HRMUnitTests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAdd()
        {
            Calculator calculator = new Calculator();
            Assert.Equal(4.0, calculator.Addition(2,2));
        }
    }
}
