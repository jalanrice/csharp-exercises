using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2ListsAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string> {"test", "tests", " ", "three", "four", "one" };

            foreach (string word in words)
            {
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                }                
            }
            Console.ReadLine();
        }
    }
}
