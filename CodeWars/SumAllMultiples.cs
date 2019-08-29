using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//https://www.codewars.com/kata/sum-of-all-the-multiples-of-3-or-5/train/csharp
//https://www.codewars.com/kata/57f36495c0bb25ecf50000e7/solutions/csharp

//Sum of all the multiples of 3 or 5

//Your task is to write function findSum.
//Upto and including n, this function will return the sum of all multiples of 3 and 5.

//For example:
//findSum(5) should return 8 (3 + 5)
//findSum(10) should return 33 (3 + 5 + 6 + 9 + 10)

namespace CodeWars
{
    public class SumAllMultiples
    {
        public static int findSum(int n)
        {
            var num = new List<int>();

            for (var i = 0; i <= n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) num.Add(i);
            }

            return num.Sum();
        }


        //Best Practices
        //public static int findSum(int n)
        //{
        //    int sum = 0;
        //    for (int x = 0; x <= n; x++)
        //    {
        //        if (x % 5 == 0 || x % 3 == 0)
        //        {
        //            sum += x;
        //        }
        //    }
        //    return sum;
        //}


        //public static int findSum(int n)
        //{
        //    return Enumerable.Range(1, n).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        //}


        //public static int findSum(int n) => Enumerable.Range(1, n).Where(x => x % 5 == 0 || x % 3 == 0).Sum();

    }
}
