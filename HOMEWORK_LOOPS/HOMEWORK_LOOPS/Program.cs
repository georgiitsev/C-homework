using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK_LOOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number = ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter secondNumber = ");
            int secondNumber = int.Parse(Console.ReadLine());

            int maxDiviser = 1;
            if (0 < number && 0 < secondNumber)
            {
                for (int i = Math.Min(number, secondNumber); i > 0; i--)
                {
                    if (number % i == 0 && secondNumber % i == 0)
                    {
                       maxDiviser = i;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine(
                   "Wrong entry");
            }
            Console.WriteLine(
               "MAX Diviser = " + maxDiviser);
        }
    }
}
