/*
https://www.codewars.com/kata/520b9d2ad5c005041100000f/csharp

5 kyu
Simple Pig Latin

Move the first letter of each word to the end of it, 
then add "ay" to the end of the word. Leave punctuation marks untouched.

Examples
Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
Kata.PigIt("Hello world !");     // elloHay orldway !
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class SimplePigLatin
    {
        public static string PigIt(string str)
        {
            return string.Join(" ", str.Split().Select(x => $"{x[1..]}{x[0]}ay"));
            //return string.Join(" ", str.Split().Select(x => x[1..] + x[0] + "ay"));
            //return Regex.Replace(str, @"\b(\w)(\w+)\b", "$2$1ay");
            //return Regex.Replace(str, @"(\w)(\w+)", @"$2$1ay");
        }
    }
}