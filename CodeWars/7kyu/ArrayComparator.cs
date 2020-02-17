/*
https://www.codewars.com/kata/561046a9f629a8aac000001d/train/csharp
https://www.codewars.com/kata/561046a9f629a8aac000001d/solutions/csharp

7 kyu
Array comparator

You have two arrays in this kata, every array contain only unique elements. 
Your task is to calculate number of elements in first array which also are in second array.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class ArrayComparator
    {
        public static int MatchArrays(int[] v, int[] r)
        {
            return v.Count(r.Contains);
            //return r.Count(v.Contains);
        }

//        public static int MatchArrays(int[] v, int[] r)
//        {
//            return v.Intersect(r).Count();
//        }

//        public static int MatchArrays(int[] a, int[] b) => a.Where(e => Array.IndexOf(b, e) != -1).Count();

//        public static int MatchArrays(int[] v, int[] r) => v.Intersect(r).ToArray().Length;

//        public static int MatchArrays(int[] v, int[] r)
//        {
//            return v.Count() - (v.Except(r)).Count();
//        }

//        public static int MatchArrays(int[] v, int[] r)
//        {
//            var hs = new HashSet<int>(r);
//            return v.Select(x => hs.Contains(x) ? 1 : 0).Sum();
//        }

//        public static int MatchArrays(int[] v, int[] r)
//        {
//            return v.Length - v.Except(r).Count();
//        }


//        public static int MatchArrays(int[] v, int[] r)
//        {
//            return r.Length + v.Length - v.Union(r).Count();
//        }
    }
}