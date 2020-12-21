/*
https://www.codewars.com/kata/56cafdabc8cfcc3ad4000a2b/csharp

7 kyu
Binary scORe

Objective
Given a number n we will define its scORe to be 0 | 1 | 2 | 3 | ... | n, where | is the bitwise OR operator.

Write a function that takes n and finds it's scORe.

n	scORe n
0	0
1	1
49	63
1000000	1048575
Any feedback would be much appreciated
*/

using System;
using System.Numerics;

namespace CodeWars
{
    public class BinaryScORe
    {
        public static BigInteger Score(BigInteger n)
        {
            // for (BigInteger i = 1; i < n; i <<= 1)
            // {
            //     n |= i;
            // }
            // return n;

            //return n > 0 ? BigInteger.Pow(new BigInteger(2), (int) BigInteger.Log(n, 2) + 1) - 1 : n;
            return BigInteger.Pow(2, (int) Math.Ceiling(BigInteger.Log(n + 1, 2))) - 1;
        }
    }
}