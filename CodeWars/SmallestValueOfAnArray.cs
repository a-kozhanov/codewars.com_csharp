/*
https://www.codewars.com/kata/544a54fd18b8e06d240005c0/csharp

7 kyu
Smallest value of an array

Write a function that can return the smallest value of an array or the index of that value. 
The function's 2nd parameter will tell whether it should return the value or the index.

Assume the first parameter will always be an array filled with at least 1 number and no duplicates. 
Assume the second parameter will be a string holding one of two values: 'value' and 'index'.

min([1,2,3,4,5], 'value') // => 1
min([1,2,3,4,5], 'index') // => 0
*/

using System.Linq;

namespace CodeWars
{
    public class SmallestValueOfAnArray
    {
        public static int FindSmallest(int[] numbers, string toReturn)
        {
            if (toReturn == "value")
            {
                return numbers.Min(x => x);
            }

            return numbers.ElementAt(numbers.Min(x => x));

        }
    }
}