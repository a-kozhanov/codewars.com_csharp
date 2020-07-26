/*
https://www.codewars.com/kata/523f5d21c841566fde000009/csharp

6 kyu
Array.diff

Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.

It should remove all values from list a, which are present in list b.

Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}
If a value is present in b, all of its occurrences must be removed from the other:

Kata.ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2}) => new int[] {1, 3}
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class KataArrayDiff
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            //return b.Aggregate(a, (c, n) => c.Where(i => i != n).ToArray());
            //return a.Where(i => !Array.Exists(b, m => m == i)).ToArray();
            //return a.Where(x => b.All(i => i != x)).ToArray();
            //return a.Where(x => !b.Contains(x)).ToArray();
            return Array.FindAll(a, m => !b.Contains(m));
        }
    }
}