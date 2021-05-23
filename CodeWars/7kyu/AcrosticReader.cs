/*
https://www.codewars.com/kata/59b843b58bcb7766660000f6/csharp

7 kyu
Acrostic reader

An acrostic is a text in which the first letter of each line spells out a word. 
It is also a quick and cheap way of writing a poem for somebody, as exemplified below :

Write a program that reads an acrostic to identify the "hidden" word. Specifically, 
your program will receive a list of words (reprensenting an acrostic) and will need to return a string corresponding to the word that is spelled out by taking the first letter of each word in the acrostic.
*/

using System.Linq;

namespace CodeWars
{
    public class AcrosticReader
    {
        public static string ReadOut(string[] acrostic)
        {
            // return acrostic.Aggregate("", (a, b) => a + b.First());
            // return string.Concat(acrostic.Select(v => v[0]));
            // return acrostic.Aggregate("", (a, b) => a + b[0]);
            return string.Concat(acrostic.Select(s => s[0]));
        }
    }
}