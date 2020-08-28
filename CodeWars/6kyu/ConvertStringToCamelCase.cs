/*
https://www.codewars.com/kata/517abf86da9663f1d2000003/csharp

6 kyu
Convert string to camel case

Complete the method/function so that it converts dash/underscore delimited words into camel casing. 
The first word within the output should be capitalized only if the original word was capitalized 
(known as Upper Camel Case, also often referred to as Pascal case).

Examples
Kata.ToCamelCase("the-stealth-warrior") // returns "theStealthWarrior"
Kata.ToCamelCase("The_Stealth_Warrior") // returns "TheStealthWarrior"
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class ConvertStringToCamelCase
    {
        public static string ToCamelCase(string str)
        {
            //return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());
            //return Regex.Replace(str, @"(-|_)(\w)", m => m.Value.ToUpper().Substring(1));
            return string.Concat(str.Split('-', '_').Select((x, i) => i > 0 ? char.ToUpper(x[0]) + x[1..] : x));
        }
    }
}