using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> playingCards = new Dictionary<int, string>();
            Dictionary<string, int> cards = new Dictionary<string, int>();
      #region
            playingCards.Add(1, " 2");
            playingCards.Add(2, " 3");
            playingCards.Add(3, " 4");
            playingCards.Add(4, " 5");
            playingCards.Add(5, " 6");
            playingCards.Add(6, " 7"); 
            playingCards.Add(7, " 8"); 
            playingCards.Add(8, " 9");
            playingCards.Add(9, " 10");
            playingCards.Add(10, " J");
            playingCards.Add(11, " Q");
            playingCards.Add(12, " K");
            playingCards.Add(13, " A");
           
      #endregion

            int [] temp = new int [5];
            Console.WriteLine("Please enter 5 cards");
            for (int i = 0; i < 5; i++)
            {
                int number =int.Parse (Console.ReadLine());
                if (number > 0 && number <= 13)
                {
                    temp[i] = number;
                }
                else
                {
                    Console.WriteLine("Invalid cards choose between 2 and A");
                }

            }
            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }

        }
    }
}
