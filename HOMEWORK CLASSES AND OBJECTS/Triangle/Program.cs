using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Side A  triangle: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter Side B of a right triangle: ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine();
            Triangle Triangle = new Triangle(a, b);
            Triangle.SideA = a;
            Triangle.SideB = b;
            Triangle.CalculateHypotenuse(a, b);
            Triangle.CalculateAngles(a, b);
            Console.WriteLine();
        }
    }
}
