/*
https://www.codewars.com/kata/5f7c38eb54307c002a2b8cc8/csharp

6 kyu
Remove the parentheses

Remove the parentheses
In this kata you are given a string for example:

"example(unwanted thing)example"
Your task is to remove everything inside the parentheses as well as the parentheses themselves.

The example above would return:

"exampleexample"
Notes
Other than parentheses only letters and spaces can occur in the string. Don't worry about other brackets like "[]" and "{}" as these will never appear.
There can be multiple parentheses.
The parentheses can be nested.
*/

using System.Text.RegularExpressions;

namespace CodeWars
{
    public class KataRemoveParentheses
    {
        public static string RemoveParentheses(string s)
        {
            // return s.Contains('(') ? RemoveParentheses(Regex.Replace(s, @"\([^()]*\)", "")) : s;

            //return Regex.Replace(s, @"(?=\()((?<p>\()|(?<-p>\))|.)+?(?(p)(?!))", "");

            while (s.Contains('('))
            {
                s = Regex.Replace(s, @"\([^()]+\)", "");
            }

            return s;
        }
    }
}