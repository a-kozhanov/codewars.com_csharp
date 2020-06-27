/*
https://www.codewars.com/kata/59727ff285281a44e3000011/csharp

7 kyu
Band name generator

My friend wants a new band name for her band. 
She like bands that use the formula: "The" + a noun with the first letter capitalized, for example:

"dolphin" -> "The Dolphin"

However, when a noun STARTS and ENDS with the same letter, 
she likes to repeat the noun twice and connect them together with the first and last letter, 
combined into one word (WITHOUT "The" in front), like this:

"alaska" -> "Alaskalaska"

Complete the function that takes a noun as a string, and returns her preferred band name written as a string.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class KataBandNameGenerator
    {
        public static string BandNameGenerator(string str)
        {
            //Console.WriteLine($"{char.ToLower(str.First())}; {char.ToLower(str.Last())}");

            // if (char.ToLower(str.First()) != char.ToLower(str.Last()))
            // {
            //     //return $"The {char.ToUpper(str[0])}{str[1..]}";
            //     return $"The {char.ToUpper(str[0]) + str[1..]}";
            // }
            // else
            // {
            //     return $"{char.ToUpper(str[0])}{str[1..]}{str[1..]}";
            // }

            
            //var name = char.ToUpper(str[0]) + str.Substring(1);
            //return str.First() != str.Last() ? $"The {char.ToUpper(str[0]) + str[1..]}" : $"{char.ToUpper(str[0])}{str[1..]}{str[1..]}";
            //return str.First() != str.Last() ? $"The {char.ToUpper(str[0]) + str[1..]}" : char.ToUpper(str[0]) + str[1..] + str[1..];
            //return (str[0] != str[^1] ? $"The {char.ToUpper(str[0])}" : char.ToUpper(str[0]) + str[1..]) + str[1..];
            return (str[0] != str[^1] ? $"The {char.ToUpper(str[0])}" : char.ToUpper(str[0]) + str[1..]) + str[1..];

        }
    }
}