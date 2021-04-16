/*
https://www.codewars.com/kata/5661cde807c4e28efa0000d0/csharp

7 kyu
Give me a Crazy Formula!

Sum all digits of n with the following rules:

If there isn't a middle digit and n > 9: remove the last digit;
If the middle digit is odd: reduce it instead of sum;
If both the middle digit and the last digit aren't odd: reduce the last digit instead of sum;
If the middle digit isn't odd but the last digit is: sum the first digit squared instead of regular sum;
This must be done until there are only 1 digit(negative number should use abs).

Example:

Input => Result

5 => 5
214 => 2-1+4 = 5
224 => 2+2-4 = 0
2224 => 222 => 2+2-2 = 2
2234 => 223 => 2²+2+3 = 9
126 => 1+2-6 = -3 => 3
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class GiveMeCrazyFormula
    {
        public int CrazyFormula(long n)
        {
            while (n > 9)
            {
                var arr = n.ToString().Select(d => int.Parse(d.ToString())).ToArray();
                if (arr.Length % 2 == 0) arr = arr[..^1];

                long mid = arr[(arr.Length - 1) / 2],
                    first = arr.First(),
                    last = arr.Last(),
                    sum = arr.Sum();

                if (mid % 2 == 1) sum -= 2 * mid;
                else if (last % 2 == 0) sum -= 2 * last;
                else sum = sum - first + first * first;

                n = sum;
            }

            return (int) Math.Abs(n);
        }
    }
}