using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Calculator
{
    class Program
    {
        private static double number1;
        private static double num2;
        private static double total;
        private static char oper;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter operator ");
            oper = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the second number ");
            num2 = Convert.ToDouble(Console.ReadLine());
            if (oper == '+')
            {
                total = number1 + num2;
                Console.WriteLine("The result of addition equals " + total);
            }
            else if (oper == '-')
            {
                total = number1 - num2;
                Console.WriteLine("The result of the subtraction equals " + total);
            }
            else if (oper == '*')
            {
                total = number1 * num2;
                Console.WriteLine("The result of multiplying equals " + total);
            }
            else if (oper == '/')
            {
                if (num2 == 0) { Console.WriteLine("Division by zero "); }
                total = number1 / num2;
                Console.WriteLine("The division result equals " + number1 + "/" + number2 + "=" + total);
            }
            else
            { Console.WriteLine("Unknown operator "); }
        }
    }
}