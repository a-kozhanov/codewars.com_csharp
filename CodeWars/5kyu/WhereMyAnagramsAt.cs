/*
https://www.codewars.com/kata/523a86aa4230ebb5420001e1/csharp

5 kyu
Where my anagrams at?

What is an anagram? Well, two words are anagrams of each other if they both contain the same letters. 
For example:
'abba' & 'baab' == true
'abba' & 'bbaa' == true
'abba' & 'abbba' == false
'abba' & 'abca' == false

Write a function that will find all the anagrams of a word from a list. 
You will be given two inputs a word and an array with words. 
You should return an array of all the anagrams or an empty array if there are none. 

For example:
anagrams('abba', ['aabb', 'abcd', 'bbaa', 'dada']) => ['aabb', 'bbaa']
anagrams('racer', ['crazer', 'carer', 'racar', 'caers', 'racer']) => ['carer', 'racer']
anagrams('laser', ['lazing', 'lazy',  'lacer']) => []
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class WhereMyAnagramsAt
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            //return words.Where(s => string.Concat(s.OrderBy(c => c)) == string.Concat(word.OrderBy(c => c))).ToList();
            //return words.FindAll(s => string.Concat(s.OrderBy(c => c)) == string.Concat(word.OrderBy(c => c)));
            //return words.Where(s => s.OrderBy(c => c).SequenceEqual(word.OrderBy(c => c))).ToList();
            return words.FindAll(s => s.OrderBy(c => c).SequenceEqual(word.OrderBy(c => c)));
        }
    }
}