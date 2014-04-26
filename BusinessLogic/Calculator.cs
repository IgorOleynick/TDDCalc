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
        private readonly double _firstOperand;
        private readonly double _secondOperand;
        private readonly OperatorTypes _operatorType;

        public Parser(string args)
        {
            _firstOperand = Convert.ToDouble(args[0].ToString());
            _secondOperand = Convert.ToDouble(args[2].ToString());

            switch (args[1])
            {
                case '+':
                    _operatorType = OperatorTypes.Add;
                    break;
                case '-':
                    _operatorType = OperatorTypes.Deduct;
                    break;
                case '*':
                    _operatorType = OperatorTypes.Multiply;
                    break;
                case '/':
                    _operatorType = OperatorTypes.Divide;
                    break;
                default:
                    throw new Exception("Operator error");
            }
        }

        public double FirstOperand
        {
            get { return _firstOperand; }
        }

        public OperatorTypes OperatorType
        {
            get { return _operatorType; }
        }

        public double SecondOperand
        {
            get { return _secondOperand; }
        }
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
