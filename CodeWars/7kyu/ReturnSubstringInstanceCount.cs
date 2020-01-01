/*
https://www.codewars.com/kata/return-substring-instance-count/train/csharp
https://www.codewars.com/kata/5168b125faced29f66000005/solutions/csharp

7 kyu
Return substring instance count

Complete the solution so that it returns the number of times the search_text is found within the full_text.

Usage example:
Kata.SubstringCount("aa_bb_cc_dd_bb_e", "bb") // should return 2 since bb shows up twice
Kata.SubstringCount("aaabbbccc", "bbb") // should return 1
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class ReturnSubstringInstanceCount
    {
        // public static int SubstringCount(string fullText, string searchText)
        // {
        //     return fullText.Split(searchText).Length - 1;
        // }

        // public static int SubstringCount(string fullText, string searchText) => Regex.Matches(fullText, searchText).Count;

        public static int SubstringCount(string t, string s) => Regex.Matches(t, s).Count;
    }
}