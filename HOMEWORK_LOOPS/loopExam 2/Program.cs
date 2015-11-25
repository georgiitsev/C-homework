using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopExam_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter number ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
                
            }
        }
    }
}
