/*
https://www.codewars.com/kata/exclamation-marks-series-number-4-remove-all-exclamation-marks-from-sentence-but-ensure-a-exclamation-mark-at-the-end-of-string/train/csharp
https://www.codewars.com/kata/57faf12b21c84b5ba30001b0/solutions/csharp

8 kyu
Exclamation marks series #4: Remove all exclamation marks from sentence but ensure a exclamation mark at the end of string

Description:
Remove all exclamation marks from sentence but ensure a exclamation mark at the end of string. 
For a beginner kata, you can assume that the input data is always a non empty string, no need to verify it.

Examples
remove("Hi!") === "Hi!"
remove("Hi!!!") === "Hi!"
remove("!Hi") === "Hi!"
remove("!Hi!") === "Hi!"
remove("Hi! Hi!") === "Hi Hi!"
remove("Hi") === "Hi!"
*/


using System.Text.RegularExpressions;

namespace CodeWars
{
    public class ExclamationMarksSeries4
    {
        public static string Remove(string s)
        {
            //return Regex.Replace(s, "!", "") + '!';
            return s.Replace("!", "") + '!';
        }
    }
}