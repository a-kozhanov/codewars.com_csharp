/*
https://www.codewars.com/kata/51fd6bc82bc150b28e0000ce/train/csharp
https://www.codewars.com/kata/51fd6bc82bc150b28e0000ce/solutions/csharp

7 kyu
No oddities here

Write a small function that returns the values of an array that are not odd.
All values in the array will be integers. Return the good values in the order they are given.

NoOdds(int[] values)
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class NoOdditiesHere
    {
        public static int[] NoOdds(int[] values)
        {
            return values.Where(n => n % 2 == 0).ToArray();
            //return values.Where(n => (n & 1) == 0).ToArray();
        }


        // public static int[] NoOdds(int[] values) 
        // {
        //     // Code??
        //     List<int> list = new List<int>();
        //
        //     foreach(var i in values){
        //         if(i % 2 == 0) 
        //         {
        //             list.Add(i);
        //         }
        //     }
        //     return list.ToArray();
        // }


        // public static int[] NoOdds(int[] values) 
        // {
        //     List<int> output = new List<int>();
        //     foreach(int value in values){ if(value % 2 == 0) { output.Add(value); } }
        //     return output.ToArray();
        // }
    }
}