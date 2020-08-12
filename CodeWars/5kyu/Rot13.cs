/*
https://www.codewars.com/kata/530e15517bc88ac656000716/csharp

5 kyu
Rot13

ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet. 
ROT13 is an example of the Caesar cipher.

Create a function that takes a string and returns the string ciphered with Rot13. 
If there are numbers or special characters included in the string, they should be returned as they are. 
Only letters from the latin/english alphabet should be shifted, like in the original Rot13 "implementation".
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class KataRot13
    {
        public static string Rot13(string message)
        {
            //return string.Concat(message.Select(c => char.IsLetter(c) ? c >= 65 && c <= 77 || c >= 97 && c <= 109 ? (char) (c + 13) : (char) (c - 13) : c));
            //return string.Concat(message.Select(c => char.IsLetter(c) ? char.ToLower(c) + 13 > 'z' ? (char) (c - 13) : (char) (c + 13) : c));
            return string.Concat(message.Select(c => char.IsLetter(c) ? (char) (c + (char.ToLower(c) > 'm' ? -13 : 13)) : c));
        }
    }
}