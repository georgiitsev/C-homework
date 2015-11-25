using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_exam4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter  N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter  K: ");
            int k = int.Parse(Console.ReadLine());
           long result = 1;
            for (int i = k + 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine("{0}!/ {1}! = {2}", n, k, result);
        }
    }
}
