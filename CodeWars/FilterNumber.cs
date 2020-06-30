/*
https://www.codewars.com/kata/55b051fac50a3292a9000025/csharp

7 kyu
Filter the number

Oh no! The number has been mixed up with the text. Your goal is to retreive the number from the text, 
can you return the number back to it's original state?

Task
Your task is to return a number from a string.

Details
You will be given a string of numbers and letters mixed up, 
you have to return all the numbers in that string in the order they occur.
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class FilterNumber
    {
        public static int FilterString(string s)
        {
            //return int.Parse(new string(s.Where(char.IsDigit).ToArray()));
            return int.Parse(string.Concat(s.Where(char.IsNumber)));
            //return int.Parse(string.Concat(s.Where(char.IsDigit)));
            //return int.Parse(Regex.Replace(s, @"\D", ""));
        }
    }
}