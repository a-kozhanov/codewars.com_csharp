/*
https://www.codewars.com/kata/5888514674b58e929a000036/train/csharp

7 kyu
Simple Fun #49: Decipher

Task
Consider the following ciphering algorithm:

For each character replace it with its code.
Concatenate all of the obtained numbers.
Given a ciphered string, return the initial one if it is known that it consists only of lowercase letters.

Note: here the character's code means its decimal ASCII code, the numerical representation of a character used by most modern programming languages.

Example
For cipher = "10197115121", the output should be "easy".

Explanation:

 charCode('e') = 101, 
 charCode('a') = 97, 
 charCode('s') = 115 
 charCode('y') = 121.
Input/Output
[input] string cipher

A non-empty string which is guaranteed to be a cipher for some other string of lowercase letters.

[output] a string
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class SimpleFun49Decipher
    {
        public string Decipher(string cipher)
        {
            //97-122
            //(1[0-2][0-9])|([1-9][0-9])|[1-9]
            //97|98|99|1[0-1][0-9]|12[0-2]
            //[9][0-9]|1[0-2][0-9]
            //9\\d|1\\d\\d
            //9[7-9]|1\d{2}
            //9[7-9]|\d{3}

            //return string.Concat(Regex.Matches(cipher, @"9[7-9]|\d{3}").Select(x => char.ConvertFromUtf32(int.Parse(x.Value))));
            //return string.Concat(Regex.Matches(cipher, @"9[7-9]|\d{3}").Select(x => (char) int.Parse(x.Value)));
            //return Regex.Replace(cipher, @"9[7-9]|\d{3}", m => char.ConvertFromUtf32(int.Parse(m.Value)));
            //return Regex.Replace(cipher, @"9[7-9]|\d{3}", m => ((char) int.Parse(m.Value)).ToString());
            return Regex.Replace(cipher, @"9[7-9]|\d{3}", m => $"{(char) int.Parse(m.Value)}");
        }
    }
}