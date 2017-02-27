using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string mystring = string.Format("{1} = {1}", "first", "second");
            //string myString = string.Format("{0:C}", 123.45); currency
            //string myString = string.Format("{0:N}", 1234567890); display as number
            //string myString = string.Format("{0:(###) ###-####}", 1234567890); custom string format for phone #
            //string myString = " That summer we took threes across the board    ";
            ////myString = myString.Substring(1,20);
            //myString = myString.Replace(" ", "-");

            StringBuilder myString = new StringBuilder(); //can use .Append() instead of .ToString() to add all at once instead of 1 at a time, better for memory





            Console.WriteLine(myString);
            Console.ReadLine();

        }
    }
}
