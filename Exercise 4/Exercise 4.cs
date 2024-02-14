using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace exercise4
{
    class Program
    {
        public static void Main(string [] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            var sentenceA = "";
            var sentenceIsValid = false;
            while (!sentenceIsValid)
            {
            System.Console.WriteLine("Please enter a sentence: ");
            sentenceA = Console.ReadLine().Trim();
            if (!string.IsNullOrEmpty(sentenceA))
            {
                sentenceIsValid = true;
            }
            else
            {
                System.Console.WriteLine("Please complete a sentence in the area given.");
            }

            }
            

            

            stringBuilder.Append("<p>");
            stringBuilder.Append(sentenceA);
            stringBuilder.Append("</p>");

            System.Console.WriteLine(stringBuilder.ToString());
        }
    }
}