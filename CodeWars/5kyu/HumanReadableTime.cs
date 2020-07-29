/*
https://www.codewars.com/kata/52685f7382004e774f0001f7/csharp

5 kyu
Human Readable Time

Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)

HH = hours, padded to 2 digits, range: 00 - 99
MM = minutes, padded to 2 digits, range: 00 - 59
SS = seconds, padded to 2 digits, range: 00 - 59
The maximum time never exceeds 359999 (99:59:59)

You can find some examples in the test fixtures.
*/

using System;

namespace CodeWars
{
    public class HumanReadableTime
    {
        public static string GetReadableTime(int seconds)
        {
            // var t = TimeSpan.FromSeconds(seconds);
            // return $"{(int) t.TotalHours:00}:{t.Minutes:00}:{t.Seconds:00}";

            return $"{seconds / 3600:00}:{seconds / 60 % 60:00}:{seconds % 60:00}";
            //return $"{seconds / 3600:d2}:{seconds / 60 % 60:d2}:{seconds % 60:d2}";
        }
    }
}