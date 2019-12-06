/*
https://www.codewars.com/kata/enumerable-magic-number-2-true-for-any/train/csharp
https://www.codewars.com/kata/54598e89cbae2ac001001135/solutions/csharp

8 kyu
Enumerable Magic #2 - True for Any?

Create an any? (JS: any) function that accepts an array and a block (JS: function), 
and returns true if the block (/function) returns true for any item in the array. 
If the array is empty, the function should return false.
Ruby: If you get stuck, you can read up here:

http://www.rubycuts.com/enum-any
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class EnumerableMagic2TrueForAny
    {
        public static bool Any(int[] arr, Func<int, bool> fun)
        {
            return arr.Any(fun);
        }
    }
}
