using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibbonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter size of fibonacci ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            int first = 0;
            int second = 1;
            int third = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = third;

                third = first + second;
                first = second;
                second = third;
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
