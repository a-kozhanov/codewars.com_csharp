/*
https://www.codewars.com/kata/558fc85d8fd1938afb000014/train/csharp
https://www.codewars.com/kata/558fc85d8fd1938afb000014/solutions/csharp

7 kyu
Sum of two lowest positive integers

Create a function that returns the sum of the two lowest positive numbers given an array of minimum 4 positive integers. 
No floats or non-positive integers will be passed.

For example, when an array is passed like [19, 5, 42, 2, 77], the output should be 7.

[10, 343445353, 3453445, 3453545353453] should return 3453455.
*/

using System.Linq;

namespace CodeWars
{
    public class SumOftwoLowestPositiveIntegers
    {
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            return numbers.OrderBy(x => x).Take(2).Sum();
        }
    }
}