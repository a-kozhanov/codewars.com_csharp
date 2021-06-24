/*
https://www.codewars.com/kata/5c81aaf99043851c65ce7f5b/csharp

7 kyu
Extending C# Objects: Calculate Word Scores With a Method

Your task is to write an extension method for the String class called Score(), 
that returns an integer score for any given string.

The score is calculated thus:

Each letter is given a numeric value, where A = 1, B = 2, up through Z = 26 (non-case-sensitive). 
The score is the sum of all values. Ignore any non-alpha characters in the string. 
If there are no alpha characters in the string, the score is 0.

You must use a namespace called "CustomExtensions" to extend the String class, and the method must be called Score(). 
It takes no arguments besides 'this', returns an int, and runs against the String instance it is being called from.

For example, if you run

string testString = "ABC";
int x = testString.Score();
x should contain the value 6.
*/

using System.Linq;

namespace CodeWars
{
    public static class ExtendingCObjectsCalculateWordScoresWithMethod
    {
        public static int Score(this string s)
        {
            // return s.ToLower().Where(char.IsLetter).Sum(c => c - 'a' + 1);
            // return s.ToUpper().Sum(c => char.IsLetter(c) ? c - 'A' + 1 : 0);
            // return s.ToLower().Sum(c => char.IsLetter(c) ? c - 96 : 0);
            // return s.ToUpper().Sum(c => char.IsLetter(c) ? c - 64 : 0);
            // return s.ToUpper().Where(char.IsLetter).Sum(c => c - '@');
            return s.ToUpper().Where(char.IsLetter).Sum(c => c - 64);
        }
    }
}