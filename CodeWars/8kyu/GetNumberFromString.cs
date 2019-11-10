
/*
https://www.codewars.com/kata/get-number-from-string/train/csharp
https://www.codewars.com/kata/57a37f3cbb99449513000cd8/solutions/csharp

8 kyu
Get number from string

Write a function which removes from string all non-digit characters and parse the remaining to number. E.g: "hell5o wor6ld" -> 56

Function:
####javascript

getNumberFromString(s)
####ruby

get_number_from_string(s)
####CSharp

GetNumberFromString(string s)
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class GetNumberFromString
    {
        public static int getNumberFromString(string s)
        {
            return Convert.ToInt32(string.Concat(s.Where(x => char.IsDigit(x))));
        }

        //public static int getNumberFromString(string s)
        //{
        //    return Int32.Parse(Regex.Replace(s, @"[^\d]", ""));
        //}


        //public static int getNumberFromString(string s)
        //{
        //    return int.Parse(string.Concat(s.Where(char.IsDigit)));
        //}

        //public static int getNumberFromString(string s)
        //{
        //    return int.Parse(Regex.Replace(s, @"\D", ""));
        //}


        //public static int getNumberFromString(string s)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    foreach (var item in s)
        //    {
        //        if(char.IsDigit(item))
        //        {
        //            sb.Append(item);
        //        }
        //    }
        //    return Convert.ToInt32(sb.ToString());
        //}


        //public static int getNumberFromString(string s)
        //{
        //    return int.Parse(string.Concat(Regex.Matches(s, @"\d")));
        //}


        //public static int getNumberFromString(string s)
        //{
        //    return Int32.Parse(Regex.Replace(s, "[^0-9.]", ""));
        //}

        //public static int getNumberFromString(string s)
        //{
        //    return Convert.ToInt32(Regex.Replace(s, @"\D", ""));
        //}


    }
}