/*
https://www.codewars.com/kata/57cc847e58a06b1492000264/csharp

7 kyu
Sort and Transform

Given an array of numbers, return a string made up of four parts:

a) a four character 'word', made up of the characters derived from the first two and last two numbers in the array. 
order should be as read left to right (first, second, second last, last),

b) the same as above, post sorting the array into ascending order,

c) the same as above, post sorting the array into descending order,

d) the same as above, post converting the array into ASCII characters and sorting alphabetically.

The four parts should form a single string, each part separated by a hyphen: '-'

example format of solution: 'asdf-tyui-ujng-wedg'
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class KataSortTransform
    {
        public static string SortTransform(int[] arr)
        {
            string Tfrm(IEnumerable<int> a) => string.Concat(a.Select(x => (char) x)).Remove(2, a.Count() - 4);
            return string.Format("{0}-{1}-{2}-{1}", Tfrm(arr), Tfrm(arr.OrderBy(x => x)), Tfrm(arr.OrderBy(x => -x)));
        }
    }
}