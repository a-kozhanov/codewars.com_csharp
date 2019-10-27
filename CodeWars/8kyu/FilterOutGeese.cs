using System;
using System.Collections.Generic;
using System.Linq;

//https://www.codewars.com/kata/filter-out-the-geese/train/csharp
//https://www.codewars.com/kata/57ee4a67108d3fd9eb0000e7/solutions/csharp

//Filter out the geese

//Write a function, gooseFilter / goose-filter / goose_filter /GooseFilter, that takes an array of strings as an argument and returns a filtered array containing the same elements but with the 'geese' removed.

//The geese are any strings in the following array, which is pre-populated in your solution:

//var geese = new[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };
//For example, if this array were passed as an argument:

//new string[] {"Mallard", "Hook Bill", "African", "Crested", "Pilgrim", "Toulouse", "Blue Swedish"}
//Your function would return the following array:

//new string[] {"Mallard", "Hook Bill", "Crested", "Blue Swedish"}
//The elements in the returned array should be in the same order as in the initial array passed to your function, albeit with the 'geese' removed. Note that all of the strings will be in the same case as those provided, and some elements may be repeated.


namespace CodeWars
{
    public class FilterOutGeese
    {
        public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
        {
            string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };
            return birds.Where(bird => !geese.Contains(bird)).ToList();
        }


        //private static string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };
        //public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
        //{
        //    return birds.Except(geese);
        //}


        //public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
        //{
        //    var geese = new[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };
        //    return birds.Except(geese);
        //}

        //public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
        //{
        //    List<string> result = birds.ToList();

        //    // return IEnumerable of string containing all of the strings in the input collection, except those that match strings in geese
        //    string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };

        //    result.RemoveAll(x => geese.ToList().Contains(x));

        //    return result;
        //}


        //public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
        //{
        //    var noGeese = new List<string>();
        //    string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };
        //    foreach(var bird in birds)
        //    {
        //        if(Array.FindIndex(geese, x => x.Contains(bird)) == -1)
        //        {
        //            noGeese.Add(bird);
        //        }
        //    }
        //    return noGeese;
        //}

    }
}