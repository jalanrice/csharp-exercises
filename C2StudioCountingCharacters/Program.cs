using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace C2StudioCountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text: ");
            string text = Console.ReadLine().ToLower();
            ConcurrentDictionary<char, int> alphaCount = new ConcurrentDictionary<char, int>();
            //Dictionary<char, int> alphaCount = new Dictionary<char, int>();
            int currentCount;
                       
            foreach(char c in text)
            {
                if (Char.IsLower(c))
                {
                    //alphaCount.TryGetValue(c, out currentCount);
                    //alphaCount[c] = currentCount + 1;
                    alphaCount.AddOrUpdate(c, 1, (oldKey, oldValue) => oldValue + 1);
                }
               
            }

            SortedDictionary<char, int> alphaCountSorted = new SortedDictionary<char, int>(alphaCount);
            StringBuilder alphaCountString = new StringBuilder();

            foreach (KeyValuePair<char, int> alpha in alphaCountSorted)
            {
                alphaCountString.Append(alpha.Key + ": " + alpha.Value.ToString() + "\n");
                //Console.WriteLine(alpha.Key + ": " + alpha.Value);
            }
            Console.WriteLine(alphaCountString);
            Console.ReadLine();
        }
    }
}


