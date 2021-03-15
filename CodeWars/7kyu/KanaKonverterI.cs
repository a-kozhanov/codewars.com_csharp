/*
https://www.codewars.com/kata/574e96deff5b0ab00a000672/csharp

7 kyu
KanaKonverter I

Write a simple converter for vowels.

      Romaji:    a/A e/E i/I u/U o/O
      Hiragana:  あ  え   い  う   お 
      Katakana:  ア  エ   イ  ウ   オ
Expect the above characters as input. There won't be invalid input.

Rules:

If there is no input return an empty string. 
Do not change romaji. (a->a, A->A ... NOT A->a )
Change Kana to lower case romaji. (あ->a ... NOT あ->A)
Input can be mixed, but output should be consistent. (aAあア -> aAaa, for "romaji")
Example 1:

Input: "aeiou" 
Output:"hiragana"

Expected output: "あえいおう"
Example 2:

Input: "AえイOう"
Output:"romaji"

Expected output: "AeiOu"
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class KanaKonverterI
    {
        public static string vowels(string input, string output)
        {
            var dict = new Dictionary<string, string>
            {
                ["romaji"] = "aeiouAEIOU",
                ["hiragana"] = "あえいおうあえいおう",
                ["katakana"] = "アエイオウアエイオウ"
            };
            var all = string.Concat(dict.Values);
            return string.Concat(input.Select(c => dict[output][all.IndexOf(c) % 10]));
        }
    }
}