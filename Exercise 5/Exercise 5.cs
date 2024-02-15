using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions; 
using System.Globalization;

namespace exercise5
{
    class Program
    {
        private static string Process(string input, bool ToTitleCase = true)
        {
            string processedInput = input.Replace("." , " ").Trim();

            if (ToTitleCase)
            {
                processedInput = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(processedInput);
            }

            return processedInput;

        }
        public static void Main(string [] args)
        {
            var firstName = "";
            var lastName = "";
            var streetAddress = "";
            var city = "";
            var state = "";
            var favFood = "";

            var validFieldFirstName = false;
            var validFieldLastName = false;
            var validFieldStreetAddress = false;
            var validFieldCity = false;
            var validFieldState = false;
            var validFieldFavFood = false;

            while (!validFieldFirstName)
            {
                System.Console.WriteLine("Please Enter Your First Name: ");
                firstName = Process(Console.ReadLine());

                if (!string.IsNullOrEmpty(firstName))
                {
                    validFieldFirstName = true;
                }
                else
                {
                    System.Console.WriteLine("Please Try Again and Complete the First Name Entry.");
                }
            }

            while (!validFieldLastName)
            {
                System.Console.WriteLine("Please Enter Your Last Name: ");
                lastName = Process(Console.ReadLine()); 

                if (!string.IsNullOrEmpty(lastName))
                {
                    validFieldLastName = true;
                }
                else
                {
                    System.Console.WriteLine("Please Try Again and Complete the Last Name Entry. ");
                }
            }

            while (!validFieldStreetAddress)
            {
            System.Console.WriteLine("Please Enter Your Street Address: ");
            streetAddress = Process(Console.ReadLine());

            if (!string.IsNullOrEmpty(streetAddress))
            {
                validFieldStreetAddress = true;
            }
            else
            {
                System.Console.WriteLine("Please Try Again and Complete the Street Address. ");
            }
            }

            while (!validFieldCity)
            {
               System.Console.WriteLine("Please Enter Your City: ");
                city = Process(Console.ReadLine());

                if (!string.IsNullOrEmpty(city))
                {
                    validFieldCity = true;
                }
                else
                {
                    System.Console.WriteLine("Please Try Again and Complete the City. ");
                }             
            }

            while (!validFieldState)
            {
            System.Console.WriteLine("Please Enter Your State: ");
            state = Process(Console.ReadLine());


            if (!string.IsNullOrEmpty(state))
            {
               validFieldState = true; 
            }
            else
            {
                System.Console.WriteLine("Please Try Again and Complete the State");
            }
            }

            while (!validFieldFavFood)
            {
            System.Console.WriteLine("Please Type Your Favorite Food. E.g. 'pasta': ");
            favFood = Process(Console.ReadLine(), false).ToLower();

            if (!string.IsNullOrEmpty(favFood))
            {
                validFieldFavFood = true;
            }
            else
            {
                System.Console.WriteLine("Please Try Again and Complete your Favorite Food. ");
            }
            }

            var customSentence = $"A bright person by the name of {firstName} {lastName} took a walk to their home at {streetAddress}, located in {city}, {state}. You may ask why? To eat {favFood}.";
            System.Console.WriteLine(customSentence);

            var customSentenceB = String.Format("A bright person by the name of {0} {1} took a walk to their home at {2}, located in {3}, {4}. You may ask why? To eat {5}." , firstName,lastName,streetAddress,city,state,favFood);
            System.Console.WriteLine(customSentenceB);






        }
    }
}