using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeworkExceptions
{
    class Program
    {
        static void Main(string[] args)
        { string result = null;
            ReadFile("news.txt");
            WriteFile("result.txt", result);
        }

        static void ReadFile(string filename)
        {
            using (StreamReader read = new StreamReader(filename))
            {
                string text = read.ReadToEnd();

                Console.WriteLine("News of the day ");
                Console.WriteLine();
                Console.WriteLine(text);
                Console.WriteLine();
            }
        }

        static void WriteFile(string filename, string result)
        {
            using (StreamWriter write = new StreamWriter(filename))
            {
                result = "We apologise for the recent downtime to the site.";
                write.Write(result);

                Console.WriteLine(result);
                Console.WriteLine();
            }
        }
    }
}
