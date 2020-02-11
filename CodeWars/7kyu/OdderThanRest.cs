/*
https://www.codewars.com/kata/5983cba828b2f1fd55000114/train/csharp
https://www.codewars.com/kata/5983cba828b2f1fd55000114/solutions/csharp

7 kyu
Odder Than the Rest

Create a method that takes an array/list as an input, 
and outputs the index at which the sole odd number is located.

This method should work with arrays with negative numbers. 
If there are no odd numbers in the array, then the method should output -1.

Examples:
Kata.OddOne(new List<int> {2,4,6,7,10}) => 3
Kata.OddOne(new List<int> {2,16,98,10,13,78}) => 4
Kata.OddOne(new List<int> {4,-8,98,-12,-7,90,100}) => 4
Kata.OddOne(new List<int> {2,4,6,8}) => -1
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class OdderThanRest
    {
        public static int OddOne(List<int> list)
        {
            return list.FindIndex(i => i % 2 != 0);
        }

        // public static int OddOne(List<int> list)
        // {
        //     bool oddNumber = false;
        //     int loop = 0;
        //     foreach(int num in list)
        //     {
        //         loop++;
        //         if(num % 2 == 0){ continue; } else { oddNumber = true; break; }
        //     }
        //     int indexFound = loop -1;
        //     if(oddNumber == false) { return -1; } else {return indexFound;}
        // }


        // public static int OddOne(List<int> list) => list.Any(x=>x%2!=0)? list.IndexOf(list.First(x => x % 2 !=0)) : -1;


        // public static int OddOne(List<int> list)
        // {
        //     return list.Any(x => x % 2 != 0) ? list.FindIndex(x => x % 2 != 0) : -1;
        // }


        // public static int OddOne(List<int> list)
        // {
        //     var temp = list.FirstOrDefault(i => Math.Abs(i % 2) == 1);
        //     return temp == 0 ? -1 : list.IndexOf(temp);
        // }


        // public static int OddOne(List<int> list)
        // {
        //     int val = -1;
        //     for (int i = 0; i < list.Count; i++)
        //     {
        //         if (list[i] % 2 != 0)
        //             val = i;
        //     }
        //     return val;
        // }


        // public static int OddOne(List<int> list) => list.Any(x=>(x+1)%2==0) ? list.IndexOf(list.First(x=>(x+1)%2==0)): -1;
    }
}