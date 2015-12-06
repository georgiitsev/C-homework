using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATEFACTORIAL_WITH_RECURSION
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number and we calcolate factoriel of this number ");
            int number =int.Parse(Console.ReadLine());



            long factorial = GetFactorial(number);
            Console.WriteLine("{0} factorial is {1}", number, factorial); 
        }

        private static long GetFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * GetFactorial(number - 1);
        }




    }
}


