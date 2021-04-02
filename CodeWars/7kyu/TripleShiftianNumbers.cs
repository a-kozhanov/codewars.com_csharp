/*
https://www.codewars.com/kata/56b7526481290c2ff1000c75/csharp

7 kyu
Triple Shiftian Numbers

Much cooler than your run-of-the-mill Fibonacci numbers, the Triple Shiftian are so defined: T[n] = 4 * T[n-1] - 5 * T[n-2] + 3 * T[n-3].

You are asked to create a function which accept a base with the first 3 numbers and then returns the nth element.

tripleShiftian(new int[] { 1,1,1 },25) == 1219856746
tripleShiftian(new int[] { 1,2,3 },25) == 2052198929
tripleShiftian(new int[] { 6,7,2 },25) == -2575238999
tripleShiftian(new int[] { 3,2,1 },35) == 23471258855679
tripleShiftian(new int[] { 1,9,2 },2) ==  2
Note: this is meant to be an interview quiz, so the description is scarce in detail on purpose

Special thanks to the first person I met in person here in London just because of CW and that assisted me during the creation of this kata ;)
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class TripleShiftianNumbers
    {
        public static long TripleShiftian(int[] baseValues, int n)
        {
            var values = baseValues.Select(i => (long) i).ToList();
            for (var i = 2; i <= n; i++)
            {
                values.Add(4 * values[i] - 5 * values[i - 1] + 3 * values[i - 2]);
            }

            return values[n];
        }
    }
}