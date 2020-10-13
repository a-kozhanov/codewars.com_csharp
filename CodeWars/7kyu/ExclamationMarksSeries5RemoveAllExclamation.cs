/*
https://www.codewars.com/kata/57faf32df815ebd49e000117/csharp

7 kyu
Exclamation marks series #5: Remove all exclamation marks from the end of words

Description:
Remove all exclamation marks from the end of words. Words are separated by spaces in the sentence.

Examples
remove("Hi!") === "Hi"
remove("Hi!!!") === "Hi"
remove("!Hi") === "!Hi"
remove("!Hi!") === "!Hi"
remove("Hi! Hi!") === "Hi Hi"
remove("!!!Hi !!hi!!! !hi") === "!!!Hi !!hi !hi"
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class ExclamationMarksSeries5RemoveAllExclamation
    {
        public static string Remove(string s)
        {
            //return new Regex(@"(?<=\w)!+").Replace(s, "");
            //return new Regex(@"\b!+").Replace(s, "");
            //return Regex.Replace(s, @"\b!+", "");
            //return Regex.Replace(s, @"\b!*", "");
            return Regex.Replace(s, @"\b!+", "");
        }
    }
}