/*
https://www.codewars.com/kata/5f77d62851f6bc0033616bd8/csharp

7 kyu
Valid Spacing

Task
Your task is to write a function called valid_spacing() or validSpacing() which checks if a string has valid spacing. 
The function should return either True or False.

For this kata, the definition of valid spacing is one space between words, and no leading or trailing spaces. 
Below are some examples of what the function should return.

'Hello world' = true
' Hello world' = false
'Hello world  ' = false
'Hello  world' = false
'Hello' = true
// Even though there are no spaces, it is still valid because none are needed
'Helloworld' = true 
// true because we are not checking for the validity of words.
'Helloworld ' = false
' ' = false
'' = true
Note - there will be no punctuation or digits in the input string, only letters.
*/

using System.Text.RegularExpressions;

namespace CodeWars
{
    public class KataValidSpacing
    {
        public static bool ValidSpacing(string s)
        {
            return s.Trim() == s && !s.Contains("  ");
            // return s.Trim() == s && s.IndexOf("  ") == -1;
            // return !Regex.IsMatch(s, @"^\s|\s\s\S|\s$");
            // return s.Trim().Length == s.Length && !s.Contains("  ");
            // return !s.StartsWith(' ') && !s.EndsWith(' ') && !s.Contains("  ");
        }
    }
}