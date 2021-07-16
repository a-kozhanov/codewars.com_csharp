/*
https://www.codewars.com/kata/56b7251b81290caf76000978/csharp

7 kyu
Find Fibonacci last digit

As you probably know, Fibonacci sequence are the numbers in the following integer sequence: 1, 1, 2, 3, 5, 8, 13... 
Write a method that takes the index as an argument and returns last digit from fibonacci number. Example: getLastDigit(15) - 610. 
Your method must return 0 because the last digit of 610 is 0. 
Fibonacci sequence grows very fast and value can take very big numbers (bigger than integer type can contain), so, please, be careful with overflow.

Hardcore version of this kata, no bruteforce will work here ;)
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class FindFibonacciLastDigit
    {
        public static int GetLastDigit(int index)
        {
            return "011235831459437077415617853819099875279651673033695493257291"[index % 60] - '0';


            // string ds = "011235831459437077415617853819099875279651673033695493257291";
            // return ds[index % ds.Length] - '0';


            // return (int) (Math.Round(Math.Pow((1.0 + Math.Sqrt(5)) / 2, index % 60) / Math.Sqrt(5)) % 10);
            // return (int) (Math.Round(Math.Pow((1 + Math.Sqrt(5)) / 2, index % 60) / Math.Sqrt(5)) % 10);

            // return Enumerable.Range(0, index - 1).Aggregate(new Queue<int>(Enumerable.Repeat(1, 2)), (q, _) =>
            // {
            //     q.Enqueue(q.Sum() % 10);
            //     q.Dequeue();
            //     return q;
            // }).Dequeue();


            // int a = 0, b = 1;
            // for (int i = 0; i < index; ++i)
            // {
            //     b = a + b;
            //     a = b - a;
            //     b %= 10;
            // }
            // return a;
        }
    }
}