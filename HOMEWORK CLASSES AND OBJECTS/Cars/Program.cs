using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Price = 18000;
            car.Brand = "Skoda";


            Automobile automobile = new Automobile();
            automobile.Price = 38000;
            automobile.FullConsumation = 15;

            SUV jeep = new SUV();
            jeep.Price = 50000;
            jeep.IsHighly = true;

            string[] carBrand = new string[10];

            for (int i = 0; i < carBrand.Length; i++)
            {
                if ( i >= 0 && i <= 4)
                {
                    Console.WriteLine("Please enter the car brand ");
                    carBrand[i] = Console.ReadLine();
                    
                }

                else if (i >= 5 && i <= 10)
                {
                    Console.WriteLine("Plaese enter the SUV brand ");
                    carBrand[i] = Console.ReadLine();
                }
                
                
            }
            int[] carPrice = new int [10];
            

            for (int i = 0; i <carPrice.Length; i++)
            {
                if (i >= 0 && i <= 4)
                {
                    Console.WriteLine("Please enter the price of car ");
                   carPrice[i] =int.Parse( Console.ReadLine());

                }
                else if (i >= 5 && i <= 10)
                {
                    Console.WriteLine("Please enter the price of SUV ");
                    carPrice[i] = int.Parse(Console.ReadLine());
                }
            }
            bool[] highly = new bool[10];

            for (int i = 0; i < highly.Length; i++)
            {
                if (i >= 0 && i <= 4)
                {
                    highly[i] = false;
                }
                else
                {
                    highly[i] = true;
                }
            }
            Car[] carses = new Car[5];
            SUV test = new SUV();
            
            
            for (int i = 0; i <10; i++)
            {
                Car Information = new Car();
                Information.Price = carPrice[i];
                jeep.IsHighly = highly[i];
                Console.Write("BRAND " + carBrand[i]);
                Console.Write(" PRICE " + Information.Price);
                Console.Write(" IS HIGHLY = " + jeep.IsHighly);
                Console.WriteLine();
                
            }
        }
    }
}
