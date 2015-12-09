using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSESFOLDER
{
    class CAT
    {

        public int Age { get; set; }
        public string Name { get; set; }

        public CAT()
        { 
        }

        public void Say()
        {
            Console.WriteLine("Name of cat is {0} an she is {1} years old",Name,Age);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("-------------------------------------------");

        }
    }
}
