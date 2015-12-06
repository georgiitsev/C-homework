using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINT_ALL_SIMETRICAL_NUMBERS
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSimetricNumber();
        }

        private static void PrintSimetricNumber()
        {
            int first = 0;
            int second = 0;
            for (int i = 10; i < 1000; i++)
            {
                if (i > 100)
                {
                    first = i / 100;
                    second = i % 10;
                    if (first == second)
                    {
                        Console.WriteLine(i);
                    }

                   
                }
                if (i < 100 && i % 11 == 0)
                {
                    
                    Console.WriteLine(i);
                }
               
                 
            }

           
        }
    }
}
