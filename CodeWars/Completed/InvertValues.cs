
//https://www.codewars.com/kata/invert-values/train/csharp
//https://www.codewars.com/kata/5899dc03bc95b1bf1b0000ad/solutions/csharp

//Invert values

//Given a set of numbers, return the additive inverse of each.Each positive becomes negatives, and the negatives become positives.
//invert([1,2,3,4,5]) == [-1,-2,-3,-4,-5]
//invert([1,-2,3,-4,5]) == [-1,2,-3,4,-5]
//invert([]) == []

using System;
using System.Linq;

namespace CodeWars
{
    public class InvertNumbers
    {
        public static int[] InvertValues(int[] input)
        {
            return input.Select(x => -x).ToArray();
        }
    }
}