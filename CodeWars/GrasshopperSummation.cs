
//https://www.codewars.com/kata/grasshopper-summation/train/csharp
//https://www.codewars.com/kata/55d24f55d7dd296eb9000030/solutions/csharp

//Grasshopper - Summation

//Summation
//Write a program that finds the summation of every number from 1 to num.The number will always be a positive integer greater than 0.

//For example:
//summation(2) -> 3 1 + 2
//summation(8) -> 36 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8
//(summation 2) ; 3  (+ 1 2)
//(summation 8) ; 36 (+ 1 2 3 4 5 6 7 8)

using System.Linq;

namespace CodeWars
{
    public class GrasshopperSummation
    {
        public static int summation(int num)
        {
            //var sum = 0;
            //for (var i = 1; i <= num; i++)
            //{
            //    sum += i;
            //}
            //return sum;

            return Enumerable.Range(1, num).Sum();
        }

        //Best Practices
        //public static int summation(int num)
        //{
        //    return num * (num + 1) / 2;
        //}


        //public static int summation(int num)
        //{
        //    return (1 + num) * num / 2;
        //}

    }
}