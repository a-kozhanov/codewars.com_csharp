/*
https://www.codewars.com/kata/55c2a1ee7fe3ccfee5000058/csharp

7 kyu
Find the Combination

Your objective is to count how many times a certain word or combination of letters or symbols appears inside a string. 
The key is case insensitive and can occur as many or as few times in the string. 
The function declaration is provided for you and there should be two arguments with one return variable that returns the count. 
Overlapping words should not be counted more than once! An empty string cannot be a key. 
The function should also be able to count the number of integers and characters. Think hard!

Example:
Kata.CountCombinations("my name is billy and billy is awesome", "billy"); // 2
Kata.CountCombinations("abcdefghijklmonopolymonorailqrstuv", "mono"); // 2
Kata.CountCombinations("GrEggreGGREGgREG", "greg"); // 4
Kata.CountCombinations("@#$##@@@","@"); // 4
Kata.CountCombinations("wow nothing", "yeah"); // 0
Kata.CountCombinations("lololololol", "lol"); // 3
Kata.CountCombinations("93049", @"\\d"); // 5
Kata.CountCombinations("Five ", @"\."); // 5
Please give feedback and rank! That would be amazing!
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class FindCombination
    {
        public static int CountCombinations(string text, string key)
        {
            return Regex.Matches(text, "(?i)" + key).Count;
            // return Regex.Matches(text.ToLower(), key).Count;
            // return Regex.Matches(text, key, RegexOptions.IgnoreCase).Count;
        }
    }
}