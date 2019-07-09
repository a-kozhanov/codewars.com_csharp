using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

//https://www.codewars.com/kata/generate-range-of-integers/train/csharp
//https://www.codewars.com/kata/55eca815d0d20962e1000106/solutions/csharp

//Generate range of integers

//Implement a function named generateRange(min, max, step), which takes three arguments and generates a range of integers from min to max, with the step.The first integer is the minimum value, the second is the maximum of the range and the third is the step. (min<max)

//Task
//Implement a function named
//GenerateRange(2, 10, 2) == new int[]{ 2, 4, 6, 8, 10 }
//GenerateRange(1, 10, 3) == new int[]{ 1, 4, 7, 10 }

//Note
//min<max
//step > 0
//the range does not HAVE to include max (depending on the step)


namespace CodeWars
{
    public class GenerateRangeIntegers
    {
        public static int[] GenerateRange(int min, int max, int step)
        {
            var result = new List<int>();
            for (var i = min; i <= max; i += step) result.Add(i);
            return result.ToArray();
        }


        //public static int[] GenerateRange(int min, int max, int s) => Enumerable.Range(0, 1 + (max - min) / s).Select(i => min + i * s).ToArray();
        //public static int[] GenerateRange(int min, int max, int step) => Enumerable.Range(0, (max - min) / step + 1).Select(x => min + x * step).ToArray();


        ////###
        //public static int[] GenerateRange(int min, int max, int step)
        //{
        //    return Range(min, max, step).ToArray();
        //}

        //private static IEnumerable<int> Range(int min, int max, int step)
        //{
        //    for (int i = min; i <= max; i += step)
        //    {
        //        yield return i;
        //    }
        //}
        ////###

        //public static int[] GenerateRange(int min, int max, int step)
        //{
        //    return Enumerable.Range(min, max - min + 1).Where(x => (x - min) % step == 0).ToArray();
        //}

        //public static int[] GenerateRange(int min, int max, int step)
        //{
        //    return Enumerable
        //        .Repeat(min, (int)((max - min) / step) + 1)
        //        .Select((tr, ti) => tr + (step * ti))
        //        .ToArray();
        //}

        //public static int[] GenerateRange(int min, int max, int step)
        //{
        //    List<int> vs = new List<int>();
        //    while (min <= max)
        //    {
        //        vs.Add(min);
        //        min += step;
        //    }
        //    return vs.ToArray();
        //}







    }
}
