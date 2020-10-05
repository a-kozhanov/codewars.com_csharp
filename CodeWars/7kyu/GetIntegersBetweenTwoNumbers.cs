/*
https://www.codewars.com/kata/598057c8d95a04f33f00004e/csharp

7 kyu
Get the integers between two numbers

Build a function that can get all the integers between two given numbers.

Example:

(2,9)

Should give you this output back:

[ 3, 4, 5, 6, 7, 8 ]

If startNum is the same as endNum, return an empty array.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class GetIntegersBetweenTwoNumbers
    {
        public static int[] Range(int startNum, int endNum)
        {
            // var result = new List<int>();
            // for (var i = startNum + 1; i < endNum; i++)
            // {
            //     result.Add(i);
            // }
            // return result.ToArray();

            //return endNum <= startNum ? new int[0] : Enumerable.Range(startNum + 1, endNum - startNum - 1).ToArray();
            return Enumerable.Range(startNum + 1, Math.Max(endNum - startNum - 1, 0)).ToArray();
        }
    }
}