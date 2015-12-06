using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEN_OR_ODD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLease enter some number !!!!!!");
            int number = int.Parse(Console.ReadLine());
            Random rand = new Random();
            

            IfNumberEvenOrNot(number);
            for (int i = 0; i < 12; i++)
            {
                int digits = rand.Next(1,10000);
                IfNumberEvenOrNot(digits);
            }
           
        }

        private static void IfNumberEvenOrNot(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("The number {0} is even",number);
            }
            else
            {
                Console.WriteLine("The number is {0} odd",number);
            }
        }


    }
}
