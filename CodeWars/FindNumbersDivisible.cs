using System.Collections.Generic;
using System.Linq;


//https://www.codewars.com/kata/55edaba99da3a9c84000003b
//https://www.codewars.com/kata/55edaba99da3a9c84000003b/solutions/csharp

//Find numbers which are divisible by given number

//Complete the function which takes two arguments and returns all numbers which are divisible by the given divisor.First argument is an array of numbers and the second is the divisor.

//Example
//DivisibleBy(new int[]{ 1, 2, 3, 4, 5, 6}, 2) == new int[] {2, 4, 6}

namespace CodeWars
{
    public class FindNumbersDivisible
    {
        public static int[] DivisibleBy(int[] numbers, int divisor)
        {
            return numbers.Where(x => x % divisor == 0).ToArray();
        }

        //public static int[] DivisibleBy(int[] numbers, int divisor)
        //{
        //    List<int> result = new List<int>();
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] % divisor == 0)
        //        {
        //            result.Add(numbers[i]);
        //        }
        //    }
        //    return result.ToArray();
        //}


        //public static int[] DivisibleBy(int[] numbers, int divisor)
        //{
        //    List<int> divisibles = new List<int>();

        //    for (int i = 0; i < numbers.Length; i++)
        //        if (numbers[i] % divisor == 0) divisibles.Add(numbers[i]);

        //    return divisibles.ToArray();
        //}

    }
}