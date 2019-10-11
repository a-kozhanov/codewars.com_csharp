
//https://www.codewars.com/kata/remove-duplicates-from-list/train/csharp
//https://www.codewars.com/kata/57a5b0dfcf1fa526bb000118/solutions/csharp

//Remove duplicates from list
//8 kyu

//Define a function that removes duplicates from an array of numbers and returns it as a result.
//The order of the sequence has to stay the same.


using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class RemoveDuplicatesFromList
    {
        public static int[] distinct(int[] a)
        {
            return a.Distinct().ToArray();
        }


        //public static int[] distinct(int[] a)
        //{
        //    return a.GroupBy(x => x).Select(x => x.First()).ToArray();
        //}


        //public static int[] distinct(int[] a)
        //{
        //    List<int> list = new List<int>();
        //    foreach(int x in a)
        //    {
        //        if( !list.Contains( x ) )
        //            list.Add( x );
        //    }
        //    return list.ToArray();
        //}


    }
}