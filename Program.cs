using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace division_with_remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second  number ");
            int secondnumber = int.Parse(Console.ReadLine());
            int sum = number % secondnumber;
            Console.Write("The result  of devide is :  ");
            Console.WriteLine(sum);
        }
    }
}
