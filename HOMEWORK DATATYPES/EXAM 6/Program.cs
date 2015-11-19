using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facing_of_triangle

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first side of triangle ");
            int firstSide = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter other side of triangle ");
            int secondSide = int.Parse(Console.ReadLine());
            int facingOnTriangle = firstSide*secondSide/2;
            Console.Write("The face of triangle is :  ");
            Console.WriteLine(facingOnTriangle);
        }
    }
}
