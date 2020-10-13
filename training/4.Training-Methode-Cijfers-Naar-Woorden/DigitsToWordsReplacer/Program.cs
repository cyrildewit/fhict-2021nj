using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace DigitsToWordsReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] digitsWithWords = new string[] {
                "nul",
                "een",
                "twee",
                "drie",
                "vier",
                "vijf",
                "zes",
                "zeven",
                "acht",
                "negen"
            };

            Console.WriteLine("Voer een zin in:");

            string sentence = Console.ReadLine();

            for (int i = 0; i < digitsWithWords.Length; i++)
            {
                sentence = sentence.Replace(i.ToString(), digitsWithWords[i]);
            }

            Console.WriteLine("Resultaat: " + string.Join("", sentence));
        }

        /*
         * Old Main function
         */
        /*static void Main(string[] args)
        {
            var digitsWithWords = new Dictionary<char, string>() {
                { '0', "nul" },
                { '1', "een" },
                { '2', "twee" },
                { '3', "drie" },
                { '4', "vier" },
                { '5', "vijf" },
                { '6', "zes" },
                { '7', "zeven" },
                { '8', "acht" },
                { '9', "9" },
            };

            Console.WriteLine("Voer een zin in:");

            string sentence = Console.ReadLine();

            char[] characters = sentence.ToCharArray();
            string[] updatedCharacters = new string[characters.Length];

            for (int i = 0; i < characters.Length; i++)
            {
                string updatedChar = characters[i].ToString();

                if (digitsWithWords.ContainsKey(characters[i]))
                {
                    updatedChar = digitsWithWords[characters[i]];
                }

                updatedCharacters[i] = updatedChar;
            }

            Console.WriteLine("Resultaat: " + string.Join("", updatedCharacters));
        }*/
    }
}
