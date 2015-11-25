using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditions_exam_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "between 1 and 9"; 
            Console.WriteLine("Please enter your  points {0}",word);
            int points = int.Parse(Console.ReadLine());

            if (points >= 1 && points <= 3)
            {
                int bonusPoints = points + 5;
                Console.WriteLine("Your final score is {0}", bonusPoints);
            }
            else if (points >= 4 && points <= 6)
            {
                int bonusPoints = points * 12;
                Console.WriteLine("Your final score is {0}",bonusPoints);
            }
            else if (points >= 7 && points <= 9 )
            {
                int bonusPoints = (points * 50) / 3;
                Console.WriteLine("Your final score is {0}", bonusPoints);
            }
            else
            {
                Console.Write("Invalid point !!!!!!!!!!!!!!!!!! ");
                Console.WriteLine("Please enter between 1 and 9  ");
            }

        }
    }
}
