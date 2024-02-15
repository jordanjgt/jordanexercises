using System; 
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercise6
{
    class Program
    {
      
        public static void Main(string [] args)
        {
            var numberA = "";

            var validNumberInput = false;

            while (!validNumberInput)
            {
                
            System.Console.WriteLine("Please enter a number for parsing: ");
            numberA = Console.ReadLine();

            if (!string.IsNullOrEmpty(numberA))
            {
                validNumberInput = true;
            }
            else
            {
                System.Console.WriteLine("Error, no number entered. Try again.");
            }


            }

            int numberAInt; 
            bool isNumber = int.TryParse(numberA , out numberAInt);
            if (isNumber)
            {
                System.Console.WriteLine("Integer Part: " + numberAInt);
            }
            else
            {
                System.Console.WriteLine("Could not parse the input as an integer. Please try again.");
            }
            
            double numberADouble;
            bool isDouble = double.TryParse(numberA , out numberADouble);
            if (isDouble)
            {
                System.Console.WriteLine("Double Part: " + numberADouble);
            }
            else
            {
                System.Console.WriteLine("Could not parse the input as a double. Please try again.");
            }



        }
    }
}
