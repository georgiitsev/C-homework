using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farentheit
{
    class ConverDegrees
    {
        public double Degrees { get; set; }
       
        internal void ConvertFarentheit(double celcie, double farentheit)
        {
            farentheit = (celcie * 1.8) + 32;
            Console.WriteLine("{0}°C is equal to {1}°F",celcie,farentheit);
        }
    }
}
