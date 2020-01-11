/*
https://www.codewars.com/kata/5694cb0ec554589633000036/train/csharp
https://www.codewars.com/kata/5694cb0ec554589633000036/solutions/csharp

7 kyu
Recursion #1 - Factorial

##1 - Factorial
In mathematics, the factorial of a non-negative integer n, denoted by n!, is the product of all positive integers less than or equal to n. For example,

5! = 5 * 4 * 3 * 2 * 1 = 120.

The value of 0! is 1.

#Your task
You have to create the function factorial that receives n and returns n!. You have to use recursion.
*/

namespace CodeWars
{
    public class Recursion1Factorial
    {
        public static ulong Factorial(ulong n) => checked(n == 0 ? 1 : n * Factorial(--n));

        // public static ulong Factorial(ulong n)
        // {
        //     checked
        //     {
        //         return n == 0 ? 1 : n * Factorial(n - 1);
        //     }
        // }

        // public static ulong Factorial(ulong n)
        // {
        //     checked
        //     {
        //         if (n > 1)
        //             return ((ulong)n) * Factorial(n - 1);
        //         else
        //             return 1;
        //
        //     }
        // }

        // public static ulong Factorial(ulong n)
        // {
        //     checked
        //     {
        //         return n == 0UL ? 1UL : n * Factorial(n - 1);    
        //     }
        // }


        // public static ulong Factorial(ulong n)
        // {
        //     checked
        //     {
        //         return n <= 0 ? 1 : n == 1 ? 1 : n * Factorial(n - 1);
        //     }
        // }


        // public static ulong Factorial(ulong n)
        // {
        //     checked
        //     {
        //         return n == 0 ? 1ul : n * Factorial(n-1ul);    
        //     }
        // }
    }
}