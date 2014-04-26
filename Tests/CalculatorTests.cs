using System;
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
            var result = Calculator.Calulate(parser);
            Assert.Equal(3.0, result);
        }

        [Fact]
        public void Deduct()
        {
            string[] args = { "2", "-", "1" };
            var parser = new Parser(args);
            var result = Calculator.Calulate(parser);
            Assert.Equal(1.0, result);
        }

        [Fact]
        public void Multiply()
        {
            string[] args = { "2", "*", "3" };
            var parser = new Parser(args);
            var result = Calculator.Calulate(parser);
            Assert.Equal(6.0, result);
        }

        [Fact]
        public void Divide()
        {
            string[] args = { "6", "/", "2" };
            var parser = new Parser(args);
            var result = Calculator.Calulate(parser);
            Assert.Equal(3.0, result);
        }
    }
}
