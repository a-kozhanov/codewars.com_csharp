/*
https://www.codewars.com/kata/5834315e06f227a6ac000099/csharp

7 kyu
Find twins

Agent 47, you have a new task! Among citizens of the city X are hidden 2 dangerous criminal twins. Your task is to identify them and eliminate!

Given an array of integers, your task is to find two same numbers and return one of them, for example in array [2, 3, 6, 34, 7, 8, 2] answer is 2.

If there are no twins in the city - return None or the equivalent in the language that you are using.
*/

using System.Linq;

namespace CodeWars
{
    public class FindTwins
    {
        public static object Elimination(int[] arr)
        {
            // var result = arr.Where(x => arr.Count(i => i == x) > 1).DefaultIfEmpty(-1).FirstOrDefault();
            // return result != -1 ? result : (object) null;

            //return arr.ToLookup(n => n).FirstOrDefault(g => g.Count() == 2)?.Key;
            return arr.GroupBy(i => i).FirstOrDefault(g => g.Count() == 2)?.Key;
        }
    }
}