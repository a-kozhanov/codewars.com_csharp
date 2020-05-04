/*
https://www.codewars.com/kata/5939ab6eed348a945f0007b2/train/csharp

7 kyu
Inspiring Strings

When given a string of space separated words, return the word with the longest length. 
If there are multiple words with the longest length, return the last instance of the word with the longest length.

Example:
'red white blue' //returns string value of white
'red blue gold' //returns gold
*/

using System.Linq;

namespace CodeWars
{
    public class InspiringStrings
    {
        public static string LongestWord(string stringOfWords)
        {
            //return stringOfWords.Split().Aggregate((a, b) => a.Length > b.Length ? a : b);
            return stringOfWords.Split().OrderBy(w => w.Length).Last();
        }
    }
}