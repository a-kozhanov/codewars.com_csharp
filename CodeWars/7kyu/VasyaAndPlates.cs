/*
https://www.codewars.com/kata/55807d36933247feff00002f/csharp

7 kyu
Vasya and Plates

Vasya is a lazy student. He has certain amount of clean bowls and plates (lets call it b and p).

Vasya has made an eating plan for the next several days.

Vasya's eating Plan
As Vasya is lazy, he will eat exactly 1 dish per day. In order to eat a dish, he needs exactly 1 clean plate OR bowl. We know that Vasya can cook only 2 types of dishes. He can eat:

Dishes of the first type from bowls
Dishes of the second type from either bowls or plates
When Vasya finishes eating, he leaves a dirty plate/bowl behind. His life philosophy doesn't let him eat from dirty kitchenware. So sometimes he needs to wash his plate/bowl before eating.

Input
The input contains two integers and integer array: b, p, dishes :

b- the number of clean bowls (1 ≤ b ≤ 1000)

p - the number of clean plates (1 ≤ p ≤ 1000)

dishes - If dishes[i] == 1 , then on that day, Vasya will eat the first type of dish. If dishes[i] == 2, then on that day Vasya will eat the second type of dish. (1 ≤ dishes[i] ≤ 2)

Your task
Find the minimum number of times Vasya will need to wash a plate/bowl, if he acts optimally.

Examples:
EatingPlan.CountClean(1,1, new int[] {1,2,1}) 
           // Vasya will wash a bowl only on the third day, so the answer is 1

EatingPlan.CountClean(3,1,new int[] {1,1,1,1})  
 Vasya will have the first type of the dish during all four days, 
and since there are only three bowls, he will wash a bowl exactly once.

EatingPlan.CountClean(1,2,new int[] {2, 2, 2}) 
Vasya will have the second type of dish for all three
days,and as they can be eaten from either a plate or a bowl, he will never 
need to wash a plate/bowl.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class VasyaAndPlates
    {
        public static int CountClean(int b, int p, int[] dishes)
        {
            return Math.Max(dishes.Count(i => i == 1) - b + Math.Max(dishes.Count(i => i == 2) - p, 0), 0);

            // var sum = 0;
            // foreach (var d in dishes)
            //     if (d == 1 && b == 0 || d == 2 && b + p == 0) sum++;
            //     else if (d == 1 || b > p) b--;
            //     else p--;
            // return sum;

            // var days = 0;
            // foreach (var d in dishes)
            // {
            //     if (d == 1)
            //     {
            //         if (b != 0)
            //             b--;
            //         else
            //             days++;
            //     }
            //     else
            //     {
            //         if (b == 0 && p == 0)
            //             days++;
            //         else
            //         {
            //             if (b != 0)
            //                 b--;
            //             else
            //                 p--;
            //         }
            //     }
            // }
            //
            // return days;
        }
    }
}