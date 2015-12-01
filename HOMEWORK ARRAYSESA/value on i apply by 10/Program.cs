using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace value_on_i_apply_by_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 10;
                
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
