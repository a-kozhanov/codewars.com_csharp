/*
https://www.codewars.com/kata/59a96d71dbe3b06c0200009c/csharp

7 kyu
Build a square

I will give you an integer. Give me back a shape that is as long and wide as the integer. 
The integer will be a whole number between 1 and 50.

Example
n = 3, so I expect a 3x3 square back just like below as a string:

+++
+++
+++
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class BuildSquare
    {
        public static string GenerateShape(int n)
        {
            //return string.Concat(Enumerable.Repeat((string.Concat(Enumerable.Repeat("+", n)) + '\n'), n)).TrimEnd('\n');
            //return string.Join("\n", new string[n].Select(_ => new string('+', n)));
            //return string.Join("\n", Enumerable.Repeat(new string('+', n), n));
            //return string.Join("\n", Enumerable.Repeat("".PadRight(n, '+'), n));
            return string.Join("\n", Enumerable.Repeat("".PadLeft(n, '+'), n));
        }
    }
}