/*
https://www.codewars.com/kata/5a9e86705ee396d6be000091/csharp

7 kyu
Check three and two

Given an array with exactly 5 strings "a", "b" or "c" (chars in Java, characters in Fortran), 
check if the array contains three and two of the same values.

Examples
["a", "a", "a", "b", "b"] ==> true  // 3x "a" and 2x "b"
["a", "b", "c", "b", "c"] ==> false // 1x "a", 2x "b" and 2x "c"
["a", "a", "a", "a", "a"] ==> false // 5x "a"
*/

using System.Linq;

namespace CodeWars
{
    public class KataCheckThreeAndTwo
    {
        public static bool CheckThreeAndTwo(string[] array)
        {
            //return array.Length == 5 && array.Distinct().Count() == 2 && (array.Count(s => s == array[0]) == 2 || array.Count(s => s == array[0]) == 3);
            //return array.GroupBy(s => s).Select(x => new {x.Key, countX = x.Count()}).All(x => x.countX == 2 || x.countX == 3);
            //return array.GroupBy(s => s).Where(g => g.Count() == 3 || g.Count() == 2).Sum(g => g.Count()) == array.Length;
            //return array.Distinct().Select(x => array.Count(c => c == x)).Where(x => x > 1 && x < 4).Sum() == 5;
            //return array.GroupBy(s => s).Select(x => x.Count()).OrderBy(x => x).SequenceEqual(new int[] {2, 3});
            //return new[] {2, 3}.SequenceEqual(array.GroupBy(s => s).Select(g => g.Count()).OrderBy(x => x));
            //return array.GroupBy(s => s, (s, e) => e.Count()).Except(new[] {2, 3}).Any() == false;
            //return array.GroupBy(s => s).Select(c => c.Count()).All(c => c == 2 || c == 3);
            //return array.GroupBy(s => s).All(g => g.Count() == 2 || g.Count() == 3);
            return array.GroupBy(s => s).All(g => new[] {2, 3}.Contains(g.Count()));
        }
    }
}