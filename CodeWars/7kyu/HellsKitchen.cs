/*
https://www.codewars.com/kata/57d1f36705c186d018000813/csharp

7 kyu
Hells Kitchen

Gordon Ramsay shouts. He shouts and swears. There may be something wrong with him.

Anyway, you will be given a string of four words. Your job is to turn them in to Gordon language.

Rules:
Obviously the words should be Caps, Every word should end with '!!!!', 
Any letter 'a' or 'A' should become '@', Any other vowel should become '*'.

*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class HellsKitchen
    {
        public static string Gordon(string a)
        {
            return Regex.Replace(Regex.Replace(a.ToUpper(), @"[EIOU]", "*"), @"\s|$", "!!!!$0").Replace("A", "@");
            //return Regex.Replace(Regex.Replace(a.ToUpper(), @"\b(?<=\w)", "!!!!"), @"[AEIOU]", t => "" + t == "A" ? "@" : "*");

            //return string.Join(" ", a.Split(' ').Select(x => Regex.Replace(x.ToUpper().Replace('A', '@'), "[IEOU]", "*") + "!!!!"));

            //return Regex.Replace(Regex.Replace(a.ToUpper().Replace("A", "@"), @"[EIOU]", "*"), @"\s|$", "!!!!$0");

            // return Regex.Replace(Regex.Replace(a.ToUpper().Replace(" ", "!!!! "), @"[Aa]", "@") + "!!!!", @"[AEIOU]", "*");


            // return string.Join(" ", a.Split(" ").Select(t1 =>
            //     string.Concat(t1.ToUpper().Select(t2 => t2 == 'A' ? '@' : "EIOU".Contains(t2) ? '*' : t2)) + "!!!!"));


            // return string
            //     .Concat(a.Select(c => "eouiu".Contains(c) ? "*" : c == ' ' ? "!!!! " : c == 'a' ? "@" : $"{c}"))
            //     .ToUpper() + "!!!!";

            // return Regex.Replace(Regex.Replace(a.ToUpper(), @"\b(?<=\w)", "!!!!"), @"[AEIOU]",
            //     t => "" + t == "A" ? "@" : "*");


            // return string.Join(" ",
            //     a.ToUpper().Replace('A', '@').Split(' ')
            //         .Select(item => Regex.Replace(item, @"[eiou]", "*", RegexOptions.IgnoreCase))
            //         .Select(str => str + "!!!!"));


            // return Regex.Replace(
            //     a
            //         .ToUpper()
            //         .Replace(" ", "!!!! ")
            //         .Replace("A", "@"),
            //     "[EIOU]",
            //     "*") + "!!!!";


            // return a.ToUpper().Replace("A", "@").Replace("E", "*").Replace("I", "*").Replace("O", "*")
            //     .Replace("U", "*").Replace(" ", "!!!! ") + "!!!!";


            // var arr = a.Split().Select(x => char.ToUpper(x[0]) + x[1..])
            //     .Select(x => x.Replace('a', '@').Replace('A', '@'));
            //Select(x => (char.ToUpper(x[0]) + x[1..] + "!!!!"))


            // var arr = a.Split().Select(x => string.Concat((x.ToUpper() + "!!!!").Select(c =>
            // {
            //     if ("aA".Contains(c)) return '@';
            //     if ("eiouEIOU".Contains(c)) return '*';
            //     return c;
            // })));
            //
            // return string.Join(" ", arr);
        }
    }
}