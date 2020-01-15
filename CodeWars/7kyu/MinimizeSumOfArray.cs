/*
https://www.codewars.com/kata/5a523566b3bfa84c2e00010b/train/csharp
https://www.codewars.com/kata/5a523566b3bfa84c2e00010b/solutions/csharp

7 kyu
Minimize Sum Of Array (Array Series #1)

Introduction and Warm-up (Highly recommended)
Playing With Lists/Arrays Series
Task
Given an array of integers , Find the minimum sum which is obtained from summing each Two integers product .

Notes
Array/list will contain positives only .
Array/list will always has even size
Input >> Output Examples
minSum({5,4,2,3}) ==> return (22) 
Explanation:
The minimum sum obtained from summing each two integers product , 5*2 + 3*4 = 22
minSum({12,6,10,26,3,24}) ==> return (342)
Explanation:
The minimum sum obtained from summing each two integers product , 26*3 + 24*6 + 12*10 = 342
minSum({9,2,8,7,5,4,0,6}) ==> return (74)
Explanation:
The minimum sum obtained from summing each two integers product , 9*0 + 8*2 +7*4 +6*5 = 74
Playing with Numbers Series
Playing With Lists/Arrays Series
For More Enjoyable Katas
ALL translations are welcomed
Enjoy Learning !!
Zizou
*/

using System.Linq;

namespace CodeWars
{
    public class MinimizeSumOfArray
    {
        public static int MinSum(int[] a)
        {
            // var result = 0;
            // a = a.OrderBy(x => x).ToArray();
            // for (var i = 0; i < a.Length / 2; i++)
            // {
            //     result += a[i] * a[a.Length - 1 - i];
            // }
            //return result;

            return a.OrderBy(n => n).Skip(a.Length / 2)
                .Zip(a.OrderByDescending(n => n).Skip(a.Length / 2), (x, y) => x * y).Sum();
        }

        // public static int MinSum(int[] a)
        // {
        //     var list = a.OrderBy(x => x).ToList();
        //     int result = 0;
        //     int i = 0, j = a.Length - 1;
        //     
        //     while (i < j)
        //     {
        //         result += list[i++] * list[j--];
        //     }
        //
        //     return result;
        // }


        // public static int MinSum(int[] a)
        // {
        //     a = a.OrderBy(x => x).ToArray();
        //     return Enumerable.Range(0, a.Length/2)
        //         .Select((x, i) => new [] {a[i], a[a.Length-i-1]})
        //         .Sum(x => x[0]*x[1]);
        // }


        // public static int MinSum(int[] a)
        // {
        //     var orderedArray = a.OrderBy(x=>x).ToArray();
        //     return orderedArray.Skip(orderedArray.Length/2).Reverse().Select((x,i) => x*orderedArray[i]).Sum();
        // }


        // public static int MinSum(int[] a)
        // {
        //     int summ = 0;
        //     var listArr = new List<int>(a);
        //     var countMultiplication = a.Length / 2;
        //     for (int i = 0; i < countMultiplication; i++)
        //     {
        //         summ += listArr.Max() * listArr.Min();
        //         listArr.Remove(listArr.Max());
        //         listArr.Remove(listArr.Min());
        //     }
        //     return summ;
        // }


        // public static int MinSum(int[] a)
        // {
        //     Array.Sort(a);
        //     return Enumerable.Range(0, a.Length/2).Sum(x => a[x] * a[a.Length - 1 - x]);
        // }
    }
}