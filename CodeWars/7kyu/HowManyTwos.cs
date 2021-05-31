/*
https://www.codewars.com/kata/56aed5db9d5cb55de000001c/csharp

7 kyu
How many twos?

Write a function that returns the number of '2's in the factorization of a number.
For example,

TwoCount(24)
should return 3, since the factorization of 24 is 2^3 x 3

TwoCount(17280)
should return 7, since the factorization of 17280 is 2^7 x 5 x 3^3
The number passed to two_count (twoCount) will always be a positive integer greater than or equal to 1.
*/

using System;

namespace CodeWars
{
    public class HowManyTwos
    {
        public static int TwoCount(int n)
        {
            return (int) Math.Log(n & -n, 2);


            // int count;
            // for (count = 0; n > 1 && n % 2 == 0; count++) n /= 2;
            // return count;


            // var res = 0;
            // for (; n % 2 == 0; n /= 2)
            //     res++;
            // return res;


            // var result = 0;
            // while (n % 2 == 0)
            // {
            //     n /= 2;
            //     result++;
            // }
            //
            // return result;
        }
    }
}