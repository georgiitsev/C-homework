using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORKDATASTRUCTURE
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            string number;

            for (int i = 0; i < int.MaxValue; i++)
            {
                Console.Write("Enter a number: ");
                number = Console.ReadLine();

                if (number != string.Empty)
                {
                    numbers.Add(int.Parse(number));
                }
                else
                {
                    break;
                }
            } Console.WriteLine();

            if (numbers.Count == 0)
            {
                Console.WriteLine("Your list is empty!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The sum of all numbers in your sequence is: " + numbers.Sum());
                Console.WriteLine("The average value in your sequence is: " + numbers.Average());
                Console.WriteLine();
            }
        }
    }
}
