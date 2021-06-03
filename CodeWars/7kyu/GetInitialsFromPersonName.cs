/*
https://www.codewars.com/kata/57b56af6b69bfcffb80000d7/csharp

7 kyu
Get initials from person name

Write function toInitials returs initials for a given person name. E.g: "Bill Gates" -> "B. G."
Note: initials should be separated with a space.
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class GetInitialsFromPersonName
    {
        public static string toInitials(string name)
        {
            return string.Join(" ", name.Split().Select(s => s[0] + "."));
            // return Regex.Replace(name, @"(\S)\S+\b", "$1.");
        }
    }
}