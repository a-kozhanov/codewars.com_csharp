//https://www.codewars.com/kata/invert-values/train/csharp

// 8 kyu
// Invert values

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
            return Array.ConvertAll(input, i => -i);
            //return input.Select(x => -x).ToArray();
        }
    }
}