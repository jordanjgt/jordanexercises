using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Globalization;

namespace Exercise9a
{
    class Program
    {
        private static int Process(string prompt)
        {
            
            bool isValidNumber = false;
            int validNumberInput = 0;
           

            while (!isValidNumber)
            {
            System.Console.WriteLine(prompt);
            string validInput = Console.ReadLine();

            if (string.IsNullOrEmpty(validInput))
            {
                System.Console.WriteLine("No entry detected. Please try your entry again. ");
                continue;
            }

            if (int.TryParse(validInput , out validNumberInput))
            {
                isValidNumber = true;

            }
            else
            {
                System.Console.WriteLine("Not a valid integer or number. Please retype your entry. ");
            }
            }
            
          
            return validNumberInput;


        }
        public static void Main(string [] args)
        {
            int[] numberArray = new int[3];
            
            var numberEntryOne = Process("Please enter the 1st number to convert: ");
            var numberEntryTwo = Process("Please enter the 2nd number to convert: ");
            var numberEntryThree = Process("Please enter the 3rd number to convert: ");
            
            numberArray[0] = numberEntryOne;
            numberArray[1] = numberEntryTwo;
            numberArray[2] = numberEntryThree; 

            System.Console.WriteLine("Here is the original array: ");
            foreach(int numbers in numberArray)
            {
                System.Console.WriteLine(numbers + " ");
            }
            System.Console.WriteLine();

            Array.Reverse(numberArray);
            System.Console.WriteLine("Here is the reversed array: ");
            foreach (int number in numberArray)
            {
                System.Console.WriteLine(number + " ");
            }

            System.Console.WriteLine();




        }
    }
}