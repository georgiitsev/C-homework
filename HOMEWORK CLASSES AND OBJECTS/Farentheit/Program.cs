using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farentheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some value for celcie and i tell you how much is in Farentheit ");
            double celcie = double.Parse(Console.ReadLine());
            double farentheit = 0;


            ConverDegrees degrees = new ConverDegrees();
            degrees.Degrees = celcie;
            degrees.ConvertFarentheit(celcie, farentheit);
        }

       
    }
}
