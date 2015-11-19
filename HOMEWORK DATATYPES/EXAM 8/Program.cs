using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concat_two_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your  last name");
            string lastName = Console.ReadLine();
            string fullName = firstName + "|" + lastName;
            Console.WriteLine(fullName);
        }
    }
}
