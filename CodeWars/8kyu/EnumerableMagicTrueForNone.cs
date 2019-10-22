using System;
using System.Linq;

//https://www.codewars.com/kata/enumerable-magic-number-4-true-for-none/train/csharp
//

//Enumerable Magic #4 - True for None?
//8 kyu

//Create a method none? (JS none) that accepts an array and a block (JS: a function), and returns true if the block (/function) returns true for none of the items in the array. An empty list should return true.
//Ruby: If you need help, here is a reference:
//http://www.rubycuts.com/enum-none


namespace CodeWars
{
    public class EnumerableMagicTrueForNone
    {
        public static bool None(int[] arr, Func<int, bool> fun)
        {
            return arr.All(t => !fun(t));
        }

        //public static bool None(int[] arr, Func<int, bool> fun)
        //{
        //    return !arr.Any(fun);
        //}

    }
}