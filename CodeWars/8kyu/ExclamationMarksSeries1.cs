/*
https://www.codewars.com/kata/exclamation-marks-series-number-1-remove-a-exclamation-mark-from-the-end-of-string/train/csharp
https://www.codewars.com/kata/57fae964d80daa229d000126/solutions/csharp

8 kyu
Exclamation marks series #1: Remove a exclamation mark from the end of string

Description:
Remove a exclamation mark from the end of string. For a beginner kata, you can assume that the input data is always a string, no need to verify it.

Examples
remove("Hi!") === "Hi"
remove("Hi!!!") === "Hi!!"
remove("!Hi") === "!Hi"
remove("!Hi!") === "!Hi"
remove("Hi! Hi!") === "Hi! Hi"
remove("Hi") === "Hi"
Note
Please don't post issue about difficulty or duplicate.
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class ExclamationMarksSeries1
    {
        public static string Remove(string s)
        {
            return s[s.Length - 1] == '!' ? s.Substring(0, s.Length - 1) : s;
        }

        //public static string Remove(string s)
        //{
        //    return s.EndsWith("!") ? s.Remove(s.Length - 1) : s;
        //}

        //public static string Remove(string s) => new Regex("!$").Replace(s, "");


        //public static string Remove(string s) => s.Last() == '!' ? s.Remove(s.Length - 1) : s;

        //public static string Remove(string s)
        //{
        //    return string.Concat( s.Where((a, i) => !(s.Length - 1 == i && a == '!')).ToArray());
        //}


    }
}