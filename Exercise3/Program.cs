using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace exercise3
{
    class Program
    {
        public static void Main(string [] args)
        {
            string sentenceA = "";
            var sentenceIsValid = false;
            while (!sentenceIsValid)
            {
                System.Console.WriteLine("Please Enter A Sentence: ");
                sentenceA = Console.ReadLine();
                if (!string.IsNullOrEmpty(sentenceA))
                {
                    sentenceIsValid = true;
                }
                else
                {
                    System.Console.WriteLine("Make sure that you complete a sentence!");
                }
            }
        
           
           var sentenceACleaned = sentenceA.Replace(". "," ").Replace(",", " ").Replace(".", " ").Replace("!", " ").Replace("?" , " ").Replace("-" , " ").Replace(";" , " ").Trim();


           string[] individualWords = sentenceACleaned.Split(" ", StringSplitOptions.RemoveEmptyEntries);
           foreach (var word in individualWords)
           {

            System.Console.WriteLine(word);
     
           }
           
           var numberOfWords = individualWords.Length;
           System.Console.WriteLine("The number of words in this sentence is: " + numberOfWords);
           


        }
    }
}
