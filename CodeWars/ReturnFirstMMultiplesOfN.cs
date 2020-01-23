/*
https://www.codewars.com/kata/593c9175933500f33400003e/train/csharp
https://www.codewars.com/kata/593c9175933500f33400003e/solutions/csharp

7 kyu
Return the first M multiples of N

Implement a function, multiples(m, n), 
which returns an array of the first m multiples of the real number n. 
Assume that m is a positive integer.

Ex.
multiples(3, 5.0)
should return

[5.0, 10.0, 15.0]
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class ReturnFirstMMultiplesOfN
    {
        public static double[] Multiples(int m, double n)
        {
            return Enumerable.Range(1, m).Select(x => x * n).ToArray();
        }

        // public static double[] Multiples(int m, double n)
        // {
        //     double[] array = new double[m];
        //     for (int i = 1; i <= m; i++)
        //     {
        //         array[i-1] = i * n;
        //     }
        //     return array;
        // }


        // public static double[] Multiples(int m, double n) => Enumerable.Range(1, m).Select(x => (double)(n * x)).ToArray();


        // public static double[] Multiples(int m, double n)
        // {
        //     List<double> multis = new List<double>();
        //     for (int i = 1; i <= m; i++)
        //     {
        //         multis.Add( n * i) ;
        //     }
        //     return multis.ToArray();
        // }


        // public static double[] Multiples(int m, double n)
        // {
        //     var arr = new double[m];
        //     for(int i = 1; i <= m; i++)
        //         arr[i - 1] = i * n;
        //     return arr;
        // }
    }
}