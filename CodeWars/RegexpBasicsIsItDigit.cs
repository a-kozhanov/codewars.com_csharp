/*
https://www.codewars.com/kata/regexp-basics-is-it-a-digit/train/csharp


8 kyu
Regexp Basics - is it a digit?

Implement String#digit? (in Java StringUtils.isDigit(String)), which should return true if given object is a digit (0-9), false otherwise.
*/

using System;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class RegexpBasicsIsItDigit
    {
        public static bool Digit(string s)
        {
            return Regex.IsMatch(s, @"^\d\z", RegexOptions.Singleline);
        }


        //public static Boolean Digit(this String Input)
        //{
        //    return Regex.IsMatch(Input, "^\\d\\z");
        //}

        //public static bool Digit(this string s) => s.Length == 1 ? char.IsDigit(s[0]) : false;


        //public static bool Digit(this string s)
        //{
        //    string s1 = Regex.Escape(s);
        //    return Regex.IsMatch(s1, "^[0-9]$");
        //}


        //public static bool Digit(this string s) => Regex.IsMatch(s, @"\A\d\z");


        //public static bool Digit(this string s)
        //{
        //    if (s.Length != 1)
        //        return false;
        //    return char.IsDigit(s[0]);
        //}


        //public static bool Digit(this string s)
        //{   if(s.Length==1 && char.IsDigit(s[0])) return true;
        //    return false;
        //}


        //public static bool Digit(this string s) => Regex.IsMatch(s, @"^\d\z");


        //public static bool Digit(this string s)
        //{
        //    var temp  = 0;
        //    if (s.Length < 2)
        //        return int.TryParse(s, out temp);
        //    else
        //        return false;
        //}

        //public static bool Digit(this string s)
        //{
        //    if (s.Length != 1)
        //        return false;
        //    return Regex.IsMatch(s, @"^\d$");
        //}





    }
}