using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPIRALMATRIX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLease enter size of matrix ");
            int size = int.Parse(Console.ReadLine());
            string direction = "right";
            int rotation = size * size;
            int row = 0;
            int cow = 0;

            int[,] matrix = new int[size, size];

            for (int i = 1; i <= rotation; i++)
            {
               
                {
                    if (direction == "right" && (cow > size - 1 || matrix[cow,row] != 0  ))
                    {
                        direction = "down";
                        row++;
                        cow--;
                        
                    }
                    if (direction == "down" && (row > size - 1 || matrix[cow, row] != 0))
                    {
                        direction = "left";
                        row--;
                        cow--;
                        
                    }
                    if (direction == "left" && (cow < 0 || matrix[cow, row] != 0))
                    {
                        direction = "up";
                        row--;
                        cow++;
                        
                    }
                    if (direction == "up" && (row < 0 || matrix[cow, row] != 0))
                    {
                        direction = "right";
                        row++;
                        cow++;
                        
                    }
                    matrix[cow, row] = i;

                    if (direction == "right")
                    {
                        cow++;
                    }
                    if (direction == "down")
                    {
                        row++;
                        
                        
                    }
                    if (direction == "left")
                    {
                        cow --;
                        
                    }
                    if (direction == "up" )
                    {
                        row--;
                    }
                    
                }
                
            }
            Console.WriteLine("The Spiral Matrix is:");

            for (int k = 0; k < size; k++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[j, k] + " ");
                } Console.WriteLine();
            } 
        }
    }
}
