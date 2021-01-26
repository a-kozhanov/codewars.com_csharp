/*
https://www.codewars.com/kata/589577f0d1b93ae32a000001/csharp

7 kyu
Simple Fun #88: Sort By Height

Task
Some people are standing in a row in a park. There are trees between them which cannot be moved.

Your task is to rearrange the people by their heights in a non-descending order without moving the trees.

Example
For a = [-1, 150, 190, 170, -1, -1, 160, 180], the output should be

[-1, 150, 160, 170, -1, -1, 180, 190].

Input/Output
[input] integer array a

If a[i] = -1, then the ith position is occupied by a tree. Otherwise a[i] is the height of a person standing in the ith position.

Constraints:

5 ≤ a.length ≤ 30,

-1 ≤ a[i] ≤ 200.

[output] an integer array

Sorted array a with all the trees untouched.
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class SimpleFun88SortByHeight
    {
        public int[] SortByHeight(int[] a)
        {
            var row = new Queue<int>(a.Where(i => i != -1).OrderBy(i => i));
            return a.Select(i => i == -1 ? -1 : row.Dequeue()).ToArray();

            // using var p = a.Where(i => i != -1).OrderBy(i => i).GetEnumerator();
            // return a.Select(n => n == -1 ? -1 : p.MoveNext() ? p.Current : -1).ToArray();

            // var row = a.Where(i => i != -1).OrderBy(i => i).ToList();
            // for (var i = 0; i < a.Length; i++)
            //     if (a[i] == -1)
            //         row.Insert(i, -1);
            // return row.ToArray();
        }
    }
}