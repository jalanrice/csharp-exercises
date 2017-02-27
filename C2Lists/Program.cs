using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2Lists
{
    class Program
    {
        private static int EvenSummer(List<int> theList)
        {
            int listSum = 0;

            for (int i = 0; i <= theList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    listSum += i;
                }                     
            }
            return listSum;            
        }
        

        static void Main(string[] args)
        {
            List<int> theList = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(EvenSummer(theList));
            Console.ReadLine();

        }
    }
}
