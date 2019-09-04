using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://www.codewars.com/kata/sum-of-positive/train/csharp
//

//Sum of positive

//You get an array of numbers, return the sum of all of the positives ones.
//Example [1,-4,7,12] => 1 + 7 + 12 = 20
//Note: if there is nothing to sum, the sum is default to 0.

namespace CodeWars
{
    public class PositiveSum
    {
        public static int positiveSum(int[] arr)
        {
            return arr.Where(n => n > 0).Sum();
        }

        //public static int PositiveSum(int[] arr)
        //{
        //    return arr.Sum(c => (c < 0 ? 0 : c));
        //}


    }
}
