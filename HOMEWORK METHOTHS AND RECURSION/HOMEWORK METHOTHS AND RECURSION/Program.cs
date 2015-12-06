using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK_METHOTHS_AND_RECURSION
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second number");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number");
            int thirdNumber = int.Parse(Console.ReadLine());
             MaxNumber (firstNumber,secondNumber);
             MaxNumber(firstNumber,secondNumber,thirdNumber);
            

        }

        private static void MaxNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            int number = int.MinValue; 
            if (firstNumber > secondNumber && secondNumber > thirdNumber)
            {
                number = firstNumber;
                Console.WriteLine("The most bigest number is " + number);
            }

            else if (secondNumber > firstNumber && firstNumber > thirdNumber)
            {
                
                number = secondNumber;
                Console.WriteLine("The bigest number is " + number);
            }
            else
            {
                number = thirdNumber;
                Console.WriteLine("The bigest number is " + number);
            }
        }

        private static void MaxNumber(int firstNumber, int secondNumber)
        {
            int number = int.MinValue;
            if (firstNumber > secondNumber)
            {
                number = firstNumber;
                Console.WriteLine("The most bigest number is " + number);
            }
            else
            {
                number = secondNumber;
                Console.WriteLine("The bigest number is "+ number);
            }
        }

      
        
    }
}
