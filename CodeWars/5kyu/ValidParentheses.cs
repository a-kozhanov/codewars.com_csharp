/*
https://www.codewars.com/kata/52774a314c2333f0a7000688/csharp

5 kyu
Valid Parentheses

Write a function called that takes a string of parentheses, and determines if the order of the parentheses is valid. 
The function should return true if the string is valid, and false if it's invalid.

Examples
"()"              =>  true
")(()))"          =>  false
"("               =>  false
"(())((()())())"  =>  true
Constraints
0 <= input.length <= 100

Along with opening (() and closing ()) parenthesis, input may contain any valid ASCII characters. 
Furthermore, the input string may be empty and/or not contain any parentheses at all. 
Do not treat other forms of brackets as parentheses (e.g. [], {}, <>).
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class KataValidParentheses
    {
        public static bool ValidParentheses(string input)
        {
            input = string.Concat(input.Where(x => "()".Contains(x)));
            while (input.Contains("()"))
            {
                input = input.Replace("()", "");
            }

            return !input.Any();
        }
    }
}