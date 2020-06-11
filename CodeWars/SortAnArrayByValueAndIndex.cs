/*
https://www.codewars.com/kata/58e0cb3634a3027180000040/csharp

7 kyu
Sort an array by value and index

Your task is to sort an array of integer numbers by the product of the value and the index of the positions.

For sorting the index starts at 1, NOT at 0!
The sorting has to be ascending.
The array will never be null and will always contain numbers.

Example:

Input: 23, 2, 3, 4, 5
Product of value and index:
23 => 23 * 1 = 23  -> Output-Pos 4
 2 =>  2 * 2 = 4   -> Output-Pos 1
 3 =>  3 * 3 = 9   -> Output-Pos 2
 4 =>  4 * 4 = 16  -> Output-Pos 3
 5 =>  5 * 5 = 25  -> Output-Pos 5

Output: 2, 3, 4, 23, 5



Have fun coding it and please don't forget to vote and rank this kata! :-)

I have also created other katas. Take a look if you enjoyed this kata!
*/

using System.Linq;

namespace CodeWars
{
    public class SortAnArrayByValueAndIndex
    {
        public static int[] SortByValueAndIndex(int[] array, int i = 1)
        {
            //return  array.Select((x, i) => new {mul = x * (i + 1), value = x}).OrderBy(x=> x.mul).Select(x => x.value).ToArray();
            //return Enumerable.Range(0, array.Length).OrderBy(x => array[x] * (x + 1)).Select(y => array[y]).ToArray();
            return array.OrderBy(n => n * i++).ToArray();
        }
    }
}