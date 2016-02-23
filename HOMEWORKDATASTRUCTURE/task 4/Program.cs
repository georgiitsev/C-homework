using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            int current = 0;
            int majorant = 0;
            int numberOfOccurrences = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Add number: ");
                array[i] = int.Parse(Console.ReadLine());
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

                if (i == 0)
                {
                    current = numberOfOccurrences;
                    majorant = array[i];
                }
                else if (numberOfOccurrences > current)
                {
                    current = numberOfOccurrences;
                    majorant = array[i];
                }
            }

            if (current >= (n / 2 + 1))
            {
                Console.WriteLine();
                Console.WriteLine("The majorant in your array is: " + majorant);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("The majorant does not exists!");
            }
            Console.WriteLine();
        }
    }
}
