/*
https://www.codewars.com/kata/5809b62808ad92e31b000031/csharp

7 kyu
Basic Math (Add or Subtract)

In this kata, you will do addition and subtraction on a given string. The return value must be also a string.

Note: the input will not be empty.

Examples
"1plus2plus3plus4"  --> "10"
"1plus2plus3minus4" -->  "2"
*/

using System;
using System.Data;
using System.Linq;

namespace CodeWars
{
    public class BasicMathAddOrSubtract
    {
        public static string Calculate(string str)
        {
            return str.Replace("plus", " ").Replace("minus", " -").Split().Sum(int.Parse).ToString();
            // return str.Replace("plus", " +").Replace("minus", " -").Split().Sum(int.Parse).ToString();
            // return new DataTable().Compute(str.Replace("plus", "+").Replace("minus", "-"), null).ToString();
        }
    }
}