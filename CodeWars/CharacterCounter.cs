/*
https://www.codewars.com/kata/56786a687e9a88d1cf00005d/csharp

7 kyu
Character Counter

You are going to be given a word. 
Your job will be to make sure that each character in that word has the exact same number of occurrences. 
You will return true if it is valid, or false if it is not.

For example:
"abcabc" is a valid word because 'a' appears twice, 'b' appears twice, and'c' appears twice.
"abcabcd" is NOT a valid word because 'a' appears twice, 'b' appears twice, 'c' appears twice, 
but 'd' only appears once! "123abc!" is a valid word because all of the characters only appear once in the word.

For this kata, capitals are considered the same as lowercase letters. Therefore: 'A' == 'a' .
#Input A string (no spaces) containing [a-z],[A-Z],[0-9] and common symbols. The length will be 0 < string < 100.
#Output true if the word is a valid word, or false if the word is not valid.
*/

using System.Linq;

namespace CodeWars
{
    public class CharacterCounter
    {
        public static bool ValidateWord(string s)
        {
            //return s.ToLower().Count(x => s.ToLower().Count(c => c == x) == s.ToLower().Count(c => c == s.ToLower().First())) == s.Length;
            //return s.ToLower().All(x => s.ToLower().Count(c => c == x) == s.ToLower().Count(c => c == s.ToLower().First()));
            //returns.ToLower().GroupBy(x => x).All(x => x.Count() == s.ToLower().Count(c => c == s.ToLower().First()));
            //return s.ToLower().GroupBy(x => x).All(x => x.Count() == s.ToLower().Count(c => c == s.ToLower().First()));
            //return s.ToLower().GroupBy(x => x).Select(x => x.Count()).Distinct().Count() < 2;
            //return s.ToLower().GroupBy(x => x).GroupBy(g => g.Count()).Count() == 1;
            //return s.GroupBy(char.ToLower).GroupBy(g => g.Count()).Count() == 1;
            return s.Length % s.ToLower().Distinct().Count() == 0;
        }
    }
}