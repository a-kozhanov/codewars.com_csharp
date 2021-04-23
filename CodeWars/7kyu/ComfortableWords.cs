/*
https://www.codewars.com/kata/56684677dc75e3de2500002b/csharp

7 kyu
Comfortable words

A comfortable word is a word which you can type always alternating the hand you type with (assuming you type using a QWERTY keyboard and use fingers as shown in the image below).

That being said, create a function which receives a word and returns true/True if it's a comfortable word and false/False otherwise.

The word will always be a string consisting of only ascii letters from a to z.

To avoid problems with image availability, here's the lists of letters for each hand:

Left: q, w, e, r, t, a, s, d, f, g, z, x, c, v, b
Right: y, u, i, o, p, h, j, k, l, n, m
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class KataComfortableWords
    {
        public bool ComfortableWord(string word)
        {
            var s = string.Concat(word.Select(c => "yuiophjklnm".Contains(c) ? "R" : "L"));
            return !(s.Contains("LL") || s.Contains("RR"));


            // return !Regex.IsMatch(Regex.Replace(word, @"[qwertasdfgzxcvb]", " "), @"\s{2}|\w{2}");
            // return word.Select((c, i) => "qwertasdfgzxcvb".Contains(c) ? i % 2 : (i + 1) % 2).Distinct().Count() == 1;
        }
    }
}