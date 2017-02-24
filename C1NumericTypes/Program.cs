using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            int width;
            int area;
            string input;

            Console.WriteLine("We're going to calculate the area of a rectangle.\nHow many inches is the longest side?:");
            input = Console.ReadLine();
            length = int.Parse(input);

            Console.WriteLine("How many inches wide?:");
            input = Console.ReadLine();
            width = int.Parse(input);

            area = length * width;

            Console.WriteLine("The area of the rectangle is " + area + " square inches.");
            Console.ReadLine();

        }
    }
}
