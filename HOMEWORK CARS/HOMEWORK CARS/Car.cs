using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK_CARS
{
    class Car
    {
        public Car(decimal price)
        {
            this.Price = price;
        }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return "price is " + this.Price;
        }
    }
}
