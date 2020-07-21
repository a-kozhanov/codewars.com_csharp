/*
https://www.codewars.com/kata/5264d2b162488dc400000001/csharp

6 kyu
Stop gninnipS My sdroW!

Write a function that takes in a string of one or more words, and returns the same string, 
but with all five or more letter words reversed (Just like the name of this Kata). 
Strings passed in will consist of only letters and spaces. 
Spaces will be included only when more than one word is present.

Examples: 
spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw" 
spinWords( "This is a test") => returns "This is a test" 
spinWords( "This is another test" )=> returns "This is rehtona test"
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class StopGninnipSMySdroW
    {
        public static string SpinWords(string sentence)
        {
            //return string.Join(" ", sentence.Split().Select(s => s.Length > 4 ? string.Concat(s.Reverse()) : s));
            return Regex.Replace(sentence, @"\w{5,}", m => string.Concat(m.Value.Reverse()));
        }
    }
}