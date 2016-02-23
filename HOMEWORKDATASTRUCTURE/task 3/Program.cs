using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers do you want to add to your array: ");
            int n = int.Parse(Console.ReadLine());

            int number;
            int numberOfOccurrences = 0;
            int[] array = new int[n];
            List<int> list = new List<int>();
            List<int> occurrences = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Add number: ");
                number = int.Parse(Console.ReadLine());

                if (number >= 0 && number <= 1000)
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Only numbers in the range of [0...1000] are allowed!");
                    Console.WriteLine();
                    i--;
                }
            }

            if (n == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Try again!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Calculations show that:");
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                numberOfOccurrences = 1;

                for (int j = 0; j < n; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        numberOfOccurrences += 1;
                    }
                }

                if (list.Contains(array[i]))
                {
                    continue;
                }
                else
                {
                    list.Add(array[i]);
                    occurrences.Add(numberOfOccurrences);
                }
            }

            for (int l = 0; l < list.Count; l++)
            {
                if (occurrences[l] == 1)
                {
                    Console.WriteLine("Number {0} occurs {1} time;", list[l], occurrences[l]);
                }
                else
                {
                    Console.WriteLine("Number {0} occurs {1} times;", list[l], occurrences[l]);
                }
            } Console.WriteLine();
        }
    }
}

