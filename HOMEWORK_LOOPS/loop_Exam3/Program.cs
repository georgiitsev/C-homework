using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            

            Console.WriteLine("Please enter numbers ");
            for (int i = 0; i < 10; i++)
            {
             int number=int.Parse(Console.ReadLine());
                
                if (number >= max)

                {
                    max = number;
                }
                else
                {
                    min = number;
                }

            }
            Console.WriteLine("the max number is : {0}",max);
            Console.WriteLine("the min number is : {0}", min);
        }
    }
}
