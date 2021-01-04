/*
https://www.codewars.com/kata/54fb853b2c8785dd5e000957/csharp

7 kyu
Chain me

Write a generic function chainer
Write a generic function chainer that takes a starting value, and an array of functions to execute on it (array of symbols for ruby).

The input for each function is the output of the previous function (except the first function, which takes the starting value as it's input). 
Return the final value after execution is complete.

double input = 2;

public static double add(double x) {
  return x + 1;
}

public static double mul(double x) {
   return x * 30;
}
Kata.Chain( input , new[] { (Func<double, double>)add, mul });
//=> returns 90
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class ChainMe
    {
        public static double Chain(double input, Func<double, double>[] fs)
        {
            // foreach (var f in fs)
            //     input = f(input);
            // return input;

            // Array.ForEach(fs, f => { input = f(input); });
            // return input;

            // fs.ToList().ForEach(f => input = f(input));
            // return input;

            // return !fs.Any() ? input : Chain(fs[0](input), fs.Skip(1).ToArray());

            return fs.Aggregate(input, (current, f) => f(current));
        }
    }
}