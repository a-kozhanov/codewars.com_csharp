/*
https://www.codewars.com/kata/529eef7a9194e0cbc1000255/csharp

7 kyu
Anagram Detection

An anagram is the result of rearranging the letters of a word to produce a new word (see wikipedia).

Note: anagrams are case insensitive

Complete the function to return true if the two arguments given are anagrams of each other; return false otherwise.

Examples
"foefet" is an anagram of "toffee"
"Buckethead" is an anagram of "DeathCubeK"
*/

using System.Linq;

namespace CodeWars
{
    public class AnagramDetection
    {
        public static bool IsAnagram(string test, string original)
        {
            return (test + original).ToLower().Aggregate(0, (acc, next) => acc ^ next) == 0;
            //return test.ToLower().OrderBy(c => c).SequenceEqual(original.ToLower().OrderBy(c => c));
        }
    }
}