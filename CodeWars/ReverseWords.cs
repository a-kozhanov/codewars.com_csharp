/*
https://www.codewars.com/kata/reverse-words/train/csharp
https://www.codewars.com/kata/5259b20d6021e9e14c0010d4/solutions/csharp

7 kyu
Reverse words

Complete the function that accepts a string parameter, 
and reverses each word in the string. 
All spaces in the string should be retained.

Examples
"This is an example!" ==> "sihT si na !elpmaxe"
"double  spaces"      ==> "elbuod  secaps"
*/

using System.Linq;

namespace CodeWars
{
    public class KataReverseWords
    {
        public static string ReverseWords(string str)
        {
            return string.Join(" ", str.Split().Select(w => string.Concat(w.Reverse())));
            //return string.Join(" ", str.Split(' ').Select(i => new string(i.Reverse().ToArray())));
        }
    }
}