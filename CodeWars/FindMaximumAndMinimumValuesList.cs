
//https://www.codewars.com/kata/find-maximum-and-minimum-values-of-a-list/train/csharp
//https://www.codewars.com/kata/577a98a6ae28071780000989/solutions/csharp

//Find Maximum and Minimum Values of a List
//8 kyu


//Your task is to make two functions, max and min (maximum and minimum in PHP and Python) that take a(n) array/vector of integers list as input and outputs,
//respectively, the largest and lowest number in that array/vector.

//#Examples
//max({4,6,2,1,9,63,-134,566}) returns 566
//min({-52, 56, 30, 29, -54, 0, -110}) returns -110
//max({5}) returns 5
//min({42, 54, 65, 87, 0}) returns 0

//#Notes
//You may consider that there will not be any empty arrays/vectors.

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class FindMaximumAndMinimumValuesList
    {
        public int Min(int[] list)
        {
            return list.Min();
        }

        public int Max(int[] list)
        {
            return list.Max();
        }


        //public int Min(int[] list) => list.Min();
        //public int Max(int[] list) => list.Max();

        //public int Min(IEnumerable<int> list) => list?.Min() ?? 0; 
        //public int Max(IEnumerable<int> list) => list?.Max() ?? 0;



    }
}