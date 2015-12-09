using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSESFOLDER
{
    class Program
    {
        static void Main(string[] args)
        {

            CAT CATS = new CAT();
            CATS.Name = "bURZOHOD";
            CATS.Age = 18;
            int count = 1;
            int counter = 1;

            string[] cats = new string[10];

            for (int i = 0; i < cats.Length; i++)
            {
                Console.WriteLine("Please enter name of cat №" + count++);
                cats[i] = Console.ReadLine();

            }
            Console.WriteLine();

            int[] ages = new int[10];

            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine("PLease enter age of cat №" + counter++);
                ages[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < 10; i++)
            {
                CATS.Name = cats[i];
                CATS.Age = ages[i];
                CATS.Say();
            }
        }
    }
}
