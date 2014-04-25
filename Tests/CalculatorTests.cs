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
            var calculator = new Calculator();
            int result = Calculator.Add();
            Assert.Equal(4, result);
        }
    }
}
