/*
https://www.codewars.com/kata/smallest-unused-id/train/csharp
https://www.codewars.com/kata/55eea63119278d571d00006a/solutions/csharp

8 kyu
Smallest unused ID

Hey awesome programmer!

You've got much data to manage and of course you use zero-based and non-negative ID's to make each data item unique!

Therefore you need a method, which returns the smallest unused ID for your next new data item...

Note: The given array of used IDs may be unsorted. For test reasons there may be duplicate IDs, but you don't have to find or remove them!

Go on and code some pure awesomeness!
*/

using System.Linq;

namespace CodeWars
{
    public class SmallestUnusedID
    {
        public static int NextId(int[] ids)
        {
            for (var i = 0; i < ids.Length + 1; i++)
            {
                if (!ids.Contains(i)) return i;
            }

            return 0;
        }
        //public static int NextId(int[] ids) => Enumerable.Range(0, ids.Length + 1).First(x => !ids.Contains(x));



        //public static int NextId(int[] ids)
        //{
        //    var f= Enumerable.Range(0, ids.Max()).Except(ids);
        //    return f.Count() == 0 ? ids.Max() + 1 : f.First();
        //}


        //public static int NextId(int[] ids)
        //{
        //    return Enumerable.Range(0,ids.Length+1).Except(ids).Min();
        //}


        //public static int NextId(int[] ids)
        //{
        //    return Enumerable.Range(0,ids.Length+1).First(x=>!ids.Contains(x));
        //}

    }
}