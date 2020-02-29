/*
https://www.codewars.com/kata/53dbd5315a3c69eed20002dd/train/csharp
https://www.codewars.com/kata/53dbd5315a3c69eed20002dd/solutions/csharp

7 kyu
List Filtering

In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.

Example
ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"}) => {1, 2}
ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", 0, 15}) => {1, 2, 0, 15}
ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", "aasf", "1", "123", 231}) => {1, 2, 231}
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class ListFiltering
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> list)
        {
            return list.OfType<int>();
        }

        // public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        // {
        //     return listOfItems.OfType<int>().Cast<int>();
        // }


        // public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        // {
        //     List<int> results = new List<int>();
        //
        //     foreach(var item in listOfItems)
        //     {
        //         if(item is int)
        //         {
        //             results.Add((int)item);
        //         }
        //     }
        //
        //     return results;
        // }


        // public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        // {
        //     foreach (object x in listOfItems)
        //         if (x is int) yield return (int) x;
        // }


        // public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        //     => listOfItems.OfType<int>();


        // public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        // {
        //     return listOfItems.Where(x=> x is int).Select(x => (int)x);
        // }


        // public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        // {
        //     return listOfItems.Where(loi => loi is int).Select(i => (int)i);
        // }


        // public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        // {
        //     return listOfItems.OfType<int>().ToList();
        // }
    }
}