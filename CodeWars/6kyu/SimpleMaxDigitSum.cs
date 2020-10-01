/*
https://www.codewars.com/kata/5b162ed4c8c47ea2f5000023/csharp

6 kyu
Simple max digit sum

In this Kata, you will be given an integer n and your task will be to return the largest integer that is <= n and has the highest digit sum.

For example:

solve(100) = 99. Digit Sum for 99 = 9 + 9 = 18. No other number <= 100 has a higher digit sum.
solve(10) = 9
solve(48) = 48. Note that 39 is also an option, but 48 is larger.
Input range is 0 < n < 1e11

More examples in the test cases.

Good luck!
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class SimpleMaxDigitSum
    {
        public static long solve(long n)
        {
            long m = n, e = 1;

            while (m >= 10)
            {
                m /= 10;
                e *= 10;
            }

            long t = m * e + (e - 1);

            if (t == n)
                return t;

            for (e = 1;; e *= 10)
                if (t - e <= n)
                    return t - e;
        }
    }
}