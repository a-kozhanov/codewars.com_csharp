/*
https://www.codewars.com/kata/558ee8415872565824000007/train/csharp

7 kyu
Is n divisible by (...)?

Create a function isDivisible(n,...) that checks if the first agrument n is divisible by all other arguments (return true if no other arguments)

Example:
isDivisible(6,1,3)--> true because 6 is divisible by 1 and 3
isDivisible(12,2)--> true because 12 is divisible by 2
isDivisible(100,5,4,10,25,20)--> true
isDivisible(12,7)--> false because 12 is not divisible by 7

This kata is following kata: http://www.codewars.com/kata/is-n-divisible-by-x-and-y
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class IsNDivisibleBy
    {
        public static bool IsDivisible(params int[] args)
        {
            //return Enumerable.Range(1, args.Length - 1).All(x => args[0] % args[x] == 0);
            //return args.ToList().TrueForAll(x => args.First() % x == 0);
            //return args.ToList().TrueForAll(x => args[0] % x == 0);
            //return args.Count(x => args[0] % x != 0) == 0;
            //return args.All(x => args.First() % x == 0);
            return args.All(x => args[0] % x == 0);
        }
    }
}