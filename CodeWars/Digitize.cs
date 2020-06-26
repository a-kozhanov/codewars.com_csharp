/*
https://www.codewars.com/kata/5417423f9e2e6c2f040002ae/csharp

7 kyu
Digitize

Given a non-negative integer, return an array / a list of the individual digits in order.

Examples:
123 => [1,2,3]
1 => [1]
8675309 => [8,6,7,5,3,0,9]
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class Digitize
    {
        public static int[] digitize(int n)
        {
            //return n.ToString().Select(c => int.Parse(c.ToString())).ToArray();
            //return Array.ConvertAll(n.ToString().ToArray(), c => (int) c - 48);
            //return n.ToString().Select(c => c - '0').ToArray();
            //return n.ToString().Select(c => c - 48).ToArray();
            
            return $"{n}".Select(c => int.Parse($"{c}")).ToArray();
            //return $"{n}".Select(c => c - '0').ToArray();
            //return $"{n}".Select(c => c - 48).ToArray();
        }
    }
}