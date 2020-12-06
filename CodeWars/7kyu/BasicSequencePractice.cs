/*
https://www.codewars.com/kata/5436f26c4e3d6c40e5000282/csharp

7 kyu
Basic Sequence Practice

A sequence or a series, in mathematics, is a string of objects, like numbers, that follow a particular pattern. 
The individual elements in a sequence are called terms. A simple example is 3, 6, 9, 12, 15, 18, 21, ..., 
where the pattern is: "add 3 to the previous term".

In this kata, we will be using a more complicated sequence: 0, 1, 3, 6, 10, 15, 21, 28, ... 
This sequence is generated with the pattern: "the nth term is the sum of numbers from 0 to n, inclusive".

[ 0,  1,    3,      6,   ...]
  0  0+1  0+1+2  0+1+2+3
  
Your Task
Complete the function that takes an integer n and returns a list/array of length abs(n) + 1 of the arithmetic series explained above. 
Whenn < 0 return the sequence with negative terms.

Examples
 5  -->  [0,  1,  3,  6,  10,  15]
-5  -->  [0, -1, -3, -6, -10, -15]
 7  -->  [0,  1,  3,  6,  10,  15,  21,  28]
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class BasicSequencePractice
    {
        public static int[] SumOfN(int n)
        {
            //return Enumerable.Range(0, Math.Abs(n) + 1).Select((x, i) => Enumerable.Range(1, Math.Abs(n)).Take(i).Sum(j => n < 0 ? -j : j)).ToArray();
            //return Enumerable.Range(0, Math.Abs(n) + 1).Select(x => Enumerable.Range(0, x + 1).Sum(i => i * Math.Sign(n))).ToArray();
            //return Enumerable.Range(0, Math.Abs(n) + 1).Select(i => Enumerable.Range(1, i).Sum() * Math.Sign(n)).ToArray();
            //return Enumerable.Range(0, Math.Abs(n) + 1).Select(i => Math.Sign(n) * i * (Math.Abs(i) + 1) / 2).ToArray();
            //return Enumerable.Range(0, Math.Abs(n) + 1).Select(i => (int) ((i + 1) / 2f * (n < 0 ? -i : i))).ToArray();
            //return Enumerable.Range(0, Math.Abs(n) + 1).Select((x) => Math.Sign(n) * x * (x + 1) / 2).ToArray();
            //return Enumerable.Range(0, Math.Abs(n) + 1).Select(i => i * (i + 1) / (n < 0 ? -2 : 2)).ToArray();
            return Enumerable.Range(0, Math.Abs(n) + 1).Select(i => Math.Sign(n) * i * (i + 1) / 2).ToArray();
        }
    }
}