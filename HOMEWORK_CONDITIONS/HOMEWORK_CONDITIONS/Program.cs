using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK_CONDITIONS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose your variable : ");
            Console.WriteLine("For integer please enter 1  for double 2 for string 3");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Enter value for integer ");
                    int firstChoise = int.Parse(Console.ReadLine());
                    Console.WriteLine(firstChoise + 1); break;
                case 2:
                    Console.WriteLine("enter value for double");
                    double secondChoise = double.Parse(Console.ReadLine());
                    Console.WriteLine(secondChoise + 1); break; //or (++secondChoise )
                case 3:
                    Console.WriteLine("Enter word for string");
                    string thirdChoise = Console.ReadLine();
                    Console.WriteLine(thirdChoise + "*"); break;
                default:
                    Console.WriteLine("Wrong entry please try again!!!!!!!!!!!!!!!");
                    break;
            }
        }
    }
}
