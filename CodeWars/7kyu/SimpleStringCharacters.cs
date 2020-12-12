/*
https://www.codewars.com/kata/5a29a0898f27f2d9c9000058/csharp

7 kyu
Simple string characters

In this Kata, you will be given a string and your task will be to return a list of ints detailing the count of uppercase letters, lowercase, numbers and special characters, as follows.

Solve("*'&ABCDabcde12345") = [4,5,5,3]. 
--the order is: uppercase letters, lowercase, numbers and special characters.
More examples in the test cases.

Good luck!
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class SimpleStringCharacters
    {
        public static int[] solve(String s)
        {
            return new[]
            {
                s.Count(char.IsUpper),
                s.Count(char.IsLower),
                s.Count(char.IsDigit),
                s.Count(x => !char.IsLetterOrDigit(x))
            };
        }
    }
}