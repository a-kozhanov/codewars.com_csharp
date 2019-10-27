using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://www.codewars.com/kata/vowel-count/train/csharp
//https://www.codewars.com/kata/54ff3102c1bad923760001f3/solutions/csharp

//Vowel Count
//Return the number(count) of vowels in the given string.
//We will consider a, e, i, o, and u as vowels for this Kata.
//The input string will only consist of lower case letters and/or spaces.


namespace CodeWars
{
    public class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            return str.Count(c => vowels.Contains(c));
        }

        //All Solutions
        //public static int GetVowelCount(string str)
        //{
        //    return str.Count(i => "aeiou".Contains(i));
        //}

    }
}
