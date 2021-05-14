/*
https://www.codewars.com/kata/55c606e6babfc5b2c500007c/csharp

7 kyu
Failed Filter - Bug Fixing #3

Failed Filter - Bug Fixing #3
Oh no, Timmy's filter doesn't seem to be working? 
Your task is to fix the FilterNumber function to remove all the numbers from the string.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class FailedFilterBugFixing3
    {
        public static string FilterNumbers(string str)
        {
            return string.Concat(str.Where(c => !char.IsNumber(c)));
            // return string.Concat(str.ToCharArray().Where(c => !"0123456789".Contains(c)));
            // return new string(str.ToCharArray().Where(c => c < '0' || c > '9').ToArray());
            // return new string(str.Where(c => Char.IsLetter(c) || c == '-').ToArray());
            // return string.Concat(str.ToCharArray().Where(c => !char.IsDigit(c)));
            // return new string(str.Where(c => !Char.IsDigit(c)).ToArray());
            // return string.Concat(str.Where(c => !char.IsNumber(c)));
            // return string.Concat(str.Where(c => !char.IsDigit(c)));
            // return Regex.Replace(str, "[0-9]", "");
            // return Regex.Replace(str, @"\d", "");
        }
    }
}