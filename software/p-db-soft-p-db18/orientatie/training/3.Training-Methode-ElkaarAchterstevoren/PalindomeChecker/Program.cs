using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Elkaars Achtersevoren **");
            Console.WriteLine("** ----------------- **");
            Console.WriteLine("hello en olleh: " + CheckEachOtherBackwards("anna", "anna"));
            Console.WriteLine("mother en rehtom: " + CheckEachOtherBackwards("repaper", "repaper"));
            Console.WriteLine("eachother en rehtohcae: " + CheckEachOtherBackwards("malayalam", "malayalam"));
            Console.WriteLine("** ----------------- **");
            Console.WriteLine("");

            Console.WriteLine("** Palindrome Checker **");
            Console.WriteLine("** ----------------- **"); 
            Console.WriteLine("Doc: note, I dissent. A fast never prevents a fatness. I diet on cod.: " + CheckPalindrome("Doc: note, I dissent. A fast never prevents a fatness. I diet on cod."));
            Console.WriteLine("Able was I ere I saw Elba: " + CheckPalindrome("Able was I ere I saw Elba"));
        }

        private static bool CheckEachOtherBackwards(string a, string b)
        {
            return a == ReverseString(b);
        }

        private static bool CheckPalindrome(string value)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9-]");
            string original = rgx.Replace(value.ToLower(), "");
            string reversed = ReverseString(original);

            return original == reversed;
        }

        private static string ReverseString(string value)
        {
            char[] characters = value.ToCharArray();

            Array.Reverse(characters);

            return new string(characters);
        }
    }
}
