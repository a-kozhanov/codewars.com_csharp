/*
https://www.codewars.com/kata/57873ab5e55533a2890000c7/csharp

7 kyu
Correct the time-string

A new task for you!

You have to create a method, that corrects a given time string. 
There was a problem in addition, so many of the time strings are broken. 
Time-Format is european. So from "00:00:00" to "23:59:59".

Some examples:

"09:10:01" -> "09:10:01"
"11:70:10" -> "12:10:10"
"19:99:99" -> "20:40:39"
"24:01:01" -> "00:01:01"

If the input-string is null or empty return exactly this value! (empty string for C++)
If the time-string-format is invalid, return null. (empty string for C++)

Have fun coding it and please don't forget to vote and rank this kata! :-)

I have created other katas. Have a look if you like coding and challenges.
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class CorrectTimeString
    {
        public static string Correct(string timeString)
        {
            if (string.IsNullOrEmpty(timeString)) return timeString;
            if (!Regex.IsMatch(timeString, @"(\d{2}):(\d{2}):(\d{2})")) return null;
            var t = timeString.Split(':').Select(int.Parse).ToArray();
            return new TimeSpan(t[0], t[1], t[2]).ToString(@"hh\:mm\:ss");

            // if (string.IsNullOrEmpty(timeString)) return timeString;
            // var m = Regex.Match(timeString, @"(\d{2}):(\d{2}):(\d{2})");
            // if (!m.Success) return null;
            //
            // var dt = new DateTime().AddSeconds(
            //     int.Parse(m.Groups[1].Value) * 3600 +
            //     int.Parse(m.Groups[2].Value) * 60 +
            //     int.Parse(m.Groups[3].Value));
            //
            // return $"{dt.Hour:00}:{dt.Minute:00}:{dt.Second:00}";
        }
    }
}