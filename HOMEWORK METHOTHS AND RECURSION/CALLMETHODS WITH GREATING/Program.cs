using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALLMETHODS_WITH_GREATING
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a name ");
            string name = Console.ReadLine();

           PrintName(name);
        }

        private static void PrintName(string name)
        {
            Console.WriteLine("Greating,"+name +"!" );
        }
    }
}
