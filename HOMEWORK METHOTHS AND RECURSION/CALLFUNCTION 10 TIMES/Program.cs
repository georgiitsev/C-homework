using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALLFUNCTION_10_TIMES
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a first number ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a third number ");
            int thirdNumber = int.Parse(Console.ReadLine());
            Random rand = new Random();
            Random cecond = new Random();
            Random between = new Random();

            MultiplyNumber(number, secondNumber, thirdNumber);

            for (int i = 0; i < 11; i++)
            {
                int dafne = rand.Next(10, 200);
                int cocine = cecond.Next(10, 200);
                int bethoven = between.Next(10, 200);
                MultiplyNumber(dafne, cocine, bethoven);
            }
        }



        private static void MultiplyNumber(int number, int secondNumber, int thirdNumber)
        {
            int sum = 0;
            sum = number * secondNumber * thirdNumber;
            Console.Write("The sum of aplly is : ");
            Console.WriteLine(sum);
        }
    }
}
