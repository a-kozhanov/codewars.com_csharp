/*
https://www.codewars.com/kata/57a049e253ba33ac5e000212/train/csharp
https://www.codewars.com/kata/57a049e253ba33ac5e000212/solutions/csharp

7 kyu
Factorial

Yor task is to write function factorial
https://en.wikipedia.org/wiki/Factorial
*/

using System.Linq;

namespace CodeWars
{
    public class Factorial
    {
        //public static int factorial(int n) => n == 0 ? 1 : n * factorial(n - 1);

        public static int factorial(int n)
        {
            // if (n == 0)
            // {
            //     return 1;
            // }
            // else
            // {
            //     return n * factorial(n - 1);
            // }

            return n == 0 ? 1 : n * factorial(n - 1);
        }

        // public static int factorial(int n)
        // {
        //     return n < 2 ? 1 : n * factorial(n-1);
        // }

        // public static int factorial(int n)
        // {
        //     int num = 1;
        //
        //     for (int i = 1; i <= n; i++)
        //         num *= i;
        //
        //     return num;
        // }

        // public static int factorial(int n)
        // {
        //     var result = 1;
        //     for (int i = 2; i <= n; ++i)
        //     {
        //         result *= i;
        //     }
        //     return result;
        // }


        // public static int factorial(int n)
        // {
        //     return n == 0 ? 1 : Enumerable.Range(1,n).Aggregate((x,y) => x*y);
        // }

        // public static int factorial(int n)
        // {
        //     return n > 1 ? Enumerable.Range(1, n).Aggregate((r, i) => r * i) : 1;
        // }
    }
}