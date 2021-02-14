using Calculator.Core.Repositories;
using FluentAssertions;
using NUnit.Framework;

namespace Calculator.Tests
{
    public class Tests
    {
        private ICalculator _calculator;
        [SetUp]
        public void Setup()
        {
            _calculator = new Core.Repositories.Calculator();
        }

        [TestCase(5, "5", "+", "10")]
        [TestCase(5, "50", "+", "55")]
        [TestCase(5, "500", "+", "505")]
        [TestCase(5, "5000", "+", "5005")]
        public void Test_Addition(double operand1, string operand2, string operatorType, string shouldBe)
        {
            var result = _calculator.Calculate(operand1, operand2, operatorType);
            result.Should().Be(shouldBe);
        }

        [TestCase(5, "5", "-", "0")]
        [TestCase(5, "50", "-", "-45")]
        [TestCase(5, "500", "-", "-495")]
        [TestCase(5, "5000", "-", "-4995")]
        public void Test_Subtraction(double operand1, string operand2, string operatorType, string shouldBe)
        {
            var result = _calculator.Calculate(operand1, operand2, operatorType);
            result.Should().Be(shouldBe);
        }


        [TestCase(5, "5", "*", "25")]
        [TestCase(5, "50", "*", "250")]
        [TestCase(5, "500", "*", "2500")]
        [TestCase(5, "5000", "*", "25000")]
        public void Test_Multiplication(double operand1, string operand2, string operatorType, string shouldBe)
        {
            var result = _calculator.Calculate(operand1, operand2, operatorType);
            result.Should().Be(shouldBe);
        }


        [TestCase(5, "5", "/", "1")]
        [TestCase(25, "5", "/", "5")]
        [TestCase(5, "500", "/", "0.01")]
        [TestCase(5, "5000", "/", "0.001")]
        public void Test_Division(double operand1, string operand2, string operatorType, string shouldBe)
        {
            var result = _calculator.Calculate(operand1, operand2, operatorType);
            result.Should().Be(shouldBe);
        }
    }
}