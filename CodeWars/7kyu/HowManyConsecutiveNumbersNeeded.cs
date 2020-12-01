/*
https://www.codewars.com/kata/559cc2d2b802a5c94700000c/csharp

7 kyu
How many consecutive numbers are needed?

Create the function consecutive(arr) that takes an array of integers and return the minimum number of integers needed to make the contents of arr consecutive from the lowest number to the highest number.

For example:
If arr contains [4, 8, 6] then the output should be 2 because two numbers need to be added to the array (5 and 7) to make it a consecutive array of numbers from 4 to 8. 
Numbers in arr will be unique.
*/

using System.Linq;

namespace CodeWars
{
    public class HowManyConsecutiveNumbersNeeded
    {
        public static int Consecutive(int[] arr)
        {
            //return arr.Any() ? Enumerable.Range(arr.Min(), arr.Max() - arr.Min() + 1).Count() - arr.Length : 0;
            //return arr.Length < 2 ? 0 : Enumerable.Range(arr.Min(), arr.Max() - arr.Min() + 1).Count() - arr.Length;
            //return arr.Any() ? Enumerable.Range(arr.Min(), arr.Max() - arr.Min()).Except(arr).Count() : 0;
            //return arr.Length == 0 ? 0 : arr.Max() - arr.Min() + 1 - arr.Length;
            //return arr.Length < 2 ? 0 : arr.Max() - arr.Min() + 1 - arr.Length;
            return arr.Any() ? arr.Max() - arr.Min() - arr.Length + 1 : 0;
        }
    }
}