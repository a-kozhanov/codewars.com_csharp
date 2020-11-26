/*
https://www.codewars.com/kata/sort-numbers/train/csharp


7 kyu
Sort Numbers

Finish the solution so that it sorts the passed in array of numbers. If the function passes in an empty array or null/nil value then it should return an empty array.

For example:
SortNumbers(new int[] { 1, 2, 10, 50, 5 }); // should return new int[] { 1, 2, 5, 10, 50 }
SortNumbers(null); // should return new int[] { }
*/

using System.Linq;

namespace CodeWars
{
    public class KataSortNumbers
    {
        public static int[] SortNumbers(int[] nums)
        {
            //return (nums ?? new int[] { }).OrderBy(x => x).ToArray();


            return nums?.OrderBy(x => x).ToArray() ?? new int[0];

            //return nums == null ? new int[0] : nums.OrderBy(n => n).ToArray();
        }


        // public static int[] SortNumbers(int[] nums)
        // {
        //     return nums == null || !nums.Any() ? new int[] { } : nums.OrderBy(n => n).ToArray();
        // }

        // public static int[] SortNumbers(int[] nums)
        //     => nums == null? new int[0] : nums.OrderBy(x=>x).ToArray();


        // public static int[] SortNumbers(int[] numbers)
        // {
        //     if (numbers == null)
        //         return new int[0];
        //     Array.Sort(numbers);
        //     return numbers;
        // }


        // public static int[] SortNumbers(int[] nums)
        // {
        //     int[] a = new int[] { };
        //     return nums==null?a:nums.OrderBy(x => x).ToArray();
        // }
    }
}