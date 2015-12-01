using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparetwoarrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter size of array");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please enter size of secondarray");
            int secondSize = int.Parse(Console.ReadLine());
            int[] secondArray = new int[secondSize];

            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < secondArray.Length; i++)
            {
                if (secondArray[i] == array[i])
                {
                    Console.WriteLine("its the same ");
                    break;
                }
                else
                {
                    Console.WriteLine(" they are not  the same");
                    break;
                }

            }

        }
    }
}
