using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Variables
{
    class SequenceSearch
    {
       public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string: ");
            string inputString = Console.ReadLine();
            
            System.Console.WriteLine("Do you want a case sensative search?: ");
            char inputCase = Console.ReadKey().KeyChar;
            System.Console.WriteLine();
            bool inputCase1 = inputCase == 'y' || inputCase == 'Y';

            System.Console.WriteLine("Enter a sequence to count: ");
            string inputSequence = Console.ReadLine();

            if (!inputCase1)
            {
                inputString = inputString.ToLower();
                inputSequence = inputSequence.ToLower();
            }

            int count = Regex.Matches(inputString, Regex.Escape(inputSequence)).Count;

            System.Console.WriteLine($"In the string '{inputString}', the sequence '{inputSequence}' occurs {count} time(s)");
        }
    }
    
    }
