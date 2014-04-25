using System;
using System.ComponentModel;

namespace BusinessLogic
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Parser
    {
        public double firstOperand;
        public double secondOperand;

        public Parser(string[] args)
        {
            firstOperand = Convert.ToDouble(args[0]);
            secondOperand = Convert.ToDouble(args[2]);
            switch (args[1])
            {
                case "+":
                    Calculator.Add(firstOperand, secondOperand);
                    break;
                case "-":
                    break;
                case "*":
                    break;
                case "/":
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Operator error");
            }
        }
    }

    public class Calculator
    {
        public static double Add(double firstOperand, double secondOperand)
        {
            return firstOperand + secondOperand;
        }
    }
}
