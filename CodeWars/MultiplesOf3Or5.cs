/*
https://www.codewars.com/kata/514b92a657cdc65150000006/csharp

6 kyu
Multiples of 3 or 5

If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
The sum of these multiples is 23.

Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.

Note: If the number is a multiple of both 3 and 5, only count it once.

Courtesy of ProjectEuler.net
*/

using System.Linq;

namespace CodeWars
{
    public class MultiplesOf3Or5
    {
        public static int Solution(int value)
        {
            //return Enumerable.Range(0, value).Where(i => i % 3 == 0 || i % 5 == 0).Sum();
            return Enumerable.Range(0, value).Sum(n => n % 3 == 0 || n % 5 == 0 ? n : 0);
        }
    }
}