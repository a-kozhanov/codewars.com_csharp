/*
https://www.codewars.com/kata/5783d8f3202c0e486c001d23/csharp

7 kyu
Convert an array of strings to array of numbers

Oh no!
Some really funny web dev gave you an array of numbers from his API response as an array of strings!

You need to cast the whole array to the correct type.

Create the function

JavaScript: toNumberArray(array)
Ruby: toNumberArray(array)
C#: ToDoubleArray(array)
that takes as a parameter an array of numbers represented as strings and outputs an array of numbers.

ie:["1", "2", "3"] to [1, 2, 3]

Note that you can receive floats as well.
*/

using System;
using System.Globalization;
using System.Linq;

namespace CodeWars
{
    public class ConvertAnArrayOfStringsToArrayOfNumbers
    {
        public static double[] ToDoubleArray(string[] stringArray)
        {
            //double.Parse(s, CultureInfo.CreateSpecificCulture("en-US"))
            //double.Parse(s, CultureInfo.GetCultureInfo("en"))
            return stringArray.Select(s => double.Parse(s, CultureInfo.GetCultureInfo("en"))).ToArray();

            //return stringArray.Select(Convert.ToDouble).ToArray();
            //return Array.ConvertAll(stringArray, double.Parse);
            //return stringArray.Select(double.Parse).ToArray();
        }
    }
}