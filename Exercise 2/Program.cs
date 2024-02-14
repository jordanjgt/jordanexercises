using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;


namespace Exercise2
{
    class Program
    {
        public static void Main(string [] args)
        {
            string sentenceA = "";
            string searchTerm = "";
         
            var sentenceIsValid = false;
            while (sentenceA = )
            {
                System.Console.WriteLine("Please enter a sentence: ");
                sentenceA = Console.ReadLine();

                if (string.IsNullOrEmpty(sentenceA))
                {
                    sentenceIsValid = true;
                }
                else
                {
                    System.Console.WriteLine("Pretty Please Retry Your Response Sir ");
                }
            }
                var searchtermIsValid = false;
                while (searchtermIsValid == true)
            {
                System.Console.WriteLine("Please enter your search term: ");
                searchTerm = Console.ReadLine(); 

                if (string.IsNullOrEmpty(searchTerm))
                {
                    searchtermIsValid = true;
                }
                else
                {
                    System.Console.WriteLine("Pretty Please Retry Your Response Sir ");
                }
            }
  

            var firstOccurance = sentenceA.IndexOf(searchTerm);
            System.Console.WriteLine(firstOccurance);

            var lastOccurance = sentenceA.LastIndexOf(searchTerm);
            System.Console.WriteLine(lastOccurance);


        }
    }
}

