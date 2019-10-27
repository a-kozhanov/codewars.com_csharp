using System;
using System.Linq;

namespace CodeWars

//https://www.codewars.com/kata/sum-of-odd-numbers/train/csharp
//https://www.codewars.com/kata/55fd2d567d94ac3bc9000064/solutions/csharp

//Sum of odd numbers

//Given the triangle of consecutive odd numbers:

//1
//3     5
//7     9    11
//13    15    17    19
//21    23    25    27    29
//...
//Calculate the row sums of this triangle from the row index (starting at index 1) e.g.:

//rowSumOddNumbers(1); // 1
//rowSumOddNumbers(2); // 3 + 5 = 8

{
    public class SumOddNumbers
    {
        public static long rowSumOddNumbers(long n)
        {
            return (long)Math.Pow(n, 3);
        }

        //public static long rowSumOddNumbers(long n)
        //{
        //    return n * n * n;
        //}

        //public static long rowSumOddNumbers(long n)
        //{
        //    return (long)Enumerable.Range(1, (int)n * (int)n + (int)n - 1).Where(i => i % 2 != 0).Reverse().Take((int)n).Sum();
        //}

        //public static long rowSumOddNumbers(long n)
        //{
        //    long start = 0;
        //    for (long i = 0; i <= n-1; i++) {
        //        start += i;
        //    }
        //    long result = 0;
        //    for(long i = 0; i < n; i++){
        //        result += (start + i) * 2 + 1;
        //    }
        //    return result;
        //}

        //public static long rowSumOddNumbers(long n)
        //{
        //    long t = 0;
        //    long a = n * (n - 1) + 1;
        //    for (int i = 0; i < n; i++)
        //    {
        //        t += a + 2 * i;
        //    }
        //    return t;
        //}



    }
}