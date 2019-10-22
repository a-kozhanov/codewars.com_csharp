
//https://www.codewars.com/kata/find-the-first-non-consecutive-number/train/csharp
//https://www.codewars.com/kata/58f8a3a27a5c28d92e000144/solutions/csharp

//Find the first non-consecutive number
//8 kyu

//Your task is to find the first element of an array that is not consecutive.
//E.g. If we have an array [1,2,3,4,6,7,8] then 1 then 2 then 3 then 4 are all consecutive but 6 is not, so that's the first non-consecutive number.
//If the whole array is consecutive then return null or Nothing.
//The array will always have at least 2 elements1 and all elements will be numbers. The numbers will also all be unique and in ascending order.
//The numbers could be positive or negative and the first non-consecutive could be either too!
//If you like this Kata, maybe try this one next: https://www.codewars.com/kata/represent-array-of-numbers-as-ranges
//1) Can you write a solution that will return null for both [] and [ x ] though? ( This is not tested, but you can write your own example test. )


using System;
using System.Linq;

namespace CodeWars
{
    public class FindFirstNonConsecutiveNumber
    {
        public static object FirstNonConsecutive(int[] arr)
        {
            //Console.WriteLine(String.Join(", ", arr));
            //var n1 = Enumerable.Range(arr.First(), arr.Length).Select((v, i) => new { Value = v, Index = i }).Where(x => x.Value != arr[x.Index]).Select(c => arr[c.Index]).First();
            //Console.WriteLine(string.Join(", ", n1));

            //return Array(Enumerable.Range(arr.First(), arr.Length).Select((v, i) => new { Value = v, Index = i }).Where(x => x.Value != arr[x.Index]).Select(c => arr[c.Index]).ToList().Add(null)).First();

            var n = Enumerable.Range(arr.First(), arr.Length).ToArray();
            for (var i = 0; i < n.Length; i++)
            {
                if (arr[i] != n[i]) return arr[i];
            }
            return null;
        }


        //public static object FirstNonConsecutive(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length-1; ++i)
        //    {
        //        if (arr[i] + 1 != arr[i + 1])
        //        {
        //            return arr[i + 1];
        //        }
        //    }
        //    return null;
        //}


        //public static object FirstNonConsecutive(int[] a) => a.Skip(1).SkipWhile((x,i) => x == ++a[i]).Cast<int?>().FirstOrDefault();


        //public static object FirstNonConsecutive(int[] arr)
        //{
        //    for (int i=1;i<arr.Length;i++)
        //        if (arr[i] - arr[i-1] > 1)
        //            return arr[i];
        //    return null; 
        //}



    }
}