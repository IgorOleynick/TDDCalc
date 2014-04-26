using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLogic;

namespace ConsoleApplication
{
    class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите выражение и нажмите Enter:\n");
                string expression = Console.ReadLine();
                var parser = new Parser(expression);
                new Calculator();
                var result = Calculator.Calculate(parser);
                Console.WriteLine(result);
                Console.WriteLine("----------------------------------\n");
            }
        }
    }
}
