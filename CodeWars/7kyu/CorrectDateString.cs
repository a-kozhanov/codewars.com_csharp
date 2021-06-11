/*
https://www.codewars.com/kata/5787628de55533d8ce000b84/csharp

7 kyu
Correct the date-string

A very easy task for you!

You have to create a method, that corrects a given date string. 
There was a problem in addition, so many of the date strings are broken. 
Date-Format is european. That means "DD.MM.YYYY".

Some examples:

"30.02.2016" -> "01.03.2016"
"40.06.2015" -> "10.07.2015"
"11.13.2014" -> "11.01.2015"
"99.11.2010" -> "07.02.2011"

If the input-string is null or empty return exactly this value!
If the date-string-format is invalid, return null.

Hint: Correct first the month and then the day!

Have fun coding it and please don't forget to vote and rank this kata! :-)

I have created other katas. Have a look if you like coding and challenges.
*/

using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class CorrectDateString
    {
        public static string Correct(string dateString)
        {
            // if (!Regex.IsMatch(dateString, @"\d{2}\.\d{2}\.\d{4}")) return null;
            
            if (string.IsNullOrEmpty(dateString)) return dateString;
            if (Regex.Matches(dateString, "[0-9.]").Count != 10) return null;
            var arr = dateString.Split('.').Select(x => int.Parse(x) - 1).ToArray();
            return new DateTime().AddYears(arr[2]).AddMonths(arr[1]).AddDays(arr[0]).ToString("dd.MM.yyyy");
            
            // return new DateTime(arr[2], 1, 1).AddMonths(arr[1]).AddDays(arr[0]).ToString("dd.MM.yyyy");
            // return DateTime.Parse($"01/01/{arr[2]}").AddMonths(arr[1]).AddDays(arr[0]).ToString("dd.MM.yyyy");
        }
    }
}