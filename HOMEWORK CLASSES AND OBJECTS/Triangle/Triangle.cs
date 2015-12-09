using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        public float SideA { get; set; }
        public float SideB { get; set; }
        public Triangle(float SideA,float SideB)
        {
            this.SideA = SideA;
            this.SideB = SideB;
        }
        public void CalculateHypotenuse(double SideA, double SideB)
        {
            double tempHypotenuse = 0;
            double Hypotenuse = tempHypotenuse * tempHypotenuse;

            Hypotenuse = (SideA * SideA) + (SideB * SideB);
            tempHypotenuse = Math.Sqrt(Hypotenuse);

            float hypotenuse = Convert.ToSingle(tempHypotenuse);
            Console.WriteLine("The hypotenuse of the right triangle is: {0} cm.", hypotenuse);
        }

        public void CalculateAngles(double SideA, double SideB)
        {
            double tempHypotenuse = 0;
            double Hypotenuse = tempHypotenuse * tempHypotenuse;

            Hypotenuse = (SideA * SideA) + (SideB * SideB);
            tempHypotenuse = Math.Sqrt(Hypotenuse);

            float hypotenuse =(float) tempHypotenuse;
            double tempAngle1 = Math.Atan(SideA / SideB) * (180 / Math.PI);
            double tempAngle2 = Math.Atan(SideA / SideB) * (180 / Math.PI);
            tempAngle1 = Math.Asin(SideA / hypotenuse) * (180 / Math.PI);
            tempAngle2 = Math.Asin(SideB / hypotenuse) * (180 / Math.PI);

            int angle1 =(int) tempAngle1;
            int angle2 = (int)tempAngle2;
            Console.WriteLine("The right triangle has two acute angles with degrees: {0} and {1}", angle1, angle2);
        }
    }
}
