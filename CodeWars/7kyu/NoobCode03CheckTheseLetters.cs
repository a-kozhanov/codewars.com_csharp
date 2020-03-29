/*
https://www.codewars.com/kata/57470efebf81fea166001627/train/csharp
https://www.codewars.com/kata/57470efebf81fea166001627/solutions/csharp

7 kyu
noobCode 03: CHECK THESE LETTERS... see if letters in "String 1" are present in "String 2"

Write a function that checks if all the letters in the second string are present in the first one at least once, 
regardless of how many times they appear:

["ab", "aaa"]    =>  true
["trances", "nectar"]    =>  true
["compadres", "DRAPES"]  =>  true
["parses", "parsecs"]    =>  false

Function should not be case sensitive, as indicated in example #2.

Note: both strings are presented as a single argument in the form of an array.
*/


using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class NoobCode03CheckTheseLetters
    {
        public static bool LetterCheck(string[] arr)
        {
            return arr[1].ToUpper().All(arr[0].ToUpper().Contains);
            //return Regex.Replace(arr[0].ToLower(), $"[^{arr[1].ToLower()}]", "").Length >= arr[1].Length;
            //return !arr[1].ToUpper().Except(arr[0].ToUpper()).Any();
        }

        // public static bool LetterCheck(string[] arr)
        // {
        //     return arr[1].All(x => arr[0].Contains(x, StringComparison.InvariantCultureIgnoreCase));
        // }

        // public static bool LetterCheck(string[] arr)
        // {
        //     string container = arr[0].ToLower();
        //     string containees = arr[1].ToLower();
        //     return containees.All(c => container.Contains(c));
        // }

        // public static bool LetterCheck(string[] a)
        // {
        //     var compareChars = a[0].ToLower().ToList();
        //     return a[1].ToLower().All(compareChars.Remove);
        // }


        // public static bool LetterCheck(string[] arr)
        // {
        //     var firstLine = arr[0].ToLower();
        //     var secondLine = arr[1].ToLower();
        //
        //     return secondLine.All(x => firstLine.Contains(x));
        // }
    }
}