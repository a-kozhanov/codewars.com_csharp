/*
https://www.codewars.com/kata/regex-count-lowercase-letters/train/csharp
https://www.codewars.com/kata/56a946cd7bd95ccab2000055/solutions/csharp

8 kyu
Regex count lowercase letters

Your task is simply to count the total number of lowercase letters in a string.

Examples
LowercaseCountCheck("abc") == 3
LowercaseCountCheck("abcABC123") == 3
LowercaseCountCheck("abcABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~"") == 3
LowercaseCountCheck("") == 0
LowercaseCountCheck("ABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~"") == 0
LowercaseCountCheck("abcdefghijklmnopqrstuvwxyz") == 26
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class RegexCountLowerCaseLetters
    {
        public static int LowercaseCountCheck(string s)
        {
            return Regex.Matches(s, "[a-z]").Count;
        }

        //public static int LowercaseCountCheck(string s)
        //{
        //    return s.Count(char.IsLower);
        //}


        //public static int LowercaseCountCheck(string s) => s.ToCharArray().Where(x => Char.IsLower(x)).Count();


        //public static int LowercaseCountCheck(string s) => (new List<char>(s)).Count(c => char.IsLower(c));


        //public static int LowercaseCountCheck(string Input)
        //{
        //    return new Regex("[^a-z]").Replace(Input, "").Length;
        //}


        //public static int LowercaseCountCheck(string s)
        //{
        //    int count = 0;
        //    foreach(var x in s)
        //    {
        //        if(char.IsLower(x))
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}



    }
}