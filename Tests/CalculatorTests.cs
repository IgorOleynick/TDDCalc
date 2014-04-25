using Xunit;
using BusinessLogic;

namespace Tests
{
    public class CalculatorTests
    {
        static void Main(string[] args)
        {
        }

        [Fact]
        public void Add()
        {
            string[] args = {"1", "+", "2"};
            var parser = new Parser(args);
            object result = null;
            if (parser.OperatorType == OperatorTypes.add)
            {
                 result = Calculator.Add(parser.FirstOperand, parser.SecondOperand);
            }
            Assert.Equal(3.0, result);
        }

        [Fact]
        public void Deduct()
        {
            string[] args = { "2", "-", "1" };
            var parser = new Parser(args);
            object result = null;
            if (parser.OperatorType == OperatorTypes.deduct)
            {
                result = Calculator.Deduct(parser.FirstOperand, parser.SecondOperand);
            }
            Assert.Equal(1.0, result);
        }

        [Fact]
        public void Multiply()
        {
            string[] args = { "2", "*", "3" };
            var parser = new Parser(args);
            object result = null;
            if (parser.OperatorType == OperatorTypes.multiply)
            {
                result = Calculator.Multiply(parser.FirstOperand, parser.SecondOperand);
            }
            Assert.Equal(6.0, result);
        }

        [Fact]
        public void Divide()
        {
            string[] args = { "6", "/", "2" };
            var parser = new Parser(args);
            object result = null;
            if (parser.OperatorType == OperatorTypes.divide)
            {
                result = Calculator.Divide(parser.FirstOperand, parser.SecondOperand);
            }
            Assert.Equal(3.0, result);
        }
    }
}
