/*
https://www.codewars.com/kata/breaking-chocolate-problem/train/csharp
https://www.codewars.com/kata/534ea96ebb17181947000ada/solutions/csharp

7 kyu
Breaking chocolate problem

Your task is to split the chocolate bar of given dimension n x m into small squares. 
Each square is of size 1x1 and unbreakable. 
Implement a function that will return minimum number of breaks needed.

For example if you are given a chocolate bar of size 2 x 1 you can split it to single squares in just one break, 
but for size 3 x 1 you must do two breaks.

If input data is invalid you should return 0 (as in no breaks are needed if we do not have any chocolate to split). 
Input will always be a non-negative integer.
*/

using System;

namespace CodeWars
{
    public class BreakingChocolateProblem
    {
        public static int BreakChocolate(int n, int m)
        {
            //return Math.Max(n * m - 1, 0);
            return n * m < 1 ? 0 : n * m - 1;
        }

        // public static int BreakChocolate(int n, int m) 
        // {
        //     return n * m > 0 ? n * m - 1 : 0;
        // }

        // public static int BreakChocolate(int n, int m) 
        // {
        //     return n >= 1 && m >= 1 ? n * m - 1 : 0;
        // }

        // public static int BreakChocolate(int n, int m) 
        // {
        //     //a miracle occurs...
        //     if (n<=0 | m <=0) return 0;
        //     else return (n-1)+(m-1)*n;
        // }
    }
}