/*
https://www.codewars.com/kata/pre-fizzbuzz-workout-number-1/train/csharp
https://www.codewars.com/kata/569e09850a8e371ab200000b/solutions/csharp

8 kyu
Pre-FizzBuzz Workout #1

This is the first step to understanding FizzBuzz.
Your inputs: a positive integer, n, greater than or equal to one. n is provided, you have NO CONTROL over its value.
Your expected output is an array of positive integers from 1 to n (inclusive).
Your job is to write an algorithm that gets you from the input to the output.

*/

using System.Linq;

namespace CodeWars
{
    public class PreFizzBuzzWorkout1
    {
        public static int[] PreFizz(int n)
        {
            return Enumerable.Range(1, n).ToArray();
        }
    }
}
