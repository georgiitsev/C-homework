using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK_CARS
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobile[] automobiles = new Automobile[5]
            {
                new Automobile(200, 100),
                new Automobile(300, 90),
                new Automobile(400, 80),
                new Automobile(500, 70),
                new Automobile(600, 60),
            };

            SUV[] suvs = new SUV[5]
            {
                 new SUV(1000, false), 
                 new SUV(2000, true), 
                 new SUV(3000, false), 
                 new SUV(4000, true), 
                 new SUV(5000, true), 
            };

            for (int i = 0; i < automobiles.Length; i++)
            {
                Console.WriteLine(automobiles[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < suvs.Length; i++)
            {
                Console.WriteLine(suvs[i]);
            }
        }
    }
}
