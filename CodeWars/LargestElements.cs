/*
https://www.codewars.com/kata/53d32bea2f2a21f666000256/csharp

7 kyu
Largest Elements

Write a program that outputs the top n elements from a list.

Example:
Kata.Largest(2, new List<int> {7, 6, 5, 4, 3, 2, 1}) => new List<int> {6, 7}
*/

using System.Linq;
using System.Collections.Generic;

namespace CodeWars
{
    public class LargestElements
    {
        public static List<int> Largest(int n, List<int> xs)
        {
            return xs.OrderBy(x => x).TakeLast(n).ToList();
        }
    }
}