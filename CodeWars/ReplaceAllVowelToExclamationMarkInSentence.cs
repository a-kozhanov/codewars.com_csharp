

//https://www.codewars.com/kata/exclamation-marks-series-number-11-replace-all-vowel-to-exclamation-mark-in-the-sentence/train/csharp
//https://www.codewars.com/kata/57fb09ef2b5314a8a90001ed/solutions/csharp

//8 kyu
//Exclamation marks series #11: Replace all vowel to exclamation mark in the sentence


//Description:
//Replace all vowel to exclamation mark in the sentence. aeiouAEIOU is vowel.

//Examples
//replace("Hi!") === "H!!"
//replace("!Hi! Hi!") === "!H!! H!!"
//replace("aeiou") === "!!!!!"
//replace("ABCDE") === "!BCD!"


using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class ReplaceAllVowelToExclamationMarkInSentence
    {
        public static string Replace(string s)
        {
            return string.Concat(s.Select(x => "aeiouAEIOU".Contains(x) ? '!' : x));
        }


        //public static string Replace(string s) => Regex.Replace(s, @"[aeiou]", "!", RegexOptions.IgnoreCase);


        //public static string Replace(string s) => Regex.Replace(s, @"[aeiouAEIOU]", "!");

        //public static string Replace(string s)
        //{
        //    return Regex.Replace(s, "(?i)[aeiou]", "!");
        //}

        //public static string Replace(string s)
        //{
        //    return string.Concat(s.ToCharArray().Select(x => "aeiouAEIOU".Contains(x) ? '!' : x));
        //}



    }
}