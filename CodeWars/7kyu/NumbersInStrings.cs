/*
https://www.codewars.com/kata/59dd2c38f703c4ae5e000014/train/csharp
https://www.codewars.com/kata/59dd2c38f703c4ae5e000014/solutions/csharp

7 kyu
Numbers in strings

In this Kata, you will be given a string that has lowercase letters and numbers. 
Your task is to compare the number groupings and return the largest number.
For example, solve("gh12cdy695m1") = 695, because this is the largest of all number groupings.
Good luck!

Please also try Simple remove duplicates
*/


using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class NumbersInStrings
    {
        public static int Solve(string s)
        {
            return Regex.Matches(s, @"\d+").Max(x => int.Parse(x.Value));
        }

        // public static int Solve(string s)
        // {
        //     return Regex.Split(s, "[a-z]+")
        //         .Where(e => e != string.Empty)
        //         .Select(e => int.Parse(e))
        //         .Max();
        // }


        // public static int Solve(string s)
        // {
        //     int max = 0;
        //     foreach (Match m in Regex.Matches(s, @"\d+"))
        //         max = Math.Max(max, int.Parse(m.Value));
        //     return max;
        // }


        // public static int Solve(string s)
        // {
        //     return Regex.Matches(s, @"\d+").Cast<Match>().Max(x => int.Parse(x.Value));
        // }


        // public static int Solve(string s) =>
        //     Regex.Matches(s, @"\d+").Cast<Match>().Max(m => int.Parse(m.Value, CultureInfo.InvariantCulture));


        // public static int Solve(string s)
        // {
        //     return Regex.Split(s, "[\\D]+").Where(x => x != null && x != "").Select(int.Parse).ToArray().Max();
        // }


        // public static int Solve(string s)
        // {
        //     MatchCollection matches = Regex.Matches(s, @"\d+");
        //     return matches.Cast<Group>().Max(x => Convert.ToInt32(x.Value));
        // }


        // public static int Solve(string s)
        // {
        //     MatchCollection matches = Regex.Matches(s, @"(\d+)");
        //     return matches.Cast<Match>().Select(m => int.Parse(m.Groups[1].Value)).Max();
        //     ;
        // }


        // public static int Solve(string s)
        // {
        //     return Regex.Split(s, "[^0-9]").Where(x => int.TryParse(x, out int X)).Select(u => int.Parse(u)).Max();
        // }


        // public static int Solve(string s)
        // {
        //     return Regex.Matches(s, @"[\d]+")
        //         .Max(x => int.Parse(x.Value));
        // }


        // public static int Solve(string s)
        // {
        //     int max = Regex.Split(s, @"[a-z]+").Select(x => x.Length > 0 ? Convert.ToInt32(x) : 0).Max();
        //     return max;
        // }
    }
}