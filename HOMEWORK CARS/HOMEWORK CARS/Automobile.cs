using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK_CARS
{
    class Automobile : Car
    {
        public Automobile(decimal price, double fuelConsumption)
            : base(price)
        {
            this.FuelConsumption = fuelConsumption;
        }
        public double FuelConsumption { get; set; }

        public override string ToString()
        {
            return "Price is " + this.Price + " with fuel consumption " + this.FuelConsumption;
        }
    }
}
