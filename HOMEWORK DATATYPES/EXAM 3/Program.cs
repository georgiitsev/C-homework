using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chek_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write some word");
            string word =Console.ReadLine();
            bool mybool = word == "Hello World";
            Console.WriteLine(mybool);
        }
    }
}
