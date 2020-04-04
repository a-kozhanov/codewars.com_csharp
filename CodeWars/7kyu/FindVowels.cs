/*
https://www.codewars.com/kata/5680781b6b7c2be860000036/train/csharp

7 kyu
Find the vowels

We want to know the index of the vowels in a given word, for example, 
there are two vowels in the word super (the second and fourth letters).

So given a string "super", we should return a list of [2, 4].

Some examples:
Mmmm  => []
Super => [2,4]
Apple => [1,5]
YoMama -> [1,2,4,6]
*NOTE: Vowels in this context refers to English Language Vowels - a e i o u y *

NOTE: this is indexed from [1..n] (not zero indexed!)
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class FindVowels
    {
        public static int[] VowelIndices(string word)
        {
            //return word.ToLower().Select((x, i) => "aeiouy".Contains(x) ? ++i : -1).Where(x => x > -1).ToArray();
            //return Enumerable.Range(1, word.Length).Where(i => "aeiouyAEIOUY".Contains(word[i - 1])).ToArray();
            //return Enumerable.Range(1, word.Length).Where(i => "aeiouy".Contains(word.ToLower()[i - 1])).ToArray();
            //return Enumerable.Range(1, word.Length).Where(i => "aoueiyAEIOUY".Contains(word[i - 1])).ToArray();
            //return word.Select((x, i) => i + 1).Where((x, j) => "aoueiy".Contains(word.ToLower()[j])).ToArray();
            //return word.Select((x, i) => i + 1).Where((x, j) => "aoueiy".Contains(word.ToLower()[j])).ToArray();
            //return word.Select((x, i) => ++i).Where((x, i) => "aoueiyAEIOUY".Contains(word[i])).ToArray();

            //return word.Select((x, i) => ++i).Where(x => "aoueiyAEIOUY".Contains(word[x - 1])).ToArray();
            return Regex.Matches(word, "(?i)[aeiouy]").Select(m => m.Index + 1).ToArray();
        }
    }
}