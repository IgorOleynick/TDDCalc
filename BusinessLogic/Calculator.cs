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

        public double FirstOperand
        {
            get { return firstOperand; }
        }

        public OperatorTypes OperatorType
        {
            get { return operatorType; }
        }

        public double SecondOperand
        {
            get { return secondOperand; }
        }
    }

    public class Calculator
    {
        public static double? Calulate(Parser expression)
        {
            switch (expression.OperatorType)
            {
                case OperatorTypes.add:
                    return Add(expression.FirstOperand, expression.SecondOperand);
                case OperatorTypes.deduct:
                    return Deduct(expression.FirstOperand, expression.SecondOperand);
                case OperatorTypes.multiply:
                    return Multiply(expression.FirstOperand, expression.SecondOperand);
                case OperatorTypes.divide:
                    return Divide(expression.FirstOperand, expression.SecondOperand);
                default:
                    throw new ArgumentOutOfRangeException("Operator error");
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
