using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERMUTATION
{
    class Program
    {
        //ТОВА Е ГОТОВО РЕШЕНИЕ НЕ Я СХВАЩАМ ТОЧНО ЛОГИЧЕСКИ КАК ДА Я РЕАЛИЗИРАМ НА ТЕОРИЯ ДА НО НА ПРАКТИКА VERY BAD FOR ME!!!!
        static void Main(string[] args)
        {
            Console.WriteLine("PLease enter some  number");
            int number =int.Parse(Console.ReadLine());
            ThreePermutations(number);
            
        }


        static void ThreePermutations(int y)
        {

            Console.Write("Enter a number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int[] array = new int[100];
            int i;

            for (i = 1; i <= secondNumber; i++)
            {
                array[i] = i;
            }
            Console.WriteLine("Permutations:");
            Permutate(1, secondNumber, array);
        }

        static void Permutate(int k, int n, int[] numbers)
        {
            int i, j, temporary;
            if (k <= n)
            {
                for (i = k; i <= n; i++)
                {
                    temporary = numbers[i];
                    for (j = i; j > k; j--)
                    {
                        numbers[j] = numbers[j - 1];
                    }
                    numbers[k] = temporary;
                    Permutate(k + 1, n, numbers);
                    for (j = k; j < i; j++)
                    {
                        numbers[j] = numbers[j + 1];
                    }
                    numbers[i] = temporary;
                }
            }
            else
            {
                for (i = 1; i <= n; i++)
                {
                    Console.Write("{0} ", numbers[i]);
                }
                Console.WriteLine();
            }
        }
    }
}

