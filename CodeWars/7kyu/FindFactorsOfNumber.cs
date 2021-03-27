/*
https://www.codewars.com/kata/564fa92d1639fbefae00009d/csharp

7 kyu
Find factors of a number

Create a function that takes a number and finds the factors of it, listing them in descending order in an array.
If the parameter is not an integer or less than 1, return -1. In C# return an empty array.
For Example: factors(54) should return [54, 27, 18, 9, 6, 3, 2, 1]
*/

using System.Linq;

namespace CodeWars
{
    public class FindFactorsOfNumber
    {
        public static int[] Factors(int num)
        {
            return num < 1
                ? new int[0]
                : Enumerable.Range(1, num).Where(i => num % i == 0).OrderBy(i => -i).ToArray();

            // return num < 1
            //     ? new int[0]
            //     : Enumerable.Range(1, num).Where(i => num % i == 0).OrderByDescending(i => i).ToArray();
        }
    }
}