/*
https://www.codewars.com/kata/57a049e253ba33ac5e000212/train/csharp
https://www.codewars.com/kata/57a049e253ba33ac5e000212/solutions/csharp

7 kyu
Factorial

Yor task is to write function factorial
https://en.wikipedia.org/wiki/Factorial
*/

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
    }
}