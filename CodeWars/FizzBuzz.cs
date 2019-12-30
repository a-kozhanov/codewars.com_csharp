/*
https://www.codewars.com/kata/fizz-slash-buzz/train/csharp
https://www.codewars.com/kata/51dda84f91f5b5608b0004cc/solutions/csharp

7 kyu
Fizz / Buzz

Write a function that takes an integer and returns an array [A, B, C], 
where A is the number of multiples of 3 (but not 5) below the given integer, 
B is the number of multiples of 5 (but not 3) below the given integer and 
C is the number of multiples of 3 and 5 below the given integer.

For example, solution(20) should return [5, 2, 1]
*/

using System.Linq;

namespace CodeWars
{
    public class FizzBuzz
    {
        public static int[] Solution(int num)
        {
            var a = (num - 1) / 3;
            var b = (num - 1) / 5;
            var c = (num - 1) / 15;

            return new[] {a - c, b - c, c};
        }

        // public static int[] Solution(int number)
        // {
        //     int c = (int)Math.Floor((double)(number - 1) / 15);
        //     int a = (int)Math.Floor((double)(number - 1) / 3) - c;
        //     int b = (int)Math.Floor((double)(number - 1) / 5) - c;
        //
        //     return new int[] {a, b, c};
        // }


        // public static int[] Solution(int number) => new int[] {--number / 3 - number / 15, number / 5 - number / 15, number / 15};

        // public static int[] Solution(int number) {
        //     int count3 = --number / 3;
        //     int count5 = number / 5;
        //     int count15 = number / 15;
        //     return new int[3] { count3 - count15, count5 - count15, count15 };
        // }

        // public static int[] Solution(int number)
        // {
        //     int sBy1 = number-1;
        //     int dBy15 = sBy1/15;
        //
        //     return new int[]{ sBy1/3 - dBy15, sBy1/5 - dBy15 ,dBy15 }; 
        // }
    }
}