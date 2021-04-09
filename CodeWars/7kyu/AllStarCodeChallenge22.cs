/*
https://www.codewars.com/kata/5865cff66b5699883f0001aa/csharp

7 kyu
All Star Code Challenge #22

This Kata is intended as a small challenge for my students

All Star Code Challenge #22

Create a function hat takes an integer argument of seconds and converts the value into a string describing how many hours and minutes comprise that many seconds.

Any remaining seconds left over are ignored.

Note:
The string output needs to be in the specific form - "X hour(s) and X minute(s)"

For example:

3600 --> "1 hour(s) and 0 minute(s)"
3601 --> "1 hour(s) and 0 minute(s)"
3500 --> "0 hour(s) and 58 minute(s)"
23500 --> "89 hour(s) and 51 minute(s)"
*/

using System;

namespace CodeWars
{
    public class AllStarCodeChallenge22
    {
        public static string ToTime(int seconds)
        {
            return $"{seconds / 3600} hour(s) and {seconds % 3600 / 60} minute(s)";
            // return string.Format("{0} hour(s) and {1} minute(s)", seconds / 3600, seconds % 3600 / 60);

            // var ts = TimeSpan.FromSeconds(seconds);
            // return $"{Math.Floor(ts.TotalHours)} hour(s) and {ts.Minutes} minute(s)";
        }
    }
}