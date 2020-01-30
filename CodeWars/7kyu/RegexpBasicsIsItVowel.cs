/*
https://www.codewars.com/kata/567bed99ee3451292c000025/train/csharp
https://www.codewars.com/kata/567bed99ee3451292c000025/solutions/csharp

7 kyu
Regexp Basics - is it a vowel?

Implement the function which should return true if given object is a vowel, false otherwise.
*/

using System;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public static class RegexpBasicsIsItVowel
    {
        public static bool Vowel(this string s)
        {
            Console.WriteLine(s);
            return Regex.IsMatch(s, @"^(?i)[aeiou]\z");
        }

        // public static bool Vowel(this string s)
        // {
        //     return s.Length==1&&"aeiou".Contains(s.ToLower());
        // }

        // public static bool Vowel(this string s) => s.Length == 1 && Regex.IsMatch(s, @"[aeiou]", RegexOptions.IgnoreCase);

        // public static bool Vowel(this string s)
        // {
        //     return Regex.IsMatch(s, @"^[aeiou]\z", RegexOptions.IgnoreCase);
        // }

        // public static bool Vowel(this string s)
        // {
        //     if(String.IsNullOrWhiteSpace(s) || s.Length > 1)
        //         return false;
        //   
        //     return "aeiouAEIOU".Contains(s);
        // }


        // public static bool Vowel(this string s)
        // {
        //     Console.WriteLine(s);
        //     return Regex.IsMatch(s,@"^[aeiou]\z", RegexOptions.IgnoreCase);
        // }


        // public static bool Vowel(this string s)
        // {
        //     return s.Length == 1 && "aeiou".Contains(s.ToLower());
        // }


        // public static bool Vowel(this string s)
        // {
        //     bool stringIsValid = Regex.IsMatch(s, @"^[aeiouAEIOU]*?$");
        //     if (s.Length == 1 && stringIsValid)
        //     {
        //         return true;
        //     }
        //     else
        //         return false;
        // }


        // public static List<string> vowels = new List<string>(){"a","e", "u", "i", "o" };
        // public static bool Vowel(this string s)
        // {
        //     s = s.ToLower();
        //     if(vowels.Contains(s))
        //     {
        //         return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }
        // }


        // public static bool Vowel(this string s)
        // {
        //     if (s.Length == 1)
        //     {
        //         return "euioa".Contains(s.ToLower());
        //     }
        //
        //     return false;
        // }


        // public static bool Vowel(this string s)
        // {
        //     //LINQ because lul
        //     return s.Length == 1 && "AEIOUaeiou".Contains(s);
        // }


        // public static bool Vowel(this string s) => s.Length == 1 && Regex.IsMatch(s, @"(?i)[aeiou]"); 
    }
}