using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcolateEGN
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] ARRAY = new int[10];
            int count = 1;
            int counter = 1;
            
            int temp = 0;
            int check = 0;
           
            int[] secondArray = new int[ARRAY.Length - 1];
            for (int i = 1; i < ARRAY.Length; i++)
            {
                Console.WriteLine("PLease enter your first 9 digit of EGN digit by digit" + count++);
                if (i == 1)
                {
                    counter = 2;
                }
                else if (i == 2)
                {
                    counter = 4;
                }
                else if (i == 3)
                {
                    counter = 8;
                }
                else if (i == 4)
                {
                    counter = 5;
                }
                else if (i == 5)
                {
                    counter = 10;
                }
                else if (i == 6)
                {
                    counter = 9;
                }
                else if (i == 7)
                {
                    counter = 7;
                }
                else if (i == 8)
                {
                    counter = 3;
                }
                else if (i == 9)
                {
                    counter = 6;
                }


                ARRAY[i] = int.Parse(Console.ReadLine());
                temp += ARRAY[i] * counter;

                check = temp % 11;
                if (check == 10)
                {
                    check = 0;
                }
                
               
              

            }
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.Write("Your full EGN is:  ");
            for (int i = 1; i < ARRAY.Length; i++)
            {
                Console.Write(ARRAY[i]);

            }
            Console.WriteLine(check);
            Console.ResetColor();

        }
    }
}
