/*
https://www.codewars.com/kata/580435ab150cca22650001fb/csharp

7 kyu
Find the lucky numbers

Write a function filterLucky/filter_lucky() that accepts a list of integers and filters the list to only include the elements that contain the digit 7.

For example,

ghci> filterLucky [1,2,3,4,5,6,7,68,69,70,15,17]
[7,70,17]
Don't worry about bad input, you will always receive a finite list of integers.
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class FindLuckyNumbers
    {
        public static int[] FilterLucky(int[] x)
        {
            //return x.Where(i => Regex.IsMatch($"{i}", "7")).ToArray();
            //return x.Where(i => $"{i}".IndexOf('7') > -1).ToArray();
            //return x.Where(i => $"{i}".Contains('7')).ToArray();
            return Array.FindAll(x, m => $"{m}".Contains('7'));
        }
    }
}