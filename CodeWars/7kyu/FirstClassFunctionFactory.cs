/*
https://www.codewars.com/kata/563f879ecbb8fcab31000041/csharp

7 kyu
First-Class Function Factory

Write a function, factory, that takes a number as its parameter and returns another function.

The returned function should take an array of numbers as its parameter, 
and return an array of those numbers multiplied by the number that was passed into the first function.

In the example below, 5 is the number passed into the first function. 
So it returns a function that takes an array and multiplies all elements in it by five.

Translations and comments (and upvotes) welcome!

Example
Func<int[],int[]> fives = FunctionFactory.factory(5);    // returns a function - fives
int[] myArray = new int[]{1, 2, 3};
fives(myArray);                  //returns [5, 10, 15];
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class FirstClassFunctionFactory
    {
        public static Func<int[], int[]> factory(int x)
        {
            return a => a.Select(y => y * x).ToArray();
            // return a => Array.ConvertAll(a, n => n * x);
        }
    }
}