using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//https://www.codewars.com/kata/array-plus-array/train/csharp
//https://www.codewars.com/kata/5a2be17aee1aaefe2a000151/solutions/csharp

//Array plus array

//I'm new to coding and now I want to get the sum of two arrays...actually the sum of all their elements. I'll appreciate for your help.
//P.S.Each array includes only integer numbers.Output is a number too.

namespace CodeWars
{
    public class KataArrayPlusArray
    {
        public static int ArrayPlusArray(int[] arr1, int[] arr2)
        {
            return arr1.Sum() + arr2.Sum();
        }
    }
}
