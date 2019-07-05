
//https://www.codewars.com/kata/you-only-need-one-beginner/train/csharp
//https://www.codewars.com/kata/57cc975ed542d3148f00015b/solutions/csharp

//You only need one - Beginner

//You will be given an array a and a value x. All you need to do is check whether the provided array contains the value.
//Array can contain numbers or strings. X can be either.
//Return true if the array contains the value, false if not.

using System;
using System.Linq;

namespace CodeWars
{
    public class YouOnlyNeedOneBeginner
    {
        public static bool Check(object[] a, object x)
        {
            return a.ToArray().Any(o => o.ToString() == x.ToString());
        }

        //public static bool Check(object[] a, object x)
        //{
        //    return a.Contains(x);
        //}


        //public static bool Check(object[] a, object x)
        //{
        //    bool rez = false;
        //    foreach (var item in a)
        //    {
        //        if (item.Equals(x))
        //        {
        //            rez = true;
        //        }
        //    }
        //    return rez;
        //}


        //public static bool Check(object[] a, object x)
        //{
        //    return Array.IndexOf(a, x) != -1;
        //}


        //public static bool Check(object[] a, object x)
        //{
        //    return a.Any(y => y.ToString() == x.ToString());
        //}


        //public static bool Check(object[] a, object x)
        //{
        //    return a.ToList().Any(i => i.Equals(x));
        //}


        //public static bool Check(object[] a, object x)
        //{
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (Object.Equals(a[i], x)) return true;
        //    }
        //    return false;
        //}





    }
}