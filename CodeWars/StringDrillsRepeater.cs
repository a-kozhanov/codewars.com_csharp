using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://www.codewars.com/kata/thinkful-string-drills-repeater/train/csharp
//https://www.codewars.com/kata/thinkful-string-drills-repeater/solutions/csharp

//Write a function named repeater() that takes two arguments(a string and a number), and returns a new string where the input string is repeated that many times.

//Example:
//Repeater.repeat("a", 5)
//should return

//"aaaaa"


namespace CodeWars
{
    public class StringDrillsRepeater
    {
        public static string Repeater(string s, int n)
        {
            //return new string(char.Parse(s), n);
            return string.Concat(Enumerable.Repeat(s, n));
        }
    }
}
