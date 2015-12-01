using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostfriequent_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

            int count = 0;
            int currentIndex = 0;
            Console.WriteLine();

            if (size > 0 && size <= 100)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("Enter a number: ");
                    array[i] = int.Parse(Console.ReadLine());
                } Console.WriteLine();

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == array[currentIndex])
                    {
                        count++;
                    }
                    if (size == 1)
                    {
                        currentIndex = i;
                        count = 1;
                    }
                }
                Console.WriteLine("Most frequent number is " + array[currentIndex] + " and occurs " + count + " times.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("wrong entry please try with another value");
                Console.WriteLine();
            }
        }
    }
}
