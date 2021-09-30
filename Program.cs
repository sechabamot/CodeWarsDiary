using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsDiary
{
    class Program
    {
        static void Main(string[] args)
        {

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
        public static string Test(string str)
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
    }

    static class Challange_2
    {

    }
}
