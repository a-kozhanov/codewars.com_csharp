/*
https://www.codewars.com/kata/56d3e702fc231fdf72001779/csharp

7 kyu
Binary sXORe

Objective
Given a number n we will define it's sXORe to be 0 XOR 1 XOR 2 ... XOR n where XOR is the bitwise XOR operator.

Write a function that takes n and returns it's sXORe.

Examples
n	sXORe n
0	0
1	1
50	51
1000000	1000000
*/

using System.Numerics;

namespace CodeWars
{
    public class BinarySXORe
    {
        public static BigInteger Sxore(BigInteger n)
        {
            return new[] {n, 1, n + 1, 0}[(int) (n % 4)];
            //return n * ((n & 1) ^ 1) + (((n >> 1) & 1) ^ (n & 1));
            //return new BigInteger[] {n, 1, n + 1, 0}[(int) (n % 4)];
            //return (int) (n % 4) switch {0 => n, 1 => 1, 2 => n + 1, _ => 0};
            //return (n % 2 == 0) ? (n & ~1) | ((n ^ (n >> 1)) & 1) : (n ^ (n >> 1)) & 1;
            //return n % 2 == 0 && n % 4 == 0 ? n : (n % 4 == 1 ? 1 : (n % 2 == 0 ? n + 1 : 0));

            // return (int) (n % 4) switch
            // {
            //     0 => n,
            //     1 => 1,
            //     2 => n + 1,
            //     _ => 0
            // };

            // switch ((int) (n % 4))
            // {
            //     case 0: return n;
            //     case 1: return 1;
            //     case 2: return n + 1;
            //     default: return 0;
            // }
        }

        // public static BigInteger Sxore(BigInteger n, BigInteger res = default) =>
        //     ((n + 1) % 4).IsZero ? res : Sxore(n - 1, res ^ n);
    }
}