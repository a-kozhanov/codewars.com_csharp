
/*
https://www.codewars.com/kata/vowel-remover/train/csharp
https://www.codewars.com/kata/5547929140907378f9000039/solutions/csharp

8 kyu
Vowel remover

Create a function called shortcut to remove all the lowercase vowels in a given string.

Examples
Shortcut("codewars") # --> cdwrs
Shortcut("goodbye")  # --> gdby
Don't worry about uppercase vowels.

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class VowelRemover
    {
        public static string Shortcut(string input)
        {
            return string.Concat(input.Select(x => "aeiouAEIOU".Contains(x) ? "" : x.ToString()));
        }


        //public static string Shortcut(string input)
        //{
        //    return Regex.Replace(input, "[aeiou]", "");
        //}


        //public static string Shortcut(string input) {
        //    return String.Concat(input.Where(c => !"aeiou".Contains(c)));
        //}

        //public static string Shortcut(string input)
        //{
        //    return Regex.Replace(input, @"[aeiou]", "");
        //}


        //public static string Shortcut(string input)
        //{
        //    return Regex.Replace(input, @"[euioa]", "");
        //}


        //public static string Shortcut(string input)
        //{
        //    // TODO: Remove vowels
        //    var vowels = "euioaEUIOA";
        //    string result = "";

        //    foreach (var val in input)
        //    {
        //        if (!vowels.Contains(val.ToString()))
        //        {
        //            result += val.ToString();
        //        }
        //    }

        //    return result;
        //}


        //public static string Shortcut(string input)
        //{
        //    var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

        //    foreach (Char c in input)
        //    {
        //        if ((Char.IsLower(c)) && (vowels.Contains(c)))
        //        {
        //            input = input.Replace(c.ToString(), string.Empty);
        //        }
        //    }
        //    return input;
        //}


        //public static string Shortcut(string input)
        //{
        //    char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

        //    return string.Concat(input.Where(c => !vowels.Contains(c)).ToArray());
        //}



    }
}