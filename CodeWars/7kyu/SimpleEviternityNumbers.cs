/*
https://www.codewars.com/kata/5b93f268563417c7ed0001bd/train/csharp

7 kyu
Simple eviternity numbers

An eviternity number is a number which:

contains only digits 8, 5 and 3, and
the count of the digit 8 >= count of digit 5 >= count of digit 3.
The first few eviternity numbers are as follows.

[8, 58, 85, 88, 358, 385, 538, 583, 588, 835, 853, 858, 885, 888]
You will be given two integers, a and b, and your task is to return the number of eviternity numbers in the range >= a and < b.

For example:
solve(0,1000) = 14, because they are [8, 58, 85, 88, 358, 385, 538, 583, 588, 835, 853, 858, 885, 888]
The upper bound will not exceed 500,000.

More examples in test cases. Good luck!
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class SimpleEviternityNumbers
    {
        public static int solve(int a, int b)
        {
            return Enumerable.Range(a, b - a)
                .Select(i => i.ToString())
                //.Where(s => !Regex.IsMatch(s, "[^358]"))
                .Where(s => s.All(v => "358".Contains(v)))
                .Count(s => s.Count(c => c == '8') >= s.Count(c => c == '5') &&
                            s.Count(c => c == '5') >= s.Count(c => c == '3'));
        }
    }
}