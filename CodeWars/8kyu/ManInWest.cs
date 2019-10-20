
//https://www.codewars.com/kata/man-in-the-west/train/csharp
//https://www.codewars.com/kata/59bd5dc270a3b7350c00008b/solutions/csharp

//Man in the west
//8 kyu

//A western man is trying to find gold in a river.
//To do that, he passes a bucket through the river's soil and then checks if it contains any gold.
//However, he could be more productive if he wrote an algorithm to do the job for him.
//So, you need to check if there is gold in the bucket, and if so, return True/true. If not, return False/false.

using System;
using System.Linq;

namespace CodeWars
{
    public class ManInWest
    {
        public static bool CheckTheBucket(string[] bucket)
        {
            return bucket.Contains("gold");
        }

        //public static bool CheckTheBucket(string[] a) => a.Contains("gold");


        //public static bool CheckTheBucket(string[] bucket)
        //{
        //    foreach(string Item in bucket)
        //    {
        //        if (Item == "gold"){return true;}
        //    }
        //    return false;
        //}


        //public static bool CheckTheBucket(string[] bucket) => bucket.Any(x => x == "gold");


        //public static bool CheckTheBucket(string[] bucket)
        //{
        //    return Array.IndexOf(bucket, "gold") != -1;
        //}


        //public static bool CheckTheBucket(string[] bucket)
        //{
        //    return Array.IndexOf(bucket, "gold") > -1 ? true : false;
        //}

    }
}