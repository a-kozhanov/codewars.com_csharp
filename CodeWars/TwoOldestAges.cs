/*
https://www.codewars.com/kata/two-oldest-ages-1/train/csharp
https://www.codewars.com/kata/two-oldest-ages-1/solutions/csharp

7 kyu
Two Oldest Ages

The two oldest ages function/method needs to be completed. 
It should take an array of numbers as its argument and return the two highest numbers within the array. 
The returned value should be an array in the format [second oldest age, oldest age].

The order of the numbers passed in could be any order. The array will always include at least 2 items.

For example:
LargestTwo.TwoOldestAges(new int[] {1, 2, 10, 8}) => new int[] {8, 10}
*/


using System.Linq;

namespace CodeWars
{
    public class KataTwoOldestAges
    {
        public static int[] TwoOldestAges(int[] ages)
        {
            return ages.OrderBy(n => n).TakeLast(2).ToArray();
        }
    }
}