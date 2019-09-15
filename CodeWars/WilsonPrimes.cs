
//https://www.codewars.com/kata/wilson-primes/csharp
//https://www.codewars.com/kata/55dc4520094bbaf50e0000cb/solutions/csharp

//Wilson primes

//Wilson primes satisfy the following condition. Let P represent a prime number.
//Then ((P-1)! + 1) / (P * P) should give a whole number.
//Your task is to create a function that returns true if the given number is a Wilson prime.

using System;
using System.Linq;

namespace CodeWars
{
    public class WilsonPrimes
    {
        private static int ModFactorial(int n, int mod)
        {
            if (n < 2) return 1;
            return n * ModFactorial(n - 1, mod) % mod;
        }

        public static bool AmIWilson(int p)
        {
            return ModFactorial(p - 1, p * p) + 1 == p * p;
        }


        //public static bool AmIWilson(int p) {
        //    return Array.Exists(new int[]{5, 13, 563}, e => e == p);
        //}


        //public static bool AmIWilson(int p)
        //{
        //    int pow = 1;
        //    for (int i = 2; i < p; i++)
        //        pow = pow * i;
        //    if ((pow + 1)%(p * p) == 0)
        //        return true;
        //    else   
        //        return false;
        //}


        //// Only 3 Wilson primes are known, others must be > 2 * 10^13 which is greater than int.MaxValue.
        //public static bool AmIWilson(int p) => p == 5 || p == 13 || p == 563;


        //public static bool AmIWilson(int p)
        //{
        //    return p == 5 || p == 13 || p == 563;
        //}


        //public static bool AmIWilson(int p)
        //{
        //    return (Factorial(p - 1) + 1.0) / (p * p) % 1 == 0 ? true : false;
        //}

        //private static int Factorial(int n)
        //{
        //    if(n > 1) return Factorial(n - 1) * n;
        //    return 1;
        //}


        //public static bool AmIWilson(int p)
        //{
        //    return ((Enumerable.Range(1, p-1).Aggregate((i1, i2) => i1*i2)+1)%(p*p)) == 0 ? true : false;
        //}


        //public static bool AmIWilson(int p)
        //{
        //    int F = 1;
        //    for (int i = 1; i < p; i++)
        //    {
        //        F *= i;
        //    }
        //    return ((F+1) % (p*p) == 0);
        //}


        //public static bool AmIWilson(int p)
        //{
        //    int f = 1;
        //    for (int i = 1; i < p; f *= i++);
        //    return (f + 1) % (p * p) == 0;
        //}


        //public static bool AmIWilson(int p) => (1 + Enumerable.Range(1, p - 1).Aggregate(1l, (a,i) => a * i)) % (p * p) == 0;



    }
}