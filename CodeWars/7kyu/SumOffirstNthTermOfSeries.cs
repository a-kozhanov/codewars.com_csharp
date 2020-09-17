/*
https://www.codewars.com/kata/555eded1ad94b00403000071/csharp

7 kyu
Sum of the first nth term of Series

Task:
Your task is to write a function which returns the sum of following series upto nth term(parameter).

Series: 1 + 1/4 + 1/7 + 1/10 + 1/13 + 1/16 +...

Rules:
You need to round the answer to 2 decimal places and return it as String.

If the given value is 0 then it should return 0.00

You will only be given Natural Numbers as arguments.

Examples:
SeriesSum(1) => 1 = "1.00"
SeriesSum(2) => 1 + 1/4 = "1.25"
SeriesSum(5) => 1 + 1/4 + 1/7 + 1/10 + 1/13 = "1.57"

NOTE: In PHP the function is called series_sum().
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using static System.Linq.Enumerable;

namespace CodeWars
{
    public class SumOffirstNthTermOfSeries
    {
        public static string seriesSum(int n)
        {
            return Enumerable.Range(0, n).Sum(i => 1d / (3 * i + 1)).ToString("F", CultureInfo.InvariantCulture);

            //return Enumerable.Range(0, n).Sum(i => 1d / (3 * i + 1)).ToString("F");
            //return $"{Range(0, n).Sum(i => 1d / (3 * i + 1)):F}";

            // double result = 0;
            //
            // for (var i = 1; i <= n; i++)
            // {
            //     result += 1f / (3 * i - 2);
            // }

            // for (var i = 0; i < n; i++)
            // {
            //     result += 1d / (i * 3 + 1);
            // }

            // double result = 0;
            // for (var i = 4; i < n * 3; i += 3)
            // {
            //     result += 1d / i;
            // }
            //

            //return result.ToString("F", CultureInfo.InvariantCulture);
            //return result.ToString("F");
        }
    }
}