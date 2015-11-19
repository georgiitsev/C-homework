using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divide_double_with_integer+

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second  number ");
            double seconNumber = double.Parse(Console.ReadLine());
            double result =seconNumber / number;
            Console.WriteLine(result);
            //Console.WriteLine("Enter integer number ");
            //int operand1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter double or decimal number");
            //double operand2 = double.Parse(Console.ReadLine()); 
            //double number5 = operand1 / operand2;
            //Console.WriteLine(number5);

        }
    }
}
