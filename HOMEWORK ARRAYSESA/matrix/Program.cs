using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {Console.WriteLine("Please enter size of matrix ");
            int size =int.Parse(Console.ReadLine());
            int [,] matrix = new int[size,size];
            int count = 1 ;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = count++;
                   
                }
                
            }
            Console.WriteLine("HORIZONTAL ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write( "|" +matrix[i,j]+"|");

                }
                Console.WriteLine();

            }
            Console.WriteLine("VERTICAL ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("|" + matrix[j, i]+"|");

                }
                Console.WriteLine();

            }
            
        }
    }
}
