/*
https://www.codewars.com/kata/515de9ae9dcfc28eb6000001/train/csharp
https://www.codewars.com/kata/515de9ae9dcfc28eb6000001/solutions/csharp

6 kyu
Split Strings

Complete the solution so that it splits the string into pairs of two characters. 
If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').

Examples:
SplitString.Solution("abc"); // should return ["ab", "c_"]
SplitString.Solution("abcdef"); // should return ["ab", "cd", "ef"]
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class SplitStrings
    {
        public static string[] Solution(string str)
        {
            //return Regex.Split(str + "_", @"(?<=\G.{2})").Select(x => x.Length != 2 ? x + "_" : x).ToArray();
            //return Regex.Split(str, "(..)").Where(x => x != "").Select(x => x.Length != 2 ? x + "_" : x).ToArray();
            //return Regex.Split((str.Length % 2 != 1 ? str : str + "_"), @"(?<=\G.{2})").Where(x => x != "").ToArray();
            //return Regex.Split(str, "(..)").Where(x => !x.Equals("")).Select(x => x.Length != 2 ? x + "_" : x).ToArray();
            //return Regex.Matches(str, "\\w{1,2}").Select(x => x.Value.Length == 2 ? x.Value : x.Value + "_").ToArray();
            //return Regex.Matches($"{str}_", @"\w{2}").Select(x => x.Value).ToArray();
            return Regex.Matches(str + "_", @"\w{2}").Select(x => x.Value).ToArray();
        }

        // public static string[] Solution(string str)
        // {
        //     if (str.Length % 2 != 0)
        //         str += "_";
        //     return Enumerable.Range(0, str.Length)
        //         .Where(x => x % 2 == 0)
        //         .Select(x => str.Substring(x, 2))
        //         .ToArray();
        // }


        // public static string[] Solution(string str)
        // {
        //     if (str.Length % 2 == 1)
        //         str += "_";
        //
        //     List<string> list = new List<string>();
        //     for (int i = 0; i < str.Length; i += 2)
        //     {
        //         list.Add(str[i].ToString() + str[i + 1]);
        //     }
        //
        //     return list.ToArray();
        // }


        // public static string[] Solution(string str)
        // {
        //     str = (str.Length % 2 == 0) ? str : str + "_";
        //     return
        //         Enumerable
        //             .Range(0, str.Length / 2)
        //             .Select(i => str.Substring(2 * i, 2))
        //             .ToArray();
        // }


        // public static string[] Solution(string s)
        // {
        //     if (s.Length % 2 != 0)
        //     {
        //         s += "_";
        //     }
        //
        //     return Regex.Matches(s, "([a-zA-Z_]{2})").OfType<Match>().Select(m => m.Value).ToArray();
        // }


        // public static string[] Solution(string str)
        // {
        //     if (str.Length % 2 != 0) str += '_';
        //     return Enumerable.Range(0, str.Length / 2).Select(i => str.Substring(2 * i, 2)).ToArray();
        // }


        // public static string[] Solution(string str)
        // {
        //     var paddedString = str + "_";
        //
        //     return Enumerable.Range(0, (str.Length + 1) / 2).Select(i => paddedString.Substring(2 * i, 2)).ToArray();
        // }


        // public static string[] Solution(string str)
        // {
        //     if (str.Length % 2 != 0)
        //         str += "_";
        //     string[] result = new string[str.Length / 2];
        //     int start = 0;
        //     for (int i = 0; i < result.Length; i++, start += 2)
        //         result[i] = str.Substring(start, 2);
        //     return result;
        // }


        // public static string[] Solution(string str)
        // {
        //     return Regex.Split((str.Length % 2 != 1 ? str : str + "_"), @"(?<=\G.{2})").Where(x => x != "").ToArray();
        // }
    }
}