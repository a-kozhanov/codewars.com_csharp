//https://www.codewars.com/kata/sum-of-multiples/train/csharp
//https://www.codewars.com/kata/57241e0f440cd279b5000829/solutions/csharp

//Sum of Multiples
//8 kyu

//Your Job
//Find the sum of all multiples of n below m

//Keep in Mind
//n and m are natural numbers (positive integers)
//m is excluded from the multiples
//Examples
//Kata.SumMul(2, 9)   => 2 + 4 + 6 + 8 = 20
//Kata.SumMul(3, 13)  => 3 + 6 + 9 + 12 = 30
//Kata.SumMul(4, 123) => 4 + 8 + 12 + ... = 1860
//Kata.SumMul(4, 1)   // throws ArgumentException
//Kata.SumMul(0, 20)  // throws ArgumentException

using System;
using System.Linq;

namespace CodeWars
{
    public class SumMultiples
    {
        public static int SumMul(int n, int m)
        {
            return n < 1 || n >= m
                ? throw new ArgumentException()
                : Enumerable.Range(1, m).Where(x => x % n == 0).Sum();

            // Console.WriteLine($"n:{n}, m:{m}");
            // if (n == 0 || n < m) throw new ArgumentException();
            // var sum = 0;
            // for (var i = n; i <= m; i += n) sum += i;
            // return sum;
        }


        //public static int SumMul(int n, int m)
        //{
        //    if (m <= n) { throw new ArgumentException("First argument must be greater than second argument"); }
        //    if (n <= 0) { throw new ArgumentException("First argument must be a positive integer"); }
        //    return Enumerable.Range(1, m / n).Sum(v => v * n);
        //}


        //public static int SumMul(int n, int m)
        //{
        //    if(m<=n||n<=0){
        //        throw new ArgumentException();
        //    }
        //    var result = 0;
        //    for(int i=n;i<m;i+=n){
        //        result+=i;
        //    }
        //    return result;
        //}


        //public static int SumMul(int n, int m)
        //{
        //    Console.WriteLine($"{n},{m}");
        //    if (n == 0 || n >= m || n<0 || m <0)
        //        throw new System.ArgumentException();

        //    return m/n *(m/n * n + n)/ 2;

        //}


        //public static int SumMul(int n, int m)
        //{
        //    if (n < 1 || n >= m)
        //        throw new ArgumentException();
        //    return Enumerable.Range(1, m / n).Select(x => x * n).Sum();
        //}


        //public static int SumMul(int n, int m)
        //{
        //    if (n > m || n <= 0) throw new ArgumentException();
        //    var x = m / n; 
        //    return n * (x * (x + 1) / 2); 
        //}


        //public static int SumMul(int n, int m)
        //{
        //    if(n <= 0 || n >= m )
        //    {
        //        throw new System.ArgumentException();
        //    }

        //    return Enumerable.Range(1, m).Where(e=>e%n==0).Sum();
        //}
    }
}