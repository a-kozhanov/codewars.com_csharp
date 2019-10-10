
//https://www.codewars.com/kata/string-cleaning/train/csharp
//https://www.codewars.com/kata/57e1e61ba396b3727c000251/solutions/csharp

//String cleaning
//8 kyu

//Your boss decided to save money by purchasing some cut-rate optical character recognition software for scanning in the text of old novels to your database.
//At first it seems to capture words okay, but you quickly notice that it throws in a lot of numbers at random places in the text. For example:
//string_clean('! !') == '! !'
//string_clean('123456789') == ''
//string_clean('This looks5 grea8t!') == 'This looks great!'
//Your harried co-workers are looking to you for a solution to take this garbled text and remove all of the numbers.
//Your program will take in a string and clean out all numeric characters, and return a string with spacing and special characters ~#$%^&!@*():;"'.,? all intact.

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class StringCleaning
    {
        public static string StringClean(string s)
        {
            return Regex.Replace(s, @"\d", "");
        }


        //public static string StringClean(string s)
        //{
        //    foreach (char c in s)
        //        if (c >= 48 && c <= 57) s = s.Replace(c.ToString(), "");
        //    return s;
        //}


        //public static string StringClean(string s)
        //{
        //    return String.Join("", s.Where(x => !Char.IsDigit(x)));
        //}

        //public static string StringClean(string s)
        //{
        //    return Regex.Replace(s, "[0123456789]", "");
        //}


        //public static string StringClean(string s)
        //{
        //    Regex r = new Regex(@"[\d]+");
        //    return r.Replace(s, "");
        //}


        //public static string StringClean(string s) =>
        //    string.Concat(s.Where(x => !char.IsNumber(x)));

        //public static string StringClean(string s)
        //{
        //    return string.Concat(s.Where(c => !char.IsDigit(c)));
        //}







    }
}