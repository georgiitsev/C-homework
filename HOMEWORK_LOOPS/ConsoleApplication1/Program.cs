using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a N :");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a K :");
            int K = int.Parse(Console.ReadLine());
            int factorialN = 1;
            int factorialK = 1;


            for (int i = N; i <= N; i++)
            {
                factorialN =i * i;
            }
            Console.WriteLine("FACTORIEL N! = {0}!", factorialN);


            for (int i = K; i <= K; i++)
            {
                factorialK = i * i;
            }
            int factorialNK = factorialN - factorialK;
            Console.WriteLine();
            Console.WriteLine("FACTORIEL K! = {0}!", factorialK);
            Console.WriteLine();
            Console.WriteLine("factorialNK = " + factorialNK);
            int result = factorialN * factorialK / factorialNK;
            Console.WriteLine();
            Console.WriteLine("Result of {0}!*{1}! / {2}! = "  + result,factorialN,factorialK,factorialNK);
        }
    }
}
