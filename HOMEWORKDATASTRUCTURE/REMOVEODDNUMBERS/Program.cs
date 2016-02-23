using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMOVEODDNUMBERS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int > number = new List<int>();
            List<int> temporary = new List<int>();
            int counter = 1;
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("please enter number № {0}",counter);
                number.Add(int.Parse(Console.ReadLine()));
                counter++;
            }
            int temp;
            for (int i = 0; i < number.Count; i++)
            {
                int numbers = number[i];
                temp = 1;
                for (int j = 0; j < number.Count; j++)
                {
                    if (number[i]== number[j] && i != j )
                    {
                        temp += 1;
                    }

                }
                if (temp % 2 == 1 )
                {
                    if (temporary.Contains(numbers))
                    {
                        continue;
                    }
                    else
                    {
                        temporary.Add(numbers);
                    }
                    
                }
               
            }
            for (int i = 0; i < temporary.Count; i++)
            {
                for (int j = 0; j < number.Count; j++)
                {
                    if (number[j] == temporary[i])
                    {
                        number.Remove(number[j]);
                        j--;
                    }

                }
            }
            if (number.Count == 0)
            {
                Console.WriteLine("The list its empty please enter some numbers");
            }
            else
            {
                Console.WriteLine("Your list after removing numbers that occur odd times in the sequence::");
            }
            foreach (var item in number)
            {
                Console.Write(item + " ");
            }
            
        }
    }
}
