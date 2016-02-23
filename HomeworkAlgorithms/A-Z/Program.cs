using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Z
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "The better to focus on preparing more texts, Jonathan Bennett has handed over the ownership and maintenance of this site to Peter Millican and Amyas Merivale, of Hertford College, Oxford. Returning visitors will notice that we have given the site a fresh lick of paint, but the core content is unchanged. In particular, we will continue to host Jonathan Bennett’s articles here, and — of course — all of his wonderful translations of early modern texts.";
            Console.WriteLine("Your text is:");
            Console.WriteLine();
            Console.WriteLine(text);

            char[] marks = new char[] { '.', ',', '-', '!', '?', '(', ')', '"', ';', ':' };
            string newText = "";
            string[] tempText = text.Split(marks);

            for (int i = 0; i < tempText.Length; i++)
            {
                newText += tempText[i];
            } text = newText;

            string[] words = text.Split(' ');

            Array.Sort<string>(words);

            Console.WriteLine();
            Console.WriteLine("The words in your text in alphabetical order:");
            Console.WriteLine();

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            } Console.WriteLine();
        }
    }
}
