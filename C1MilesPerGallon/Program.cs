using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles;
            int gas;
            int mpg;
            string input;

            Console.WriteLine("How many miles have you driven?:");
            input = Console.ReadLine();
            miles = int.Parse(input);

            Console.WriteLine("How many gallons of gas did that take?:");
            input = Console.ReadLine();
            gas = int.Parse(input);

            mpg = miles / gas;

            Console.WriteLine("Your car got " + mpg + " miles-per-gallon.");
            Console.ReadLine();

        }
    }
}
