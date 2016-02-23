using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20TimesRunning
{
    class Program
    {
        private static Thread threadOne, threadTwo;
    
        static void Main(string[] args)
        {
            threadOne = new Thread(new ThreadStart(PrintNumbers));
            threadTwo = new Thread(new ThreadStart(Status));

            threadOne.Start();
            threadTwo.Start();
        }

        private static void PrintNumbers()
        {
            for (int i = 0; i <= 50000; i++)
            {
                Console.WriteLine(i);

                if (i == 25000)
                {
                    threadOne.Suspend();
                }
            }
        }

        private static void Status()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Running...");
                Thread.Sleep(500);
            } threadOne.Resume();
        }
    }
}
