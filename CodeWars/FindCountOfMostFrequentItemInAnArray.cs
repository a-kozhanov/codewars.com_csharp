/*
https://www.codewars.com/kata/56582133c932d8239900002e/csharp

7 kyu
Find Count of Most Frequent Item in an Array

Complete the function to find the count of the most frequent item of an array. 
You can assume that input is an array of integers. For an empty array return 0

Example
input array: [3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3]
ouptut: 5 
The most frequent number in the array is -1 and it occurs 5 times.
*/

using System.Linq;

namespace CodeWars
{
    public class FindCountOfMostFrequentItemInAnArray
    {
        public static int MostFrequentItemCount(int[] collection)
        {
            //return collection.Length == 0 ? 0 : collection.GroupBy(i => i).Max(g => g.Count());
            //return collection.GroupBy(i => i).Select(g => g.Count()).DefaultIfEmpty(0).Max();
            return collection.Any() ? 0 : collection.GroupBy(i => i).Max(g => g.Count());
        }
    }
}