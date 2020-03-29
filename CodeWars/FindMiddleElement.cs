/*
https://www.codewars.com/kata/545a4c5a61aa4c6916000755/train/csharp

7 kyu
Find the middle element

As a part of this Kata, you need to create a function that when provided with a triplet, 
returns the index of the numerical element that lies between the other two elements.

The input to the function will be an array of three distinct numbers (Haskell: a tuple).

For example:

gimme([2, 3, 1]) => 0
2 is the number that fits between 1 and 3 and the index of 2 in the input array is 0.

Another example (just to make sure it is clear):

gimme([5, 10, 14]) => 1
10 is the number that fits between 5 and 14 and the index of 10 in the input array is 1.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class FindMiddleElement
    {
        public static int Gimme(double[] inputArray)
        {
            //return 3 - Array.IndexOf(inputArray, inputArray.Max()) - Array.IndexOf(inputArray, inputArray.Min());
            //return Array.FindIndex(inputArray, match => match > inputArray.Min() & match < inputArray.Max());
            //return Array.FindIndex(inputArray, (num => num != inputArray.Min() && num != inputArray.Max()));
            //return inputArray.ToList().IndexOf(inputArray.OrderBy((x) => inputArray.Average()).First());
            //return Array.IndexOf(inputArray, inputArray.OrderBy((x) => inputArray.Average()).First());
            //return Array.FindIndex(inputArray, v => v == inputArray.OrderBy(d => d).ToArray()[1]);           
            //return inputArray.ToList().IndexOf(inputArray.OrderBy(d => d).ToArray()[1]);
            //return Array.IndexOf(inputArray, inputArray.OrderBy(d => d).ToArray()[1]);
            //return Array.IndexOf(inputArray, inputArray.OrderBy(d => d).ElementAt(1));

            return inputArray.ToList().IndexOf(inputArray.OrderBy(d => d).ElementAt(1));
        }
    }
}