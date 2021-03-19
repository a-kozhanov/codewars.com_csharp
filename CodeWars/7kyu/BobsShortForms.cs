/*
https://www.codewars.com/kata/570cbe88f616a8f4f50011ac/csharp

7 kyu
Bob's Short Forms

Bob is a theoretical coder - he doesn't write code, but comes up with theories, formulas and algorithm ideas. 
You are his secretary, and he has tasked you with writing the code for his newest project - a method for making the short form of a word. 
Write a function shortForm(C# ShortForm, Python short_form) that takes a string and returns it converted into short form using the rule: 
Remove all vowels, except for those that are the first or last letter. 
Do not count 'y' as a vowel, and ignore case. 
Also note, the string given will not have any spaces; only one word, and only Roman letters.

Example:

shortForm("assault");
short_form("assault")
ShortForm("assault");
// should return "asslt"


Also, FYI: I got all the words with no vowels from
https://en.wikipedia.org/wiki/English_words_without_vowels
*/

using System.Text.RegularExpressions;

namespace CodeWars
{
    public class BobsShortForms
    {
        public string ShortForm(string str)
        {
            // return Regex.Replace(str, "(?<!^)([aouei])(?<!$)", string.Empty, RegexOptions.IgnoreCase);
            // return Regex.Replace(str, @"(?<=[^\^])[aeuio](?=[^$])", "", RegexOptions.IgnoreCase);
            // return Regex.Replace(str, @"(?<!\A)[aeiou](?!\z)", "", RegexOptions.IgnoreCase);
            // return Regex.Replace(str, @"(?<!^)[aeiouAEIOU](?!$)", "");
            // return Regex.Replace(str, @"(?i)(?<=.)[euioa](?=.)", "");
            // return Regex.Replace(str, "(?<!^)[aeouiAEOUI](?!$)", "");
            // return Regex.Replace(str, @"(?i)\B([aouei])\B", "");
            return Regex.Replace(str, @"(?i)\B[aeuoi]\B", "");
        }
    }
}