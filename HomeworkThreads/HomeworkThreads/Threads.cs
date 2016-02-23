using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeworkThreads
{
    class Threads
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int sleep;
        public int Sleep
        {
            get { return sleep; }
            set { sleep = value; }
        }

        public Threads(string name, Random seconds)
        {
            this.name = name;
            this.sleep = seconds.Next(1000, 10000);
        }

        public void ThreadsInfo()
        {
            Console.WriteLine("The thread is started!");
            Console.WriteLine("This thread has the name {0}!", name);
            Thread.Sleep(sleep);
            Console.WriteLine("The thread {0} is complete!", name);
        }
    }
}
