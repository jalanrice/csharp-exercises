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

            //Console.WriteLine("Let's calculate the area of a circle\n\nPlease enter the radius:");
            //r = double.Parse(Console.ReadLine());

            //while (r < 0)
            //{
            //    Console.WriteLine("A circle can't have a negative radius. Please enter a positive number:");
            //    r = double.Parse(Console.ReadLine());
            //}

            //area = pi * Math.Pow(r, 2);

            //Console.WriteLine("The area of a circle with a radius of " + r + " is " + area);
            //Console.ReadLine();


            string input = "";
            do
            {
                Console.Write("Let's calculate the area of a circle\n\nPlease enter the radius: ");
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && (double.Parse(input) >= 0))
                {
                    r = double.Parse(input);

                    area = pi * Math.Pow(r, 2);

                    Console.WriteLine("The area of a circle with a radius of " + r + " is " + area);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Input can't be empty or negative.");
                }
            } while (string.IsNullOrEmpty(input) || (double.Parse(input) < 0));


        }
    }
}
