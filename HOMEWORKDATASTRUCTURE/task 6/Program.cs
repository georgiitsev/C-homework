using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
          Dictionary<int, string> temp = new Dictionary<int, string>();
            Dictionary<string, int> uniqueWords = new Dictionary<string, int>();

            string text = "The better to focus on preparing more texts, Jonathan Bennett has handed over the ownership and maintenance of this site to Peter Millican and Amyas Merivale, of Hertford College, Oxford. Returning visitors will notice that we have given the site a fresh lick of paint, but the core content is unchanged. In particular, we will continue to host Jonathan Bennett’s articles here, and — of course — all of his wonderful translations of early modern texts.";
            Console.WriteLine("Your text:");
            Console.WriteLine();
            Console.WriteLine(text);

            int key = 0;
            int occurrences = 0;
            char[] marks = new char[] { '.', ',', ' ' };
            string[] split = text.Split(marks);

            foreach (string item in split)
            {
                key += 1;
                temp.Add(key, item);

                if (item == "")
                {
                    temp.Remove(key);
                    key--;
                }
            }

            foreach (var item in temp)
            {
                occurrences = 1;

                if (uniqueWords.ContainsKey(item.Value))
                {
                    uniqueWords.Remove(item.Value);
                    occurrences++;
                    uniqueWords.Add(item.Value, occurrences);
                }
                else
                {
                    uniqueWords.Add(item.Value, occurrences);
                }
            } 

            Console.WriteLine();
            Console.WriteLine("The unique words in your text are: ");
            Console.WriteLine();

            foreach (var item in uniqueWords)
            {
                if (item.Value == 1)
                {
                    Console.Write(item.Key + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        
        }
    }
}
