using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[6] { 1, 1, 2, 3, 5, 8 };
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(values[i]);
                     
            }
            Console.ReadLine();
        }
    }
}
