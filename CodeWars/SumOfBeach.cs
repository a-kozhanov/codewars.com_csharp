/*
https://www.codewars.com/kata/5b37a50642b27ebf2e000010/train/csharp
https://www.codewars.com/kata/5b37a50642b27ebf2e000010/solutions/csharp

7 kyu
Sum of a Beach

Beaches are filled with sand, water, fish, and sun. 
Given a string, calculate how many times the words "Sand", 
"Water", "Fish", and "Sun" appear without overlapping (regardless of the case).

Examples
SumOfABeach("WAtErSlIde")                    ==>  1
SumOfABeach("GolDeNSanDyWateRyBeaChSuNN")    ==>  3
SumOfABeach("gOfIshsunesunFiSh")             ==>  4
SumOfABeach("cItYTowNcARShoW")               ==>  0
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class SumOfBeach
    {
        public static int SumOfABeach(string s)
        {
            return Regex.Matches(s, "(?i)sand|water|fish|sun").Count;
        }

        // public static int SumOfABeach(string s)
        // {
        //     return Regex.Matches(s.ToLower(), "water|fish|sand|sun").Count;
        // }

        // public static int SumOfABeach(string s)
        // {
        //     return Regex.Matches(s, "(sand|sun|water|fish)", RegexOptions.IgnoreCase).Count;
        // }

        // public static int SumOfABeach(string s)
        // {
        //     return s.ToLower().Split(new string[] {"sand", "water", "fish", "sun"}, StringSplitOptions.None).Length - 1;
        // }

        // public static int SumOfABeach(string s) => s.ToLower().Replace(" ", "").Replace("sand", " ")
        //     .Replace("water", " ").Replace("fish", " ").Replace("sun", " ").Count(i => i == ' ');


        // public static int SumOfABeach(string s) =>
        //     s.ToLower().Split(new string[] {"sand", "water", "fish", "sun"}, StringSplitOptions.None).Length - 1;


        // public static int SumOfABeach(string s)
        // {
        //     return Regex.Matches(s, @"[Ss][Aa][Nn][Dd]|[Ww][Aa][Tt][Ee][Rr]|[Ff][Ii][Ss][Hh]|[Ss][Uu][Nn]").Count;
        // }


        // public static int SumOfABeach(string s)
        // {
        //     return s.ToLower().Replace("sand", "$").Replace("water", "$").Replace("fish", "$").Replace("sun", "$")
        //         .Where(x => x == '$').Count();
        // }
    }
}