/*
https://www.codewars.com/kata/5889177bf148eddd150002cc/csharp

7 kyu
TIY-FizzBuzz

In this exercise, you will have to create a function named tiyFizzBuzz. 
This function will take on a string parameter and will return that string with some characters replaced, depending on the value:

If a letter is a upper case consonants, replace that character with "Iron".
If a letter is a lower case consonants or a non-alpha character, do nothing to that character
If a letter is a upper case vowel, replace that character with "Iron Yard".
If a letter is a lower case vowel, replace that character with "Yard".
Ready?
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class TIYFizzBuzz
    {
        public static string FizzBuzz(string sentence)
        {
            // return string.Concat(sentence.Select(c => "AEIOU".Contains(c) ? "Iron Yard" :
            //     "aeiou".Contains(c) ? "Yard" :
            //     "BCDFGHJKLMNPQRSTVWXYZ".Contains(c) ? "Iron" :
            //     c.ToString()));


            // return string.Concat(sentence.Select(x => "euioaEUIOA".Contains(x) ? char.IsUpper(x) ? "Iron Yard" :
            //     "Yard" :
            //     char.IsUpper(x) ? "Iron" : x.ToString()));


            return Regex.Replace(sentence, "([BCDFGHJKLMNPQRSTVWXYZ])|([aeiou])|([AEIOU])",
                m => m.Groups[1].Success ? "Iron" : m.Groups[2].Success ? "Yard" : "Iron Yard");
        }
    }
}