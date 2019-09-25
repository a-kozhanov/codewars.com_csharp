
//https://www.codewars.com/kata/count-by-x/train/csharp
//https://www.codewars.com/kata/5513795bd3fafb56c200049e/solutions/csharp

//Count by X

//Create a function with two arguments that will return an array of length (n) with multiples of (x).
//Assume both the given number and the number of times to count will be positive numbers greater than 0.
//Return the results as an array (or list in Python, Haskell or Elixir).
//Examples:
//countBy(1,10)  should return  {1,2,3,4,5,6,7,8,9,10}
//countBy(2,5)  should return {2,4,6,8,10}

using System;
using System.Linq;
using System.Collections.Generic;



namespace CodeWars
{
    public class CountByX
    {
        public static int[] CountBy(int x, int n)
        {
            var result = new List<int>();
            var cycle = 0;
            var step = x;

            while (cycle <= n - 1)
            {
                result.Add(x);
                x += step;
                cycle++;
            }

            return result.ToArray();
        }


        //public static int[] CountBy(int x, int n)
        //{
        //    return Enumerable.Range(1, n).Select(i => i * x).ToArray();
        //}

        //public static int[] CountBy(int x, int n)
        //{
        //    var myList = new List<int>();

        //    for (var i = 1; i <= n; i++)
        //    {
        //        myList.Add(x*i);
        //    }

        //    var array = myList.ToArray();

        //    return array;
        //}


    }
}