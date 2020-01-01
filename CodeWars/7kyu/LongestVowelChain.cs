/*
https://www.codewars.com/kata/longest-vowel-chain/train/csharp
https://www.codewars.com/kata/59c5f4e9d751df43cf000035/solutions/csharp

7 kyu
Longest vowel chain

The vowel substrings in the word codewarriors are o,e,a,io. 
The longest of these has a length of 2. 
Given a lowercase string that has alphabetic characters only and no spaces, 
return the length of the longest vowel substring. 
Vowels are any of aeiou.

Documentation:
Kata.Solve Method (String)
Returns the length of the greatest continuous vowel substring in a string.

Syntax
public static int Solve(
string str
)
Parameters
str
Type: System.String
The string to be processed.

Return Value
Type: System.Int32
The length of the greatest continuous vowel substring in str, or 0 if str contains no vowels.

Exceptions
Exception	Condition
ArgumentNullException	str is null.

Good luck!

If you like substring Katas, please try:
Non-even substrings
Vowel-consonant lexicon
*/

using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class LongestVowelChain
    {
        public static int Solve(string str) => Regex.Split(str, "[^aeiou]+").Max(e => e.Length);

        // public static int Solve(string str)
        // {
        //     int result = 0;
        //     int len = 0;
        //     HashSet<char> v = new HashSet<char> {'a', 'e', 'i', 'o', 'u'};
        //
        //     foreach (char t in str)
        //     {
        //         if (v.Contains(t))
        //         {
        //             len++;
        //             if (l > result) result = len;
        //         }
        //         else
        //         {
        //             len = 0;
        //         }
        //     }
        //
        //     return result;
        // }
    }
}

// return Regex.Split(str, "[^aeiou]+")
// .Select(e => e.Length)
// .Max();


// char[] chrs = new char[] { 'a', 'e', 'u', 'i', 'o' };
// var split = str.Split(str.Where(c => !chrs.Contains(c)).ToArray());
// return split.Max(s => s.Length);

// public static int Solve(string str) => str.Split("qwrtypsdfghjklzxcvbnm".ToCharArray()).Select(i=>i.Length).Max();


// public static int Solve(string str)=>Regex.Matches(str, "(a|e|i|o|u)+").Count()>0?
// Regex.Matches(str, "(a|e|i|o|u)+").Select(t => t.Value.Length).Max():0;


// public static int Solve(string str)
// {
// for(int i = str.Length; i>0; --i)
// {
//     if (Regex.IsMatch(str, $"[aeiou]{{{i}}}"))
//         return i;
// }
// return 0;
// }


// public static int Solve(string str)
// {
// var vowelChains = str.Split(new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' }, StringSplitOptions.None).Where(x => x != string.Empty);
//     return vowelChains.Any() ? vowelChains.OrderByDescending(y => y.Length).First().Length : 0;
// }