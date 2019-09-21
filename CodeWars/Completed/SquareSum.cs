using System;
using System.Linq;

//https://www.codewars.com/kata/square-n-sum/train/csharp
//https://www.codewars.com/kata/515e271a311df0350d00000f/solutions/csharp

//Square(n) Sum
//Complete the square sum function so that it squares each number passed into it and then sums the results together.
//For example, for [1, 2, 2] it should return 9 because 1^2 + 2^2 + 2^2 = 9.


namespace CodeWars
{
    public class KataSquareSum
    {
        public static int SquareSum(int[] n)
        {
            return n.Sum(x => (int)Math.Pow(x, 2));
        }


        //        public static int SquareSum(int[] n) => n.Sum(i => i * i);
        //
        //
        //        public static int SquareSum(int[] n)
        //        { 
        //            return n.Sum(x => x*x);
        //        }
        //
        //        public static int SquareSum(int[] n)
        //        { 
        //            return  n.Sum(t => t * t);
        //        }
        //
        //        public static int SquareSum(int[] n)
        //        { 
        //            return n.Select(x => x * x).Sum(o => o);
        //        }
        //
        //
        //        public static int SquareSum(int[] n)
        //        { 
        //            int sum = 0;
        //            foreach (int a in n){
        //                int b = a*a;
        //                sum+= b;
        //            }
        //            return sum;
        //        }
        //
        //
        //        public static int SquareSum(int[] n)
        //        { 
        //            return n.Aggregate(0, (sum, element) => sum + element * element);
        //        }
        //
        //        public static int SquareSum(int[] numbers) => numbers.Select(n => (int)Math.Pow(n, 2)).Sum();




    }
}