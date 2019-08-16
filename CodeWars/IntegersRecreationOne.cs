using System;
using System.Collections.Generic;
using System.Linq;

//https://www.codewars.com/kata/integers-recreation-one/train/csharp
//https://www.codewars.com/kata/55aa075506463dac6600010d/solutions/csharp

//Integers: Recreation One

//Divisors of 42 are : 1, 2, 3, 6, 7, 14, 21, 42. These divisors squared are: 1, 4, 9, 36, 49, 196, 441, 1764. The sum of the squared divisors is 2500 which is 50 * 50, a square!

//Given two integers m, n (1 <= m <= n) we want to find all integers between m and n whose sum of squared divisors is itself a square. 42 is such a number.

//The result will be an array of arrays or of tuples(in C an array of Pair) or a string, each subarray having two elements, first the number whose squared divisors is a square and then the sum of the squared divisors.

//# Examples:
//list_squared(1, 250) --> [[1, 1], [42, 2500], [246, 84100]]
//list_squared(42, 250) --> [[42, 2500], [246, 84100]]

//The form of the examples may change according to the language, see Example Tests: for more details.

//Note
//In Fortran - as in any other language - the returned string is not permitted to contain any redundant trailing whitespace: you can use dynamically allocated character strings.



namespace CodeWars
{
    public class IntegersRecreationOne
    {

        public static string listSquared(long m, long n)
        {
            var result = "";

            for (var i = m; i <= n; i++)
            {
                var divisorsOfi = new List<double>();
                for (var j = 1; j <= Math.Sqrt(i); j++)
                    if (i % j == 0)
                    {
                        divisorsOfi.Add(Math.Pow(j, 2));

                        if (i / j != j)
                            divisorsOfi.Add(Math.Pow(i / j, 2));
                    }

                double sumOfDivisorsOfi = 1;
                if (divisorsOfi.Count > 1) sumOfDivisorsOfi = divisorsOfi.Aggregate((a, b) => a + b);

                if (Math.Sqrt(sumOfDivisorsOfi) % 1 == 0)
                {
                    if (result.Length > 1) result += ", ";
                    result += $"[{i}, {sumOfDivisorsOfi}]";
                }
            }

            return $"[{result}]";
        }

        //Best Practices
        //public static string listSquared(long m, long n)
        //{
        //    List<string> result = new List<string>();
        //    for (int i = (int)m; i <= n; i++)
        //    {
        //        int sum = GetDivisors(i).Select(x => x * x).Sum();
        //        if (IsSquare(sum))
        //        {
        //            result.Add(string.Format("[{0}, {1}]", i, sum));
        //        }
        //    }
        //    return "[" + string.Join(", ", result) + "]";
        //}

        //private static bool IsSquare(int num)
        //{
        //    return Math.Sqrt(num) % 1 == 0;
        //}

        //private static List<int> GetDivisors(int num)
        //{
        //    List<int> divs = new List<int>();
        //    for (int i = 1; i <= num; i++)
        //    {
        //        if (num % i == 0)
        //            divs.Add(i);
        //    }
        //    return divs;
        //}

    }
}
