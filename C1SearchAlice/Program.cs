using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1SearchAlice
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "Alice was beginning to get very tired of sitting by her sister on the bank, " + 
                            "and of having nothing to do: once or twice she had peeped into " + 
                            "the book her sister was reading, but it had no pictures or conversations " + 
                            "in it, 'and what is the use of a book,' thought Alice 'without pictures " +
                            "or conversation?'";
            string lowerQuote = quote.ToLower();
            string search;
            string lowerSearch;
            int found;

            Console.WriteLine(quote + "\n\nEnter a phrase to search for in the first sentence from Alice in Wonderland:");

            search = Console.ReadLine();
            lowerSearch = search.ToLower();

            found = lowerQuote.IndexOf(lowerSearch);
            if (found == -1)
            {
                Console.WriteLine("false");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("true");
                Console.ReadLine();
            }
        }
    }
}
