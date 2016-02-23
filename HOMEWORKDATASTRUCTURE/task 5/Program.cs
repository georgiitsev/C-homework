using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> word = new Dictionary<int, string>();
            Dictionary<string, int> uniqueWord = new Dictionary<string, int>();

            string newWords;

            for (int i = 0; i <20; i++)
            {
                Console.WriteLine("Please enter 20 words");
                newWords = Console.ReadLine();
                word.Add(i+1,newWords);
            }
            foreach (string item in word.Values)
            {
                if (uniqueWord.ContainsKey(item))
                {
                    uniqueWord[item]++;   
                }
                else
                {
                    uniqueWord[item] = 1;
                }
                
            }
            foreach (var item in uniqueWord)
            {
                if (item.Value == 1)
                {
                    Console.WriteLine("The unique word is {0} and occure {1} times ", item.Key,item.Value);
                }
                else
                {
                    Console.WriteLine("The unique word is {0} and occure {1} times ", item.Key, item.Value);
                }
            }
        }
    }
}
