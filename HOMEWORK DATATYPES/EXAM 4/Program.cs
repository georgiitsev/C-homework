using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_str_cantain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first string(word)");
            string str = Console.ReadLine();
            Console.WriteLine("Please enter second string(word)");
            string str1 = Console.ReadLine();
            Console.Write("It does contain the second word in the first : ");
            Console.WriteLine(str.Contains(str1));
        }
    }
}
