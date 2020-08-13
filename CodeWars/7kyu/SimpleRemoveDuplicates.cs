/*
https://www.codewars.com/kata/5ba38ba180824a86850000f7/csharp

7 kyu
Simple remove duplicates

In this Kata, you will remove the left-most duplicates from a list of integers and return the result.

// Remove the 3's at indices 0 and 3
// followed by removing a 4 at index 1
solve([3, 4, 4, 3, 6, 3]); // => [4, 6, 3]
More examples can be found in the test cases.

Good luck!
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class SimpleRemoveDuplicates
    {
        public static int[] solve(int[] arr)
        {
            //return arr.Reverse().GroupBy(x => x).Select(gr => gr.Key).Reverse().ToArray();
            //return arr.Distinct().OrderBy(x => arr.ToList().LastIndexOf(x)).ToArray();
            //return new HashSet<int>(arr.Reverse()).Reverse().ToArray();
            //return arr.Reverse().Distinct().Reverse().ToArray();
            return arr.Reverse().Union(arr).Reverse().ToArray();
        }
    }
}