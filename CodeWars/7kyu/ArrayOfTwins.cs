/*
https://www.codewars.com/kata/58fdc60ed94f25a863000092/csharp

7 kyu
Array of twins

You are given an array of numbers. 
Check if the array contains of pairs, i.e every number occurs exactly two times. 
If true, return true, otherwise false. Your solution should not modify the input array.
*/

using System.Linq;

namespace CodeWars
{
    public class ArrayOfTwins
    {
        public static bool Twins(int[] arr)
        {
            return arr.GroupBy(i => i).All(x => x.Count() == 2);
            //return arr.Distinct().All(x => arr.Count(i => i == x) == 2);
            //return arr.Count(x => arr.Count(i => i == x) == 2) == arr.Length;
            //return arr.GroupBy(x => x).Count(x => x.Count() == 2) == arr.Length / 2;
        }
    }
}