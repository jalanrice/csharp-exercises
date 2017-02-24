using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("What is your name?:");
            name = Console.ReadLine();

            Console.WriteLine("Greetings, " + name);
            Console.ReadLine();


        }
    }
}
