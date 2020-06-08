using Calculator.models;
using System;
using Xunit;

namespace Calculator_Tests
{
    public class CalculatorTests
    {
        [Fact(DisplayName = "Test der Addition")]
        public void TestAddition()
        {
            Calculator.models.Calculator calc = new Calculator.models.Calculator();
            decimal result = calc.Calculate(7.5m, 2.5m, CalculationType.ADDITION);
            Assert.Equal(10.0m, result);
        }

        [Fact(DisplayName = "Test der Subtraktion")]
        public void TestSubtraktion()
        {
            Calculator.models.Calculator calc = new Calculator.models.Calculator();
            decimal result = calc.Calculate(7.5m, 2.5m, CalculationType.SUBTRACTION);
            Assert.Equal(5.0m, result);
        }

        [Fact(DisplayName = "Test der Multiplikation")]
        public void TestMultiplikation()
        {
            Calculator.models.Calculator calc = new Calculator.models.Calculator();
            decimal result = calc.Calculate(7.5m, 2.5m, CalculationType.MULTIPLICATION);
            Assert.Equal(18.75m, result);
        }

        [Fact(DisplayName = "Test der Division")]
        public void TestDivision()
        {
            Calculator.models.Calculator calc = new Calculator.models.Calculator();
            decimal result = calc.Calculate(7.5m, 2.5m, CalculationType.DIVISTION);
            Assert.Equal(3.0m, result);
        }

    }
}
