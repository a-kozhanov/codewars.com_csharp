/*
https://www.codewars.com/kata/5abd66a5ccfd1130b30000a9/train/csharp
https://www.codewars.com/kata/5abd66a5ccfd1130b30000a9/solutions/csharp

7 kyu
Row Weights

Scenario
Several people are standing in a row divided into two teams.
The first person goes into team 1, the second goes into team 2, the third goes into team 1, and so on.

Task
Given an array of positive integers (the weights of the people), return a new array/tuple of two integers, 
where the first one is the total weight of team 1, and the second one is the total weight of team 2.

Notes
Array size is at least 1.
All numbers will be positive.
Input >> Output Examples
rowWeights([13, 27, 49])  ==>  return (62, 27)
Explanation:
The first element 62 is the total weight of team 1, and the second element 27 is the total weight of team 2.

rowWeights([50, 60, 70, 80])  ==>  return (120, 140)
Explanation:
The first element 120 is the total weight of team 1, and the second element 140 is the total weight of team 2.

rowWeights([80])  ==>  return (80, 0)
Explanation:
The first element 80 is the total weight of team 1, and the second element 0 is the total weight of team 2.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class KataRowWeights
    {
        public static int[] RowWeights(int[] a)
        {
            return new[] {a.Where((x, i) => i % 2 == 0).Sum(), a.Where((x, i) => i % 2 == 1).Sum()};
        }

        // public static int[] RowWeights(int[] a)
        // {
        //     int[] result = new int[2];
        //
        //     for (int i = 0; i < a.Length; i++)
        //     {
        //         if (i % 2 == 0)
        //             result[0] += a[i];
        //         else
        //             result[1] += a[i];
        //     }
        //
        //     return result;
        // }


        // public static int[] RowWeights(int[] a)
        // {
        //     int[] t = {0, 0};
        //     for (int i = 0; i < a.Length; i++)
        //         if (i % 2 == 0)
        //             t[0] += a[i];
        //         else
        //             t[1] += a[i];
        //     return t;
        // }


        // public static int[] RowWeights(int[] a)
        // {
        //     var team1 = a.Where((x, i) => i % 2 == 0).Sum();
        //     var team2 = a.Where((x, i) => i % 2 == 1).Sum();
        //     return new int[] {team1, team2};
        // }
    }
}