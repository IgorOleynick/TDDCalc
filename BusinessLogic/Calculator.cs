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
        Add,
        Deduct,
        Multiply,
        Divide
    }

    public class Parser
    {
        public Parser(string args)
        {
            FirstOperand = Convert.ToDouble(args[0].ToString());
            SecondOperand = Convert.ToDouble(args[2].ToString());

            switch (args[1])
            {
                case '+':
                    OperatorType = OperatorTypes.Add;
                    break;
                case '-':
                    OperatorType = OperatorTypes.Deduct;
                    break;
                case '*':
                    OperatorType = OperatorTypes.Multiply;
                    break;
                case '/':
                    OperatorType = OperatorTypes.Divide;
                    break;
                default:
                    throw new Exception("Operator error");
            }
        }

        public double FirstOperand { get; private set; }

        public OperatorTypes OperatorType { get; private set; }

        public double SecondOperand { get; private set; }
    }

    public class Calculator
    {
        public static double? Calculate(Parser expression)
        {
            switch (expression.OperatorType)
            {
                case OperatorTypes.Add:
                    return Add(expression.FirstOperand, expression.SecondOperand);
                case OperatorTypes.Deduct:
                    return Deduct(expression.FirstOperand, expression.SecondOperand);
                case OperatorTypes.Multiply:
                    return Multiply(expression.FirstOperand, expression.SecondOperand);
                case OperatorTypes.Divide:
                    return Divide(expression.FirstOperand, expression.SecondOperand);
                default:
                    throw new Exception("Operator error");
            }
        }

        private static double Add(double firstOperand, double secondOperand)
        {
            return firstOperand + secondOperand;
        }

        private static double Deduct(double firstOperand, double secondOperand)
        {
            return firstOperand - secondOperand;
        }

        private static double Multiply(double firstOperand, double secondOperand)
        {
            return firstOperand*secondOperand;
        }

        private static double Divide(double firstOperand, double secondOperand)
        {
            return firstOperand/secondOperand;
        }
    }
}
