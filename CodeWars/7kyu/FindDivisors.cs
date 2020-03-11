/*
https://www.codewars.com/kata/544aed4c4a30184e960010f4/train/csharp
https://www.codewars.com/kata/544aed4c4a30184e960010f4/solutions/csharp

7 kyu
Find the divisors!

Create a function named divisors/Divisors that takes an integer n > 1 and returns an array with all of the integer's divisors(except for 1 and the number itself), from smallest to largest. 
If the number is prime return the string '(integer) is prime' (null in C#) (use Either String a in Haskell and Result<Vec<u32>, String> in Rust).

Example:
Kata.Divisors(12) => new int[] {2, 3, 4, 6};
Kata.Divisors(25) => new int[] {5};
Kata.Divisors(13) => null;
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class FindDivisors
    {
        public static int[] Divisors(int n)
        {
            var div = Enumerable.Range(2, (int) Math.Sqrt(n))
                .Where(x => n % x == 0 && x < n)
                .SelectMany(x => new[] {x, n / x})
                .OrderBy(x => x)
                .Distinct()
                .ToArray();

            return div.Any() ? div : null;
        }

        // public static int[] Divisors(int n)
        // {
        //     List<int> l = new List<int>();
        //     for (int i = 2; i <= Math.Sqrt(n); i++)
        //         if (n % i == 0)
        //             l.Add(i);
        //     if (l.Count == 0) return null;
        //     List<int> k =
        //         new List<int>(Enumerable.Reverse(l.ToArray().Select(x => n / x).ToArray().Where(x => !l.Contains(x))));
        //     l.AddRange(k);
        //     return l.ToArray();
        // }


        // public static int[] Divisors(int n)
        // {
        //     int[] divisors = Enumerable.Range(2, (int) Math.Sqrt(n)).Where(x => x < n && n % x == 0)
        //         .SelectMany(x => new[] {x, n / x}).GroupBy(x => x).Select(g => g.First()).OrderBy(x => x).ToArray();
        //     return divisors.Length != 0 ? divisors : null;
        // }


        // public static int[] Divisors(int n)
        // {
        //     var result = new List<int>();
        //     for (var i = 2; i <= Math.Sqrt(n); i++)
        //         if (n % i == 0)
        //             result.Add(i);
        //
        //     if (result.Count == 0)
        //         return null;
        //
        //     result.AddRange(result.Select(x => n / x).Where(x => !result.Contains(x)).Reverse());
        //     return result.ToArray();
        // }


        // public static int[] Divisors(int n)
        // {
        //     List<int> sample = new List<int>() { };
        //     for (int i = 2; i <= Math.Sqrt(n); i++)
        //     {
        //         if (n % i == 0)
        //         {
        //             sample.Add(i);
        //             sample.Add(n / i);
        //         }
        //     }
        //
        //     sample = sample.OrderBy(x => x).ToList();
        //     return sample.Count() > 0 ? sample.Distinct().ToArray() : null;
        // }


        // public static int[] Divisors(int n)
        // {
        //     var l = new List<int>();
        //     for (int i = 2; i <= (int) Math.Sqrt(n); i++)
        //     {
        //         if (n % i == 0)
        //         {
        //             l.Add(i);
        //             var temp = n / i;
        //             l.Add(temp);
        //         }
        //     }
        //
        //     l.Sort();
        //     return l.Count() != 0 ? l.Distinct().ToArray() : null;
        // }


        // public static int[] Divisors(int n)
        // {
        //     List<int> divisors = new List<int>();
        //     for (int i = 2; i <= Math.Sqrt(n); i++)
        //         if (n % i == 0)
        //             divisors.Add(i);
        //     List<int> k = new List<int>(Enumerable.Reverse(divisors.ToArray().Select(x => n / x).ToArray()
        //         .Where(x => !divisors.Contains(x))));
        //     divisors.AddRange(k);
        //     if (divisors.Count() == 0) return null;
        //
        //     return divisors.ToArray();
        // }
    }
}