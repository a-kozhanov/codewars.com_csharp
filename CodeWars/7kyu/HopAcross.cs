/*
https://www.codewars.com/kata/5a60d519400f93fc450032e5/csharp

7 kyu
Hop Across

You are trying to cross a river by jumping along stones. 
Every time you land on a stone, you hop forwards by the value of that stone. 
If you skip over a stone then its value doesn't affect you in any way. Eg:

 x--x-----x-->
[1][2][5][1]
Of course, crossing from the other side might give you a different answer:

 <--------x--x
   [1][2][5][1]
Given an array of positive integers, return the total number of steps it would take to go all the way across the river (and past the end of the array) and then all the way back. 
All arrays will contain at least one element, and may contain up to 100 elements.

Examples
  x--x-----x-->
 [1][2][1][2]
<----x-----x

therefore hop_across([1,2,1,2]) = 3 + 2 = 5

   x-----x--------x------>
  [2][2][3][1][1][2][1]
<--------x--x-----x--x

therefore hop_across([2,2,3,1,1,2,1]) = 3 + 4 = 7
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class KataHopAcross
    {
        public static int HopAcross(List<int> lst)
        {
            var jump = 0;
            for (var i = 0; i < lst.Count; i += lst[i]) jump++;
            for (var i = lst.Count - 1; i >= 0; i -= lst[i]) jump++;
            return jump;
        }
    }
}