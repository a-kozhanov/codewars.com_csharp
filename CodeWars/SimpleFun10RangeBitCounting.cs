/*
https://www.codewars.com/kata/58845748bd5733f1b300001f/train/csharp
https://www.codewars.com/kata/58845748bd5733f1b300001f/solutions/csharp

7 kyu
Simple Fun #10: Range Bit Counting

Task
You are given two numbers a and b where 0 ≤ a ≤ b. 
Imagine you construct an array of all the integers from a to b inclusive. 
You need to count the number of 1s in the binary representations of all the numbers in the array.

Example
For a = 2 and b = 7, the output should be 11
Given a = 2 and b = 7 the array is: [2, 3, 4, 5, 6, 7]. 
Converting the numbers to binary, we get [10, 11, 100, 101, 110, 111], 
which contains 1 + 2 + 1 + 2 + 2 + 3 = 11 1s.

Input/Output
[input] integer a
Constraints: 0 ≤ a ≤ b.
[input] integer b
Constraints: a ≤ b ≤ 100.
[output] an integer
*/

using System;
using System.Collections;
using System.Linq;

namespace CodeWars
{
    public class SimpleFun10RangeBitCounting
    {
        public int RangeBitCount(int a, int b)
        {
            return string.Concat(Enumerable.Range(a, b - a + 1).Select(x => Convert.ToString(x, 2)))
                .Count(x => x == '1');
        }

        // public int RangeBitCount(int a,int b)
        // {
        //     return Enumerable
        //         .Range(a, b - a + 1)
        //         .Aggregate("",(c,n) => c + Convert.ToString(n, 2))
        //         .Count(c => c == '1');         
        // }

        // public int RangeBitCount(int a,int b)
        // {
        //     int result = 0;
        //     for (int i = a;i<=b;i++)
        //     {
        //         var binary = Convert.ToString(i, 2);
        //         for(int y = 0;y<binary.Length;y++)
        //         {
        //             if(binary[y] ==  '1') { result++; }
        //         }
        //     }
        //     return result;
        // }


        // public int RangeBitCount(int a,int b)
        // {
        //     return Enumerable.Range(a, b - a + 1).Select(x => Convert.ToString(x, 2)).Aggregate((x, y) => x + y).Count(x => x == '1');
        // }


        // public int RangeBitCount(int a, int b)
        // {
        //     int[] test = Enumerable.Range(a, b - a + 1).ToArray();
        //     return String.Concat(test.Select(x => Convert.ToString(x, 2))).Count(v => v == '1');
        // }


        // public class Kata
        // {
        //     public int RangeBitCount(int a,int b) => Enumerable.Range(a, b-a+1).Sum(x => CountBits(x));
        //     public int CountBits(int a, int bits = 0) => a == 0 ? bits : CountBits(a & (a-1), ++bits);
        // }
    }
}