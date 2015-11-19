using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_symbol_of_word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter word with 7 lettering  ");
            string word = Console.ReadLine();
            Console.WriteLine("Please enter number between 0 and 6 ");
            int number = int.Parse(Console.ReadLine());
            if (number < 0 || number > 6)
            {
                Console.WriteLine("wrong entry please try again");
            }
            else
            {
                word = word.ToUpper();
                Console.WriteLine(word[number]);
            }




        }
    }
}
