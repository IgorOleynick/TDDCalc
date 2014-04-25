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
            double result = Calculator.Add(parser.firstOperand, parser.secondOperand);
            Assert.Equal(3, result);
        }
    }
}
