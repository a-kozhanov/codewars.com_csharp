
//https://www.codewars.com/kata/sum-mixed-array/train/csharp
//https://www.codewars.com/kata/57eaeb9578748ff92a000009/solutions/csharp

//Sum Mixed Array

//Given an array of integers as strings and numbers, return the sum of the array values as if all were numbers.
//Return your answer as a number.

using System;
using System.Linq;

namespace CodeWars
{
    public class SumMixedArray
    {
        public static int SumMix(object[] x)
        {
            return x.Sum(n => int.Parse(n.ToString()));
        }

        //public static int SumMix(object[] x) => x.Sum(ToInt32);

        //public static int SumMix(object[] x)
        //{
        //    var number = 0;

        //    foreach (var val in x)
        //    {
        //        number += int.Parse(val.ToString());
        //    }
        //    return number;
        //}


        //public static int SumMix(object[] x) =>
        //    x.Sum(i => Convert.ToInt32(i));

        //public static int SumMix(object[] x) => x.Where(w => w is IConvertible).Sum(Convert.ToInt32);


        //public static int SumMix(object[] x)
        //{
        //    return x.Sum(Convert.ToInt32);
        //}


        //public static int SumMix(object[] x)
        //{
        //    return x.Select(n => Convert.ToInt32(n)).Sum();

        //}

        //public static int SumMix(object[] x)
        //{
        //    int result = 0;
        //    foreach(object value in x)
        //    {
        //        result += Convert.ToInt32(value);
        //    }
        //    return result;
        //}


    }
}