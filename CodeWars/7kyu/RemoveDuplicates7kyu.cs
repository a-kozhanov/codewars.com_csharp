/*
https://www.codewars.com/kata/53e30ec0116393fe1a00060b/csharp

7 kyu
Remove Duplicates

Remove Duplicates
You are to write a function called unique that takes an array of integers and returns the array with duplicates removed. 
It must return the values in the same order as first seen in the given array. 
Thus no sorting should be done, 
if 52 appears before 10 in the given array then it should also be that 52 appears before 10 in the returned array.

Assumptions
All values given are integers (they can be positive or negative).
You are given an array but it may be empty.
They array may have duplicates or it may not.
Example
puts unique([1, 5, 2, 0, 2, -3, 1, 10]).inspect
[1, 5, 2, 0, -3, 10]

puts unique([]).inspect
[]

puts unique([5, 2, 1, 3]).inspect
[5, 2, 1, 3]
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class RemoveDuplicates7kyu
    {
        public static List<int> Unique(List<int> integers)
        {
            //return integers.GroupBy(x => x).Select(x => x.Key).ToList();
            //return new HashSet<int>(integers).ToList();
            //return integers.ToHashSet().ToList();
            return integers.Distinct().ToList();
        }
    }
}