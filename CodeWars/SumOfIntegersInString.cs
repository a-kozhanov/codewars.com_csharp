/*
https://www.codewars.com/kata/598f76a44f613e0e0b000026/train/csharp

7 kyu
Sum of integers in string

Your task in this kata is to implement a function that calculates the sum of the integers inside a string. 
For example, in the string "The30quick20brown10f0x1203jumps914ov3r1349the102l4zy dog", the sum of the integers is 3635.

Note: only positive integers will be tested.
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class KataSumOfIntegersInString
    {
        public static int SumOfIntegersInString(string s)
        {
            //return Regex.Split(s, "\\D").Where(x => x != "").Sum(int.Parse);
            return Regex.Matches(s, "\\d+").Sum(x => int.Parse(x.Value));
        }
    }
}