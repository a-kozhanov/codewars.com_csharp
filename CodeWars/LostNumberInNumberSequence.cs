/*
https://www.codewars.com/kata/595aa94353e43a8746000120/csharp

7 kyu
Lost number in number sequence

An ordered sequence of numbers from 1 to N is given. One number might have deleted from it, then the remaining numbers were mixed. Find the number that was deleted.

Example:

The starting array sequence is [1,2,3,4,5,6,7,8,9]
The mixed array with one deleted number is [3,2,4,6,7,8,1,9]
Your function should return the int 5.
If no number was deleted from the array and no difference with it, your function should return the int 0.

Note that N may be 1 or less (in the latter case, the first array will be []).
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class LostNumberInNumberSequence
    {
        public static int FindDeletedNumber(List<int> startingList, List<int> mixedList)
        {
            return startingList.Except(mixedList).FirstOrDefault(x => x < mixedList.DefaultIfEmpty(2).Max());
        }
    }
}