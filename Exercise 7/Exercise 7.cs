using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace Exercise7
{
    class Program
    {
        private static string Process(string input , bool processA = true)
        {
            string processedInput = "";
            if (processA)
            {
                processedInput = input.Replace("."," ").Replace(". ", " ").Replace("'" , " ").Trim().ToLower();
            }
            return processedInput;
        }
        public static void Main(string [] args)
        {
            var sentence = "";
            var searchPhrase = "";
            var searchCharacters = "";

            
            var sentenceInputIsValid = false;
            var searchPhraseIsValid = false;
            var searchCharactersIsValid = false;

            while (!sentenceInputIsValid)
            {
                System.Console.WriteLine("Please input a sentence or phrase: ");
                sentence = Process(Console.ReadLine());

              if (!string.IsNullOrEmpty(sentence))
              {
                sentenceInputIsValid = true;
              }  
              else
              {
                System.Console.WriteLine("Sentence cannot be blank, please try again.");
              }
                

            }

            while (!searchPhraseIsValid)
            {
                System.Console.WriteLine("Please input a phrase to search in the sentence: ");
                searchPhrase = Process(Console.ReadLine());

                if (!string.IsNullOrEmpty(searchPhrase))
                {
                    searchPhraseIsValid = true;
                }
                else
                {
                    System.Console.WriteLine("The search phrase cannot be blank, please try again.");
                }

            }
            
            while (!searchCharactersIsValid)
            {
                System.Console.WriteLine("Please input the characters you would like to search for: ");
                searchCharacters = Process(Console.ReadLine());

                if (!string.IsNullOrEmpty(searchCharacters))
                {
                    searchCharactersIsValid = true;
                }
                else
                {
                    System.Console.WriteLine("The characters for searching cannot be blank, please try again");
                }
            }
            int searchPhraseTotal = Regex.Matches(sentence , searchPhrase).Count;
            int charactersTotal = Regex.Matches(sentence, searchCharacters).Count;
            bool searchPhrasePresent = sentence.Contains(searchPhrase);
            bool characterIsPresent = sentence.StartsWith(searchCharacters);

            if (searchPhrasePresent)
            {
                System.Console.WriteLine("Your Phrase " + "'" + searchPhrase + "'" + " was found " + searchPhraseTotal + " time(s).");
            }
            else
            {
                System.Console.WriteLine("Your Phrase was not found. Please try again.");
            }

            if (characterIsPresent)
            {
                System.Console.WriteLine("Your Search Characters " + "'" + searchCharacters + "'" + " were found " + charactersTotal + " time(s).");
            }
            else
            {
                System.Console.WriteLine("Your Search Characters were not found. Please try again.");
            }
            

        }
    }
}