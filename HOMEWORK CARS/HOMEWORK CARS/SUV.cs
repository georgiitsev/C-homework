using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK_CARS
{
    class SUV : Car
    {
        public SUV(decimal price, bool isJeep)
            : base(price)
        {
            this.IsJeep = isJeep;
        }

        public bool IsJeep { get; set; }

        public override string ToString()
        {
            string result = "price is " + this.Price;
            if (IsJeep)
            {
                result += " and I am jeep :D";
            }
            return result;
        }
    }
}
