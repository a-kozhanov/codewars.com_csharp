

//https://www.codewars.com/kata/is-n-divisible-by-x-and-y/train/csharp
//https://www.codewars.com/kata/5545f109004975ea66000086/solutions/csharp

//Is n divisible by x and y?
//8 kyu

//Create a function isDivisible(n, x, y) that checks if a number n is divisible by two numbers x AND y. All inputs are positive, non-zero digits.
//Example:
//isDivisible(3,1,3)--> true because 3 is divisible by 1 and 3
//isDivisible(12,2,6)--> true because 12 is divisible by 2 and 6
//isDivisible(100,5,3)--> false because 100 is not divisible by 3
//isDivisible(12,7,5)--> false because 12 is neither divisible by 7 nor 5

using System;

namespace CodeWars
{
    public class IsDivisibleByXAndY
    {
        public static bool isDivisible(long n, long x, long y)
        {
            return ((decimal)n / (decimal)x) % 1 == 0 && ((decimal)n / (decimal)y) % 1 == 0;
        }

        //public static bool isDivisible(long n, long x, long y)
        //{
        //    return n % x == 0 && n % y == 0;
        //}


        //public static bool isDivisible(long n, long x, long y) {
        //    return (x != 0 && y != 0 && n % x == 0 && n % y == 0);
        //}

        //public static bool isDivisible(long n, long x, long y) => n%x == 0 && n%y == 0;


        //public static Boolean isDivisible(long n, long x, long y) {
        //    return (n % x) + (n % y) == 0;
        //}


        //public static Boolean isDivisible(long n, long x, long y) => n % x == 0 && n % y == 0 ? true : false;





    }
}