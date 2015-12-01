using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK_ARRAYSESA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please fill the array ");
            int size =int.Parse(Console.ReadLine());
            Random rand = new Random();
            int[]array = new int [size];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1,100);
                if (array[i] % 2 == 0)
                {
                    sum += array[i]; 
                }
                
            }
            Console.Write("The sum of all even number are : ");
            Console.WriteLine(sum);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
