/*
https://www.codewars.com/kata/alphabetical-addition/train/csharp
https://www.codewars.com/kata/5d50e3914861a500121e1958/solutions/csharp

7 kyu
Alphabetical Addition

Your task is to add up letters to one letter.

The function will be given an array of letters (chars), each one being a letter to add. Return a char.

Notes:
Letters will always be lowercase.
Letters can overflow (see second to last example of the description)
If no letters are given, the function should return 'z'
Examples:
AddLetters(new char[] {'a', 'b', 'c'}) = 'f'
AddLetters(new char[] {'a', 'b'}) = 'c'
AddLetters(new char[] {'z'}) = 'z'
AddLetters(new char[] {'z', 'a'}) = 'a'
AddLetters(new char[] {'y', 'c', 'b'}) = 'd' // notice the letters overflowing
AddLetters(new char[] {}) = 'z'
Confused? Roll your mouse/tap over here
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class AlphabeticalAddition
    {
        public static char AddLetters(char[] letters)
        {
            var chrCode = letters.Sum(c => c - 96) + 96;
            while (chrCode > 122) chrCode -= 26;
            return letters.Length == 0 ? 'z' : (char) chrCode;
        }


        // public static char AddLetters(char[] letters) 
        // {
        //     var val = letters.Sum(c => c-96) % 26;
        //     return val == 0 ? 'z' : (char)(val + 96);
        // }


        // public static char AddLetters(char[] l, string al = "zabcdefghijklmnopqrstuvwxy") =>
        //     al[l.Sum(e => al.IndexOf(e)) % 26];


        // public static char AddLetters(char[] letters) {
        //
        //     int summ = letters.Sum((c) => c % ('a' - 1));
        //     if ((summ % ('z' - '`')) == 0)
        //     {
        //         summ = 'z' - '`';
        //     }
        //     else
        //     {
        //         summ %= ('z' - '`');
        //     }
        //     return (char)(summ + '`');
        // }


        // public static char AddLetters(char[] letters) {
        //     if(letters.Length == 0)
        //         return 'z';
        //
        //     string alphabet = "abcdefghijklmnopqrstuvwxyz";
        //
        //     int sum = 0;
        //     for(int i = 0; i<letters.Length; i++)
        //     {
        //         sum += (alphabet.IndexOf(letters[i])+1);
        //     }
        //     while(sum > 26)
        //     {
        //         sum = sum-26;
        //     }
        //
        //     return alphabet[sum-1];
        // }


        // public static char AddLetters(char[] letters)
        // {
        //     var result = 0;
        //
        //     foreach (var letter in letters)
        //     {
        //         result += letter - 96;
        //     }
        //
        //     result %= 26;
        //
        //     return result == 0 ? 'z' : (char) (result + 96);
        // }


        // public static char AddLetters(char[] letters)
        // {
        //     int sum = 0;
        //     foreach (char c in letters)
        //     {
        //         sum += c - 96;
        //     }
        //
        //     return sum % 26 != 0 ? (char) (sum % 26 + 96) : 'z';
        // }


        // public static char AddLetters(char[] letters)
        // {
        //     return (letters.Sum(e => e - 96) % 26) + 96 == '`'
        //         ? 'z'
        //         : Convert.ToChar((letters.Sum(e => e - 96) % 26) + 96);
        // }


        // public static char AddLetters(char[] letters)
        // {
        //     int sum = 0;
        //     foreach (var c in letters)
        //     {
        //         sum += (int) c - 96;
        //     }
        //
        //     return sum % 26 == 0 ? 'z' : (char) ((sum % 26) + 96);
        // }


        // public static char AddLetters(char[] letters)
        // {
        //     int sum = letters.Sum(s => (int) s - 96);
        //     int z = sum % 26;
        //     return z != 0 ? (char) (z + 96) : 'z';
        // }


        // public static char AddLetters(char[] letters)
        // {
        //     return "zabcdefghijklmnopqrstuvwxy"[
        //         letters.Aggregate(0, (x, y) => (x + "zabcdefghijklmnopqrstuvwxy".IndexOf(y)) % 26)];
        // }
    }
}