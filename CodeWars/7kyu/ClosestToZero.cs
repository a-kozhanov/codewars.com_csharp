/*
https://www.codewars.com/kata/59887207635904314100007b/csharp

7 kyu
Closest to Zero

Simply find the closest value to zero from the list. Notice that there are negatives in the list.

List is always not empty and contains only integers. 
Return None if it is not possible to define only one of such values. 
And of course, we are expecting 0 as closest value to zero.

Examples:

[2, 4, -1, -3]  => -1
[5, 2, -2]      => None
[5, 2, 2]       => 2
[13, 0, -6]     => 0
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class ClosestToZero
    {
        public static int? Closest(int[] arr)
        {
            var min = arr.Distinct().Where(x => Math.Abs(x) == arr.Min(Math.Abs));
            return min.Count() == 1 ? min.First() : (int?) null;
        }
    }
}