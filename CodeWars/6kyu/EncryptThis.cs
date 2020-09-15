/*
https://www.codewars.com/kata/5848565e273af816fb000449/csharp

6 kyu
Encrypt this!

Acknowledgments:
I thank yvonne-liu for the idea and for the example tests :)

Description:
Encrypt this!

You want to create secret messages which can be deciphered by the Decipher this! kata. Here are the conditions:

Your message is a string containing space separated words.
You need to encrypt each word in the message using the following rules:
The first letter needs to be converted to its ASCII code.
The second letter needs to be switched with the last letter
Keepin' it simple: There are no special characters in input.
Examples:
Kata.EncryptThis("Hello") == "72olle"
Kata.EncryptThis("good") == "103doo"
Kata.EncryptThis("hello world") == "104olle 119drlo"
*/


using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class KataEncryptThis
    {
        public static string EncryptThis(string input)
        {
            //return string.Join(" ", input.Split().Select(x => Regex.Replace(x, @"^(.)(.?)(.*?)(.?)$", m => (int) m.Groups[1].Value[0] + m.Groups[4].Value + m.Groups[3].Value + m.Groups[2].Value)));
            //return string.Join(" ", input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => $"{(int) x[0]}{Regex.Replace(x.Substring(1), "(.)(.*)(.)", "$3$2$1")}"));
            //return string.Join(" ", input.Split().Where(x => x != "").Select(x => $"{(int) x[0]}{Regex.Replace(x.Substring(1), "(.)(.*)(.)", "$3$2$1")}"));

            return string.Join(" ",
                input.Split().Where(x => x != "")
                    .Select(x => $"{(int) x[0]}{Regex.Replace(x[1..], "(.)(.*)(.)", "$3$2$1")}"));
        }
    }
}