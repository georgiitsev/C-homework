using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditions_exam_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a card");
            string cardGames = Console.ReadLine();

            switch (cardGames)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "Q":
                case "K":
                case "A":
                    Console.WriteLine("You choose valid card thanks for your choise"); break;
                default:
                    Console.WriteLine("Invalid card please try again later");
                    break;
            }
        }
    }
}
