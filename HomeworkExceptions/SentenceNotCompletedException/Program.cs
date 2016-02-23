using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SentenceNotCompletedExceptionTask2
{
    class Program
    {
        static void Main(string[] args)
        {
             try
            {
                using (StreamReader text = new StreamReader("text.txt"))
                {
                    int lineNumber = 0;
                    bool symbol = false;
                    string line = text.ReadLine();

                    while (line != null)
                    {
                        lineNumber++;

                        if (line.LastIndexOf('.') == line.Length - 1)
                        {
                            symbol = true;
                            line = text.ReadLine();
                            continue;
                        }
                        else if (line.LastIndexOf('?') == line.Length - 1)
                        {
                            symbol = true;
                            line = text.ReadLine();
                            continue;
                        }
                        else if (line.LastIndexOf('!') == line.Length - 1)
                        {
                            symbol = true;
                            line = text.ReadLine();
                            continue;
                        }
                        else
                        {
                            symbol = false;
                            break;
                        }
                    }

                    if (symbol == true)
                    {
                        Console.WriteLine("No mistakes found!");
                    }
                    else
                    {
                        throw new SentenceNotCompletedException();
                    }
                }
            }
            catch (SentenceNotCompletedException)
            {
                Console.WriteLine("There is something missing in your text! Check punctoation marks!");
                Console.WriteLine();
            }
            finally
            {
                Console.WriteLine("Your text has been checked succefully!");
                Console.WriteLine();
            }
        }
    }
}
