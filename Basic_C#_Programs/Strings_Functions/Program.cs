using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Dinber";
            //    string quote = "The man said, \"Hello\", Dinber. \n Hello on a new line . \n \t Hello on a tab.";

            //    bool trueOrFalse = name.Contains("s");
            //    trueOrFalse = name.EndsWith("s");

            //    int  length = name.Length;

            //    name = name.ToUpper();

            //    name = name.ToLower();

            //    Console.WriteLine(name);
            //    Console.ReadLine();


            //StringBuilder sb = new StringBuilder();

            //sb.Append("My name is Dinber");

            // ------------ CONCATENATING THREE STRINGS -------
            string part1 = "C# is "; // First part of the sentence
            string part2 = "a powerful "; // Second part of the sentence
            string part3 = "programming language. "; // Third part of the sentence

            // Combine all three strings into one
            string fullSentence = part1 + part2 + part3;

            // Display the concatenated string
            Console.WriteLine("Concatenated string: " + fullSentence);

            Console.WriteLine();

            // ------- CONVERT STRING TO UPPERCASE -------
            // Convert the concatenated string  to uppercase
            string upperCaseSentence = fullSentence.ToUpper();

            // Display the uppercase version
            Console.WriteLine("Uppercase string: " + upperCaseSentence);

            Console.WriteLine();

            // ---------- USING STRINGBUILDER TO BUILD A PARAGRAGPH -----------
            // Create a StringBuilder object

            StringBuilder paragraphBuilder = new StringBuilder();

            // Append sentences one at a time
            paragraphBuilder.Append("C# is widely used for developing desktop and web applications. ");
            paragraphBuilder.Append("It supports object-oriented programming principles. ");
            paragraphBuilder.Append("Using StringBuilder is more efficient than using regular strings. ");

            // Display the paragrpah
            Console.WriteLine("Paragraph built with StringBuilder:");
            Console.WriteLine(paragraphBuilder.ToString());


            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey(); 
        }
    }
}