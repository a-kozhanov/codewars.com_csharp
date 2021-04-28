/*
https://www.codewars.com/kata/54f9c37106098647f400080a/csharp

7 kyu
The dropWhile Function

Yet another staple for the functional programmer. 
You have a sequence of values and some predicate for those values. 
You want to remove the longest prefix of elements such that the predicate is true for each element. 
We'll call this the dropWhile function. 
It accepts two arguments. 
The first is the sequence of values, and the second is the predicate function. 
The function does not change the value of the original sequence.

Func<int, bool> isEven = (value) => value % 2 == 0;

dropWhile(new int[] { 2, 4, 6, 8, 1, 2, 5, 4, 3, 2 }, isEven) // -> { 1, 2, 5, 4, 3, 2 }
Your task is to implement the dropWhile function. If you've got a span function lying around, this is a one-liner! 
Alternatively, if you have a takeWhile function on your hands, then combined with the dropWhile function, you can implement the span function in one line. 
This is the beauty of functional programming: there are a whole host of useful functions, many of which can be implemented in terms of each other.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class DropWhileFunction
    {
        public static int[] DropWhile(int[] arr, Func<int, bool> pred)
        {
            return arr.SkipWhile(pred).ToArray();
        }
    }
}