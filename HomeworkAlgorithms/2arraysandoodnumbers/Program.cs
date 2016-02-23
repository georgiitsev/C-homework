
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2arraysandoodnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;
            int[] myArray = new int[n];
            List<int> oddArray = new List<int>();
            List<int> evenArray = new List<int>();

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                myArray[i] = rand.Next(0, 1000);
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    evenArray.Add(myArray[i]);
                }
                else if (myArray[i] % 2 == 1)
                {
                    oddArray.Add(myArray[i]);
                }
            }

            int original = Environment.TickCount;
            QuicksortMyArray(myArray, 0, n - 1);
            Console.WriteLine("Quicksorting time of the original array in miliseconds: " + (Environment.TickCount - original));
            Console.WriteLine();

            foreach (var item in myArray)
            {
                Console.Write(item + " ");
            } Console.WriteLine();

            Console.WriteLine();
            int even = Environment.TickCount;
            SortEvenArray(evenArray);
            Console.WriteLine("Sorting time of the array with even numbers in miliseconds: " + (Environment.TickCount - even));
            Console.WriteLine();

            foreach (var item in evenArray)
            {
                Console.Write(item + " ");
            } Console.WriteLine();

            Console.WriteLine();
            int odd = Environment.TickCount;
            SortOddArray(oddArray);
            Console.WriteLine("Sorting time of the array with odd numbers in miliseconds: " + (Environment.TickCount - odd));
            Console.WriteLine();

            foreach (var item in oddArray)
            {
                Console.Write(item + " ");
            } Console.WriteLine();

            Console.WriteLine();
        }

        static void QuicksortMyArray(int[] array, int left, int right)
        {
            int temp = 0;
            int i = left, j = right;
            int pivot = array[(left + right) / 2];

            while (i <= j)
            {
                while (array[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (array[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;

                    i++;
                    j--;
                }

                if (left < j)
                {
                    QuicksortMyArray(array, left, j);
                }

                if (i < right)
                {
                    QuicksortMyArray(array, i, right);
                }
            }
        }

        static void SortEvenArray(List<int> array)
        {
            int temp = 0;

            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array.Count; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        static void SortOddArray(List<int> array)
        {
            int temp = 0;

            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array.Count; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
