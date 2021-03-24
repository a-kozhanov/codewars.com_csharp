/*
https://www.codewars.com/kata/57fa92b25c9910e7bc0001df/csharp

7 kyu
Fac Recursion (Pest control - find the bugs and fix them)

The code is a recursive attempt in calculating the result of a factorial function.
I.e. the result of 3! (Factorial of 3) is 3x2x1 = 6.
In case of 0! the result is 1 and in case of a negative factorial the result should be 0.

The goal is to find the bugs in the sourcecode and fix them (play a little pest control).
*/

namespace CodeWars
{
    public class KataFacRecursion
    {
        // public int FacCalculation(int n)
        // {
        //     return n < 0 ? 0 : n == 0 ? 1 : n * FacCalculation(n - 1);
        // }

        public int FacCalculation(int startValue)
        {
            return startValue < 0 ? 0 :
                startValue == 1 || startValue == 0 ? 1 : FacCalculation(startValue - 1) * startValue;
        }
    }
}