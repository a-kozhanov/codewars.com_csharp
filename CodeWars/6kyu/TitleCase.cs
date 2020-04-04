/*
https://www.codewars.com/kata/title-case/train/csharp

6 kyu
Title Case

A string is considered to be in title case if each word in the string is either(a)
capitalised(that is, only the first letter of the word is in upper case) or(b) considered
to be an exception and put entirely into lower case unless it is the first word, which is always capitalised.

Write a function that will convert a string into title case, given an optional list of
exceptions (minor words). The list of minor words will be given as a string with each
word separated by a space. Your function should ignore the case of the minor words
string -- it should behave in the same way even if the case of the minor word string is changed.

###Arguments (Haskell)
First argument: space-delimited list of minor words that must always be lowercase except for the first word in the string.
Second argument: the original string to be converted.

###Arguments (Other languages)
First argument (required): the original string to be converted.
Second argument (optional): space-delimited list of minor words that must always be lowercase except
for the first word in the string. The JavaScript/CoffeeScript tests will pass undefined when this argument is unused.

###Example
Kata.TitleCase("a an the of", "a clash of KINGS") => "A Clash of Kings"
Kata.TitleCase("The In", "THE WIND IN THE WILLOWS") => "The Wind in the Willows"
Kata.TitleCase("the quick brown fox")               => "The Quick Brown Fox"
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public static class TitleCase
    {
        public static string titleCase(string title, string minorWords = "")
        {
            return string.Join(" ", title.ToLower().Split().Select((w, i) =>
                !$"{minorWords}".ToLower().Split().Contains(w) || i == 0
                    ? string.Concat(w.Take(1)).ToUpper() + string.Concat(w.Skip(1))
                    : w).ToArray());
        }

        // public static string TitleCase(string title, string minorWords = "")
        // {
        //     string[] minors = String.IsNullOrEmpty(minorWords)
        //         ? new string[0]
        //         : minorWords.Split().Select(w => w.ToLower()).ToArray();
        //     return string.Join(" ",
        //         title.Split().Select((w, i) =>
        //             i == 0 || Array.IndexOf(minors, w.ToLower()) == -1
        //                 ? CultureInfo.CurrentCulture.TextInfo.ToTitleCase(w.ToLower())
        //                 : w.ToLower()));
        // }


        // public static string TitleCase(string title, string minorWords = "")
        // {
        //     return string.IsNullOrWhiteSpace(title)
        //         ? title
        //         : string.Join(" ", title.Split(" ").Select((x, i) =>
        //         {
        //             if (i == 0 || string.IsNullOrWhiteSpace(minorWords) || !minorWords.Split(" ")
        //                 .Any(y => y.Equals(x, StringComparison.InvariantCultureIgnoreCase)))
        //             {
        //                 return $"{x[0].ToString().ToUpper()}{x.Substring(1).ToLower()}";
        //             }
        //
        //             return x.ToLower();
        //         }));
        // }


        // public static string TitleCase(string title, string minorWords = "")
        // {
        //     if (string.IsNullOrEmpty(title))
        //         return title;
        //     var minor = new HashSet<string>(minorWords?.ToLower()?.Split() ?? new string[0]);
        //     return string.Join(" ",
        //         title.ToLower().Split().Select((w, i) =>
        //             minor.Contains(w) && i != 0 ? w : char.ToUpper(w[0]) + w.Substring(1)));
        // }

        // public static string TitleCase(string title, string minorWords = "")
        // {
        //     return Regex.Replace(title.ToLower(),
        //         @"(?<=^|\s" + (string.IsNullOrWhiteSpace(minorWords)
        //             ? null
        //             : $@"(?!({minorWords.Replace(' ', '|')})(\s|$))") + @")(\w)", a => a.Value.ToUpper(),
        //         RegexOptions.IgnoreCase);
        // }

        // public static string TitleCase(string title, string minorWords = "")
        // {
        //     var minor = string.IsNullOrEmpty(minorWords)
        //         ? new string[] { }
        //         : minorWords.Split(' ').Select(w => w.ToLower());
        //     return string.IsNullOrEmpty(title)
        //         ? ""
        //         : string.Join(' ',
        //             title.Split(' ').Select((w, i) =>
        //                 minor.Contains(w.ToLower()) && i != 0
        //                     ? w.ToLower()
        //                     : char.ToUpper(w.First()) + w.Substring(1).ToLower()));
        // }
    }
}