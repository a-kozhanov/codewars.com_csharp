using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Text.RegularExpressions.Regex;

/*
https://www.codewars.com/kata/5208f99aee097e6552000148/train/csharp
https://www.codewars.com/kata/5208f99aee097e6552000148/solutions/csharp

6 kyu
Break camelCase

Complete the solution so that the function will break up camel casing, using a space between words.

Example
Kata.BreakCamelCase("camelCasing") => "camel Casing"
*/

namespace CodeWars
{
    public static class KataBreakCamelCase
    {
        public static string BreakCamelCase(string str)
        {
            return Replace(str, "([A-Z])", " $1");
        }

        // public static string BreakCamelCase(string str) => new Regex("([A-Z])").Replace(str, " $1");


        // public static string BreakCamelCase(string str)
        // {
        //     return string.Concat(str.Select(c => Char.IsUpper(c) ? " " + c : c.ToString()));
        // }


        // public static string BreakCamelCase(string str)
        // {
        //     string result = string.Empty;
        //
        //     foreach (char c in str)
        //         if (char.IsUpper(c))
        //             result = new string(string.Concat(result, " ", c.ToString()).ToCharArray());
        //         else
        //             result = new string(string.Concat(result, c.ToString()).ToCharArray());
        //
        //     return result;
        // }


        // public static string BreakCamelCase(string word)
        // {
        //     var sb = new StringBuilder();
        //     foreach (var symbol in word)
        //     {
        //         if (char.IsUpper(symbol)) sb.Append(" ");
        //         sb.Append(symbol);
        //     }
        //
        //     return sb.ToString().Trim();
        // }


        // public static string BreakCamelCase(string str)
        // {
        //     return String.Join("", str.Select(x => char.IsUpper(x) ? " " + x : x.ToString()));
        // }


        // public static string BreakCamelCase(string s)
        // {
        //     var z = "";
        //     foreach (var c in s)
        //     {
        //         z += char.IsUpper(c) ? $" {c}" : $"{c}";
        //     }
        //
        //     return z;
        // }


        // public static string BreakCamelCase(string str)
        // {
        //     string m_return = "";
        //     foreach (char m_char in str)
        //     {
        //         if (m_char >= 65 && m_char <= 90) m_return += " ";
        //         m_return += m_char;
        //     }
        //
        //     return m_return;
        // }


        // public static string BreakCamelCase(string str) =>
        //     String.Join("", str.Select(c => Char.IsUpper(c) ? " " + c : "" + c).ToArray());
    }
}