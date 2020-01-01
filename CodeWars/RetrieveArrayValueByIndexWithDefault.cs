/*
https://www.codewars.com/kata/retrieve-array-value-by-index-with-default/train/csharp
https://www.codewars.com/kata/retrieve-array-value-by-index-with-default/solutions/csharp

7 kyu
Retrieve array value by index with default

Complete the solution. 
It should try to retrieve the value of the array at the index provided. 
If the index is out of the array's max bounds then it should return the default value instead.

Example:
int[] data = new int[] {1, 2, 3};
Kata.Solution(data, 1, -1) => 2
Kata.Solution(data, 5, -1) => -1

// negative values work as long as they aren't out of the length bounds
// if an index is negative, start from the end of the array
Kata.Solution(data, -1, -1) => 3
Kata.Solution(data, -5, -1) => -1
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class RetrieveArrayValueByIndexWithDefault
    {
        public static int Solution(int[] items, int index, int defaultValue)
        {
            // var result = 0;
            // if (items.Length >= Math.Abs(index))
            // {
            //     result = index < 0 ? items[items.Length - Math.Abs(index)] : items[index];
            // }
            // else
            // {
            //     result = defaultValue;
            // }
            //
            // return result;

            return items.Length >= Math.Abs(index)
                ? index < 0 ? items[items.Length - Math.Abs(index)] : items[index]
                : defaultValue;
        }

        // public static int Solution(int[] items, int index, int defaultValue)
        //     => Math.Abs(index) > items.Length ? defaultValue
        //         : index >= 0 ? items[index] : items[items.Length + index];


        // public static int Solution(int[] items, int index, int defaultValue)
        // {
        //     int calcIndex = index > 0 ? index : items.Length + index;
        //     return (items.Length >= calcIndex && calcIndex >= 0) ? items[calcIndex] : defaultValue;
        // }


        // public static int Solution(int[] items, int index, int defaultValue)
        // {
        //     int calcIndex = index > 0 ? index : items.Length + index;
        //     return (items.Length >= calcIndex && calcIndex >= 0) ? items[calcIndex] : defaultValue;
        // }


        // public static int Solution(int[] items, int index, int defaultValue)
        // {
        //     if (index > items.Length || -index > items.Length)
        //         return defaultValue;
        //     if (index < 0)
        //         return items[items.Length + index];
        //     return items[index];
        // }


        // public static int Solution(int[] items, int index, int defaultValue)
        // {
        //     return index >= items.Length ? defaultValue :
        //         index < -1 * items.Length ? defaultValue : items[(items.Length + index) % items.Length];
        // }


        // public static int Solution(int[] items, int index, int defaultValue)
        // {
        //     return (index - 1) > items.Count() || (index * -1 > items.Count()) ? defaultValue :
        //         index < 0 ? items.ElementAt(items.Count() - (index * -1)) :
        //         items.ElementAt(index);
        // }
    }
}