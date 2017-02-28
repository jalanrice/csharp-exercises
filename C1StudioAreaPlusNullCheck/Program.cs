using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1StudioAreaPlusNullCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            double area;
            double r;

            Console.WriteLine("Let's calculate the area of a circle\n\nPlease enter the radius:");
            r = double.Parse(Console.ReadLine());

            while (r < 0)
            {
                Console.WriteLine("A circle can't have a negative radius. Please enter a positive number:");
                r = double.Parse(Console.ReadLine());
            }

            area = pi * Math.Pow(r, 2);

            Console.WriteLine("The area of a circle with a radius of " + r + " is " + area);
            Console.ReadLine();
        }
    }
}
