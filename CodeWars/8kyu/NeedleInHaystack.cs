using System;
using System.Linq;

//https://www.codewars.com/kata/a-needle-in-the-haystack/train/csharp
//https://www.codewars.com/kata/56676e8fabd2d1ff3000000c/solutions/csharp

//A Needle in the Haystack

//Can you find the needle in the haystack?
//Write a function findNeedle() that takes an array full of junk but containing one "needle"
//After your function finds the needle it should return a message(as a string) that says:
//"found the needle at position " plus the index it found the needle, so:
//find_needle(['hay', 'junk', 'hay', 'hay', 'moreJunk', 'needle', 'randomJunk'])
//should return "found the needle at position 5"

namespace CodeWars
{
    public class NeedleInHaystack
    {
        public static string FindNeedle(object[] haystack)
        {
            return $"found the needle at position {haystack.ToList().IndexOf("needle")}";

            // for (int i = 0; i < haystack.Length; i++)
            // {
            //     if (Convert.ToString(haystack[i]) == "needle") return $"found the needle at position {i}";
            // }
            //
            // return "Not found the needle in haystack";
        }


        //public static string FindNeedle(object[] haystack)
        //{
        //    return "found the needle at position " + Array.IndexOf(haystack, "needle");
        //}

        //public static string FindNeedle(object[] haystack)
        //{
        //    return $"found the needle at position {Array.IndexOf(haystack, "needle")}";
        //}


        //public static string FindNeedle(object[] haystack)
        //{
        //    return string.Format("found the needle at position {0}", Array.IndexOf(haystack, "needle"));
        //}

        //public static string FindNeedle(object[] haystack)
        //{
        //    return string.Format("found the needle at position {0}", haystack.ToList().IndexOf("needle"));
        //}

        //public static string FindNeedle(object[] haystack)
        //{
        //    var index = Array.IndexOf(haystack, "needle");
        //    if (index >= 0)
        //    {
        //        return $"found the needle at position {index}";
        //    }

        //    return "";
        //}


        //public static string FindNeedle(object[] haystack)
        //{
        //    return string.Concat("found the needle at position ", Array.IndexOf(haystack, "needle"));
        //}
    }
}