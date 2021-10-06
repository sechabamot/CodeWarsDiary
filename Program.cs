using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWarsDiary
{
    class Program
    {
        static void Main(string[] args)
        {
           string value =  Challange_3.RunSolution("abcdef");
        }
    }

    /// <summary>
    /// Convert string to camel case.
    /// Complete the method/function so that it converts dash/underscore delimited words into camel casing. 
    /// The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case).
    /// Ex:"the-stealth-warrior" gets converted to "theStealthWarrior"
    /// </summary>
    static class Challange_1
    {
        //Ny solution
        public static string RunSolution(string str)
        {
            string formatedString = "";

            char[] characters = str.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                string character = characters[i].ToString();
                if (character.Equals("_") || character.Equals("-"))
                {
                    string upperCaseCharacter = characters[i + 1].ToString().ToUpper();
                    formatedString += upperCaseCharacter;
                    i++;
                }
                else
                {
                    string normalCharacter = characters[i].ToString();
                    formatedString += normalCharacter;
                }
            }

            return formatedString;
        }

        //Better solution i fouund
        public static string RunBetterSolution(string str)
        {
            return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());
        }

    }

    /// <summary>
    /// Your task is to make a function that can take any non-negative integer as an argument and return it with its digits in descending order. Essentially, rearrange the digits to create the highest possible number.
    /// Ex: Input: 123456789 Output: 987654321
    /// </summary>
    static class Challange_2
    {
        public static int RunSolution()
        {
            
            List<int> s = new List<int>() { };
            try
            {
                if (8 % 2 == 0)
                {

                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return 0;
        }
    }

    /// <summary>
    /// In this kata you are required to, given a string, replace every letter with its position in the alphabet.
    /// If anything in the text isn't a letter, ignore it and don't return it.
    /// </summary>
    static class Challange_3
    {
        public static string RunSolution(string input)
        {
            List<char> alphabets = (Enumerable.Range('A', 26)).Select(x => (char)x).ToArray().ToList();
            List<string> sequence = new List<string>() { };

            foreach (char c in input.ToUpper())
            {
                if (alphabets.Contains(c))
                {
                    sequence.Add($"{alphabets.IndexOf(c) + 1}");
                }
            }

            return sequence.Count > 0 ? 
                Enumerable.Aggregate(sequence, (a, b) => a + " " + b) : "";
        }
        public static string RunBetterSolution(string text)
        {
            return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
        }

    }
}
