using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace Excersize1 
{

    class Program
    {
       public static void Main(string[] args)
       {

         System.Console.WriteLine("Please enter a sentence:  ");
         var sentenceOriginal = Console.ReadLine();
            
            var sentenceUppercase = sentenceOriginal.ToUpper();
            System.Console.WriteLine(sentenceUppercase);

            var sentenceLowercase = sentenceUppercase.ToLower();
            System.Console.WriteLine(sentenceLowercase);

            var sentenceTrimmed = sentenceLowercase.Trim();
            System.Console.WriteLine(sentenceTrimmed);

            var sentenceExtracted = sentenceTrimmed.IndexOf(' ');
            if(sentenceExtracted != -1)
            {
               var sentenceFirstWordExtracted = sentenceTrimmed.Substring(0 , sentenceExtracted);
               System.Console.WriteLine(sentenceFirstWordExtracted); 
            }
            else
            {
                System.Console.WriteLine(sentenceTrimmed);
            }

            var sentenceReplaced = sentenceTrimmed.Replace("dude", "poop");
            System.Console.WriteLine(sentenceReplaced);


     

       }

        }

    }


