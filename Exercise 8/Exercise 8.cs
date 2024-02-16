using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Exercise8
{
    class Program
    {
        private static string Process(string prompt)
        {

            System.Console.WriteLine(prompt);
            string validInput = Console.ReadLine();

            while (string.IsNullOrEmpty(validInput))
            {
          
                    System.Console.WriteLine("No word detected. Please type a word.");
                    validInput = Console.ReadLine();
               
            }
            return validInput;
          
        }
        public static void Main(string [] args)
        {
        
        var word1 = Process("Please enter the 1st word to join together: ");
        var word2 = Process("Please enter the 2nd word to join together: ");
        var word3 = Process("Please enter the 3rd word to join together: ");
        var word4 = Process("Please enter the 4th word to join together: ");

        string[] words = {word1 , word2 , word3 , word4};
        var wordsCombined = String.Join(" " , words);

        System.Console.WriteLine(wordsCombined);
        }
    }
}
