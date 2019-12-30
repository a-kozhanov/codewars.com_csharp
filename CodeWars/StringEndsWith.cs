/*
https://www.codewars.com/kata/string-ends-with/train/csharp
https://www.codewars.com/kata/51f2d1cafc9c0f745c00037d/solutions/csharp

7 kyu
String ends with?

Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).

Examples:
solution('abc', 'bc') // returns true
solution('abc', 'd') // returns false
*/

using System;

namespace CodeWars
{
    public class StringEndsWith
    {
        public static bool Solution(string str, string ending)
        {
            return str.EndsWith(ending);
        }
    }

    // public static bool Solution(string str, string ending) => str.EndsWith(ending);


    // public static bool Solution(string str, string ending)
    // {
    // return (str.Length >= ending.Length) && str.Substring(str.Length - ending.Length).Equals(ending);
    // }
}