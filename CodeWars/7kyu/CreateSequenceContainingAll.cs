/*
https://www.codewars.com/kata/56523ec6fc8ac62677000005/csharp

7 kyu
Create sequence containing all allowed characters

Define createSequence(regex) function that returns a string of all characters (in ASCII order) matching specified regular expression one-character criterion.

Examples
let digits = /[0-9]/;
// createSequence(digits) === '0123456789'

let hexadecimal = /[0-9A-F]/;
// createSequence(hexadecimal) === '0123456789ABCDEF'
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class CreateSequenceContainingAll
    {
        public string CreateSequence(Regex regex)
        {
            //return string.Concat(Enumerable.Range(0, 128).Select(x => $"{(char) x}").Where((Func<string, bool>)regex.IsMatch));
            //return string.Concat(Enumerable.Range(0, 128).Select(char.ConvertFromUtf32).Where((Func<string, bool>)regex.IsMatch));
            //return string.Concat(regex.Matches(string.Concat(Enumerable.Range(0, 128).Select(x => $"{(char) x}"))));
            //return string.Concat(Enumerable.Range(0, 128).Select(i => $"{(char) i}").Where(x => regex.IsMatch(x)));
            //return string.Concat(Enumerable.Range(0, 128).Select(i => regex.Match(new string((char) i, 1)).Value));
            return string.Concat(Enumerable.Range(0, 128).Select(i => regex.Match($"{(char) i}")));
        }
    }
}