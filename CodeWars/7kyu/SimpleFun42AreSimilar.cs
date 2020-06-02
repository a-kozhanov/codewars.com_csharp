/*
https://www.codewars.com/kata/588820169ab1e053240000e0/csharp

7 kyu
Simple Fun #42: Are Similar?

Task
Two arrays are called similar if one can be obtained from another by swapping at most one pair of elements.

Given two arrays, check whether they are similar.

Example
For A = [1, 2, 3] and B = [1, 2, 3], the output should be true;

For A = [1, 2, 3] and B = [2, 1, 3], the output should be true;

For A = [1, 2, 2] and B = [2, 1, 1], the output should be false.

Input/Output
[input] integer array A

Array of integers.

Constraints: 3 ≤ A.length ≤ 10000, 1 ≤ A[i] ≤ 1000.

[input] integer array B

Array of integers of the same length as A.

Constraints: B.length = A.length, 1 ≤ B[i] ≤ 1000.

[output] a boolean value

true if A and B are similar, false otherwise.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class SimpleFun42AreSimilar
    {
        public bool AreSimilar(int[] a, int[] b)
        {
            //return a.OrderBy(x => x).SequenceEqual(b.OrderBy(x => x)) && a.Where((x, y) => x != b[y]).Count() <= 2;
            //return a.Sum() == b.Sum() && a.Zip(b, (left, right) => left == right ? 0 : 1).Sum() < 3;
            return a.Sum() == b.Sum() && a.Where((x, y) => x != b[y]).Count() < 3;
        }
    }
}