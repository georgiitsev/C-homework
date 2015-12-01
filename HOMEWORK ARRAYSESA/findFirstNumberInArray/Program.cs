using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findFirstNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter size of array");
            int size= int.Parse(Console.ReadLine());
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
			{
                array[i] =int.Parse(Console.ReadLine());
			}
            Console.WriteLine("PLease enter the number its looking for ");
            int searchNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i <array.Length; i++)
            {
                if (searchNumber == array[i])
                {
                    searchNumber = i;
                }   
            }
            Console.WriteLine(searchNumber);
        }
    }
}
