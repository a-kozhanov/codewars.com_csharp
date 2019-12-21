/*
https://www.codewars.com/kata/exclamation-marks-series-number-2-remove-all-exclamation-marks-from-the-end-of-sentence/train/csharp
https://www.codewars.com/kata/57faece99610ced690000165/solutions/csharp

8 kyu
Exclamation marks series #2: Remove all exclamation marks from the end of sentence

Description:
Remove all exclamation marks from the end of sentence.

Examples
remove("Hi!") === "Hi"
remove("Hi!!!") === "Hi"
remove("!Hi") === "!Hi"
remove("!Hi!") === "!Hi"
remove("Hi! Hi!") === "Hi! Hi"
remove("Hi") === "Hi"
Note
Please don't post issue about difficulty or duplicate.
*/

namespace CodeWars
{
    public class ExclamationMarksSeries2
    {
        public static string Remove(string s)
        {
            return s.TrimEnd('!');
        }  
        
        //public static string Remove(string s) => s.TrimEnd('!');
    }
}