using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1StudioArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            double area;
            double r;
            string input;

            Console.WriteLine("Let's calculate the area of a circle\n\nPlease enter the radius:");
            input = Console.ReadLine();
            r = int.Parse(input);

            while (r < 0)
            {
                Console.WriteLine("A circle can't have a negative radius. Please enter a positive number:");
                input = Console.ReadLine();
                r = double.Parse(input);
            }

            area = pi * Math.Pow(r,2);

            Console.WriteLine("The area of a circle with a radius of " + r + " is " + area);
            Console.ReadLine();

        }
    }
}
