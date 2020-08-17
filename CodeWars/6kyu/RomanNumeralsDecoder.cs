/*
https://www.codewars.com/kata/51b6249c4612257ac0000005/csharp

6 kyu
Roman Numerals Decoder

Create a function that takes a Roman numeral as its argument and returns its value as a numeric decimal integer. 
You don't need to validate the form of the Roman numeral.

Modern Roman numerals are written by expressing each decimal digit of the number to be encoded separately, 
starting with the leftmost digit and skipping any 0s. 
So 1990 is rendered "MCMXC" (1000 = M, 900 = CM, 90 = XC) and 2008 is rendered "MMVIII" (2000 = MM, 8 = VIII). 
The Roman numeral for 1666, "MDCLXVI", uses each letter in descending order.

Example:
RomanDecode.Solution("XXI") -- should return 21

Help:
Symbol    Value
I          1
V          5
X          10
L          50
C          100
D          500
M          1,000

Courtesy of rosettacode.org
*/

using System;
using System.Collections.Generic;
using System.Linq;
using static System.Text.RegularExpressions.Regex;

namespace CodeWars
{
    public class RomanNumeralsDecoder
    {
        public static int Conv(char ch)
        {
            return ch switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => 0
            };
        }

        public static int Solution(string roman) => roman.Select(x => new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000},
            }[x]).Concat(new[]
            {
                -Match(roman, "IV|IX").Length,
                -Match(roman, "XL|XC").Length * 10,
                -Match(roman, "CD|CM").Length * 100
            })
            .Sum();


        public static int Solution1(string roman)
        {
            return roman.Select(x => new Dictionary<char, int>
                {
                    {'I', 1},
                    {'V', 5},
                    {'X', 10},
                    {'L', 50},
                    {'C', 100},
                    {'D', 500},
                    {'M', 1000},
                }[x]).Concat(new[]
                {
                    -Match(roman, "IV|IX").Length,
                    -Match(roman, "XL|XC").Length * 10,
                    -Match(roman, "CD|CM").Length * 100
                })
                .Sum();


            // return roman.Reverse().Aggregate(0, (i, c) => i + (Conv(c) * 3 < i ? -Conv(c) : Conv(c)));

            // return roman.Select(x =>
            //     {
            //         return x switch
            //         {
            //             'I' => 1,
            //             'V' => 5,
            //             'X' => 10,
            //             'L' => 50,
            //             'C' => 100,
            //             'D' => 500,
            //             'M' => 1000,
            //             _ => 0
            //         };
            //     }).Concat(new[]
            //     {
            //         -Regex.Match(roman, "IV|IX").Length,
            //         -Regex.Match(roman, "XL|XC").Length * 10,
            //         -Regex.Match(roman, "CD|CM").Length * 100
            //     })
            //     .Sum();


            // return roman.Select(x =>
            //     {
            //         return x switch
            //         {
            //             'I' => 1,
            //             'V' => 5,
            //             'X' => 10,
            //             'L' => 50,
            //             'C' => 100,
            //             'D' => 500,
            //             'M' => 1000,
            //             _ => 0
            //         };
            //     }).Append(-Regex.Match(roman, "IV|IX").Length)
            //     .Append(-Regex.Match(roman, "XL|XC").Length * 10)
            //     .Append(-Regex.Match(roman, "CD|CM").Length * 100)
            //     .Sum();
        }
    }
}