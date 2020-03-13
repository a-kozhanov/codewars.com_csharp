/*
https://www.codewars.com/kata/5813d19765d81c592200001a/train/csharp
https://www.codewars.com/kata/5813d19765d81c592200001a/solutions/csharp

7 kyu
Don't give me five!

In this kata you get the start number and the end number of a region and should return the count of all numbers except numbers with a 5 in it. 
The start and the end number are both inclusive!

Examples:
1,9 -> 1,2,3,4,6,7,8,9 -> Result 8
4,17 -> 4,6,7,8,9,10,11,12,13,14,16,17 -> Result 12
The result may contain fives. ;-)
The start number will always be smaller than the end number. Both numbers can be also negative!

I'm very curious for your solutions and the way you solve it. Maybe someone of you will find an easy pure mathematics solution.

Have fun coding it and please don't forget to vote and rank this kata! :-)

I have also created other katas. Take a look if you enjoyed this kata!
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class KataDontGiveMeFive
    {
        public static int DontGiveMeFive(int start, int end)
        {
            return Enumerable.Range(start, end - start + 1).Count(n => !$"{n}".Contains("5"));
        }


        // public static int DontGiveMeFive(int start, int end)
        // {
        //     return Enumerable.Range(start, end - start + 1).Count(x => !x.ToString().Contains("5"));
        // }


        // public static int DontGiveMeFive(int start, int end)
        // {
        //     int count = 0;
        //     for (int i = start; i <= end; i++)
        //     {
        //         string temp = i.ToString();
        //         if (!temp.Contains("5")) count++;
        //     }
        //
        //     return count;
        // }


        // public static int DontGiveMeFive(int start, int end)
        // {
        //     return Enumerable.Range(start, end - start + 1)
        //         .Where(x => !x.ToString().Contains("5"))
        //         .Count();
        // }


        // public static int DontGiveMeFive(int start, int end)
        // {
        //     int count = 0;
        //     for (int i = end; i >= start; i--)
        //         if (!(i.ToString().Contains("5")))
        //             count++;
        //     return count;
        // }


        // public static int DontGiveMeFive(int start, int end)
        // {
        //     return Enumerable.Range(start, end - start + 1).Count(i => i.ToString().IndexOf('5') == -1);
        // }
    }
}