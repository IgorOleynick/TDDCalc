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

    public enum OperatorTypes
    {
        add,
        deduct,
        multiply,
        divide
    }

    public class Parser
    {
        private double firstOperand;
        private double secondOperand;
        private OperatorTypes operatorType;

        public Parser(string[] args)
        {
            firstOperand = Convert.ToDouble(args[0]);
            secondOperand = Convert.ToDouble(args[2]);

            switch (args[1])
            {
                case "+":
                    operatorType = OperatorTypes.add;
                    break;
                case "-":
                    operatorType = OperatorTypes.deduct;
                    break;
                case "*":
                    operatorType = OperatorTypes.multiply;
                    break;
                case "/":
                    operatorType = OperatorTypes.divide;
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

        public static double Deduct(double firstOperand, double secondOperand)
        {
            throw new NotImplementedException();
        }
    }
}
