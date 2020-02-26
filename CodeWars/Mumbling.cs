/*
https://www.codewars.com/kata/5667e8f4e3f572a8f2000039/train/csharp
https://www.codewars.com/kata/5667e8f4e3f572a8f2000039/solutions/csharp

7 kyu
Mumbling


This time no story, no theory. The examples below show you how to write function accum:

Examples:

accum("abcd") -> "A-Bb-Ccc-Dddd"
accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
accum("cwAt") -> "C-Ww-Aaa-Tttt"
The parameter of accum is a string which includes only letters from a..z and A..Z.
*/


using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public class Mumbling
    {
        public static string Accum(string s)
        {
            //return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(string.Join("-", Enumerable.Range(0, s.Length).Select(x => string.Concat(Enumerable.Repeat(s.ToLower()[x], x + 1)))));
            //return string.Join("-", s.Select((c, i) => char.ToUpper(c) + new string(char.ToLower(c), i)));
            //return string.Join("-", s.ToLower().Select((x, i) => $"{char.ToUpper(x)}{new string(x, i)}"));
            return string.Join("-", s.ToLower().Select((x, i) => char.ToUpper(x) + new string(x, i)));
        }

        // public static String Accum(string s)
        // {
        //     return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
        // }


        // public static string Accum(string s)
        // {
        //     if (s.Length < 1) return "";
        //
        //     StringBuilder sb = new StringBuilder();
        //     int count = 1;
        //     foreach (char c in s.ToLower())
        //         sb.Append(Char.ToUpper(c), 1)
        //             .Append(c, count++ - 1)
        //             .Append('-');
        //
        //     return sb.ToString().TrimEnd('-');
        // }


        // public static String Accum(string s)
        // {
        //     string result = "";
        //     int count = 0;
        //     foreach (char c in s.ToUpper())
        //     {
        //         Console.WriteLine(c);
        //         if (count != 0) result += "-";
        //         result += c + new String(char.ToLower(c), count);
        //         ++count;
        //     }
        //     return result;
        // }


        // public static String Accum(string s)
        // {
        //     var q = s.ToCharArray()
        //         .Select((cc, index) => (Char.ToUpper(cc).ToString()).PadRight(index + 1, Char.ToLower(cc)))
        //         .ToArray<string>();
        //
        //     return string.Join<string>("-", q);
        // }

    }
}