/*
https://www.codewars.com/kata/56e7d40129035aed6c000632/train/csharp
https://www.codewars.com/kata/56e7d40129035aed6c000632/solutions/csharp

7 kyu
Easy Line

In the drawing below we have a part of the Pascal's triangle, lines are numbered from zero (top).

We want to calculate the sum of the squares of the binomial coefficients on a given line with a function called easyline (or easyLine or easy-line).

Can you write a program which calculate easyline(n) where n is the line number?

The function will take n (with: n>= 0) as parameter and will return the sum of the squares of the binomial coefficients on line n.

##Examples:

easyline(0) => 1
easyline(1) => 2
easyline(4) => 70
easyline(50) => 100891344545564193334812497256
##Ref: http://mathworld.wolfram.com/BinomialCoefficient.html

alternative text

Note:
In Javascript, Coffeescript, Typescript, C++, PHP, C, R, Nim, Fortran to get around the fact that we have no big integers the function easyLine(n) will in fact return

round(log(easyline(n)))

and not the easyline(n) of the other languages.

So, in Javascript, Coffeescript, Typescript, C++, PHP, R, Nim, C, Fortran:

easyLine(0) => 0
easyLine(1) => 1
easyLine(4) => 4
easyLine(50) => 67
*/

using System;
using System.Linq;
using System.Numerics;

namespace CodeWars
{
    public class KataEasyLine
    {
        public static BigInteger EasyLine(int n)
        {
            BigInteger sum = 1;
            for (var i = 1; i <= n; i++)
            {
                sum = sum * (n + i) / i;
            }

            return sum;
        }


        // public static BigInteger EasyLine(int n)
        // {
        //     BigInteger sum = 1;
        //     for (BigInteger k = 1, c = 1; k <= n; k++)
        //     {
        //         c = c * (n - k + 1) / k;
        //         sum += c * c;
        //     }
        //
        //     return sum;
        // }


        // public static BigInteger EasyLine(int n)
        // {
        //     var x = new BigInteger(1);
        //     var sum = new BigInteger(0);
        //     for (int k = 0; k <= n; k++)
        //     {
        //         sum = BigInteger.Add(sum, x * x);
        //         x = BigInteger.Multiply(x, n - k);
        //         x = BigInteger.Divide(x, k + 1);
        //     }
        //
        //     return sum;
        // }


        // public static BigInteger EasyLine(int n)
        // {
        //     BigInteger v = 1, sum = 1;
        //     for (int k = 1; k <= n; k++)
        //         sum += BigInteger.Pow((v = (v * (n + 1 - k)) / k), 2);
        //     return sum;
        // }


        // public static BigInteger EasyLine(int n)
        // {
        //     BigInteger sum = 0;
        //     BigInteger b = 1;
        //     for (int i = 0; i <= n; i++)
        //     {
        //         sum += b * b;
        //         b = b * (n - i) / (i + 1);
        //     }
        //
        //     return sum;
        // }


        // public static BigInteger EasyLine(int n) =>
        //     Enumerable.Range(n + 1, n).Aggregate(new BigInteger(1), (a, b) => a * b) /
        //     Enumerable.Range(1, n).Aggregate(new BigInteger(1), (a, b) => a * b);
    }
}