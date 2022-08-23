using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UserTicketService.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void MultiplicationMustreturnNotNullValue()
        {
            var calculator = new Calculator();

            Assert.Equal(8, calculator.Multiplcation(2, 4));

        }

    }
}
