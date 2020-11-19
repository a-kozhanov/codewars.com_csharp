/*
https://www.codewars.com/kata/57faefc42b531482d5000123/csharp

7 kyu
Exclamation marks series #3: Remove all exclamation marks from sentence except at the end

Description:
Remove all exclamation marks from sentence except at the end.

Examples
remove("Hi!") == "Hi!"
remove("Hi!!!") == "Hi!!!"
remove("!Hi") == "Hi"
remove("!Hi!") == "Hi!"
remove("Hi! Hi!") == "Hi Hi!"
remove("Hi") == "Hi"
*/

using System.Text.RegularExpressions;

namespace CodeWars
{
    public class ExclamationMarksSeries3RemoveAll
    {
        public static string Remove(string s)
        {
            return Regex.Replace(s, "(?!!*$)!", "");
            //return Regex.Replace(s, "!(?!!*$)", "");
            //return Regex.Replace(s, @"!+(?!!*$)", "");
            //return Regex.Replace(s, @"!+([^!])", "$1");
            //return Regex.Replace(s, "(?>!+)(?!$)", "");
            //return Regex.Replace(s, @"(?>!+)(?!$)", "");
            //return new Regex(@"!+(?!!*$)").Replace(s, "");
            //return new Regex(@"!+(?!!*$)").Replace(s, "");
            //return s.Replace("!", "") + Regex.Match(s, @"!+$").Value;
        }
    }
}