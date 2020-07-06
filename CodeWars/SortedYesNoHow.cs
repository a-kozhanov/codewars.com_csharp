/*
https://www.codewars.com/kata/580a4734d6df748060000045/csharp

7 kyu
Sorted? yes? no? how?

Complete the method which accepts an array of integers, and returns one of the following:

"yes, ascending" - if the numbers in the array are sorted in an ascending order
"yes, descending" - if the numbers in the array are sorted in a descending order
"no" - otherwise

You can assume the array will always be valid, and there will always be one correct answer.
*/

using System.Linq;

namespace CodeWars
{
    public class SortedYesNoHow
    {
        public static string IsSortedAndHow(int[] array)
        {
            //return array.OrderByDescending(i => i).SequenceEqual(array) ? "yes, descending" : array.OrderBy(i => i).SequenceEqual(array) ? "yes, ascending" : "no";
            //return array.SequenceEqual(array.OrderBy(i => i)) ? "yes, ascending" : array.SequenceEqual(array.OrderByDescending(i => i)) ? "yes, descending" : "no";
            //return array.SequenceEqual(array.OrderBy(i => i)) ? "yes, ascending" : array.SequenceEqual(array.OrderByDescending(i => i)) ? "yes, descending" : "no";
            //return array.SequenceEqual(array.OrderBy(i => i)) ? "yes, ascending" : array.SequenceEqual(array.OrderBy(i => -i)) ? "yes, descending" : "no";
            //return array.OrderBy(i => i).SequenceEqual(array) ? "yes, ascending" : array.OrderBy(i => -i).SequenceEqual(array) ? "yes, descending" : "no";
            return array.OrderBy(i => i).SequenceEqual(array) ? "yes, ascending" :
                array.OrderBy(i => -i).SequenceEqual(array) ? "yes, descending" : "no";
        }
    }
}