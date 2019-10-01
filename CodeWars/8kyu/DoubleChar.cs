

//https://www.codewars.com/kata/double-char/train/csharp
//https://www.codewars.com/kata/56b1f01c247c01db92000076/solutions/csharp

//Double Char
//8 kyu

//Given a string, you have to return a string in which each character (case-sensitive) is repeated once.
//DoubleChar("String") == "SSttrriinngg"
//DoubleChar("Hello World") == "HHeelllloo  WWoorrlldd"
//DoubleChar("1234!_ ") == "11223344!!__  "
//Good Luck!


using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class KataDoubleChar
    {
        public static string DoubleChar(string s)
        {
            return string.Concat(s.ToCharArray().Select(c => string.Concat(Enumerable.Repeat(c, 2))));
        }


        //public static string DoubleChar(string s)
        //{
        //    return string.Join("", s.Select(x => "" + x + x));
        //}


        //public static string DoubleChar(string s)
        //{
        //    string result = "";
        //    foreach(char c in s)
        //    {
        //        result += ("" + c + c);
        //    }

        //    return result;
        //}


        //public static string DoubleChar(string s)
        //{
        //    return string.Concat(s.Select(x => $"{x}{x}"));
        //}


        //public static string DoubleChar(string s)
        //{
        //    return s.Aggregate("", (str, c) => str + c + c);
        //}


        //public static string DoubleChar(string s)
        //{
        //    var  sb = new System.Text.StringBuilder();
        //    foreach(var item in s.ToCharArray())
        //    {
        //        sb.Append(item).Append(item);
        //    }
        //    return sb.ToString();

        //}


        //public static string DoubleChar(string s)
        //{
        //    return string.Concat(s.Select(x => new string(x, 2)));
        //}



        //public static string DoubleChar(string s)
        //{
        //    return string.Join("", s.ToCharArray().Select(c => c.ToString() + c));
        //}



        //public static string DoubleChar(string s)
        //{
        //    return string.Concat(s.Select(c => new string(c, 2)));
        //}


        //public static string DoubleChar(string s)
        //{
        //    string result = "";
        //    for(int i=0; i<s.Length; i++)
        //    {
        //        result += s[i];
        //        result += s[i];
        //    }

        //    return result;
        //}


        //public static string DoubleChar(string s)
        //{
        //    return Regex.Replace(s, @"(.)", "$1$1");
        //}


        //public static string DoubleChar(string s)
        //{
        //    return new string(s.SelectMany((str, i) => String.Concat(Enumerable.Repeat(str, 2))).ToArray());
        //}


        //public static string DoubleChar(string s)
        //{
        //    return (new Regex("(.)")).Replace(s, "$1$1");
        //}




    }
}