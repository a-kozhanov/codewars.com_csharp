/*
https://www.codewars.com/kata/5738f5ea9545204cec000155/train/csharp
https://www.codewars.com/kata/5738f5ea9545204cec000155/solutions/csharp

7 kyu
Help Bob count letters and digits.

Bob is a lazy man.
He needs you to create a method that can determine how many letters and digits are in a given string.

Example:
"hel2!lo" --> 6
"wicked .. !" --> 6
"!?..A" --> 1
 */

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class HelpBobCountLettersAndDigits
    {
        public static int CountLettersAndDigits(string input)
        {
            return input.Count(char.IsLetterOrDigit);
        }

        // public static int CountLettersAndDigits(string input)
        // {
        //     return input.Count(c => char.IsLetter(c) || char.IsNumber(c));
        // }

        // public static int CountLettersAndDigits(string input)
        // {
        //     var allowedCharacters = string.Concat(Enumerable.Range(0,26).Select(i => (i < 10 ? i.ToString() : "") + (char)(i + 65) + (char)(i+97)));
        //
        //     return input.Count(c => allowedCharacters.Contains(c));
        // }

        // public static int CountLettersAndDigits(string input)
        // {
        //     return input.Where(x=>Char.IsLetterOrDigit(x)).Count();            
        // }

        // public static int CountLettersAndDigits(string input)
        // {
        //     string pt = @"(\w)";
        //     Regex rg = new Regex(pt);
        //     MatchCollection mt = rg.Matches(input);
        //     return mt.Count;
        // }

        // public static int CountLettersAndDigits(string input)
        // {
        //     return input.Length-new Regex(@"\d|[a-zA-Z]").Replace(input, "").Length;
        // }


        // public static int CountLettersAndDigits(string input)
        // {
        //     return new Regex(@"[^a-zA-Z0-9+]").Replace(input, "").Length;
        // }


        // public static int CountLettersAndDigits(string input)
        // {
        //     return Regex.Matches(input, "[a-zA-Z0-9]").Count;
        // }
    }
}