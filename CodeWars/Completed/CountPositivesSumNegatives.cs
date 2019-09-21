
//https://www.codewars.com/kata/count-of-positives-slash-sum-of-negatives/train/csharp
//https://www.codewars.com/kata/576bb71bbbcf0951d5000044/solutions/csharp

//Count of positives / sum of negatives

//Given an array of integers.
//Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers.
//If the input array is empty or null, return an empty array.
//Example
//For input [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15], you should return [10, -65].

using System;
using System.Linq;

namespace CodeWars
{
    public class KataCountPositivesSumNegatives
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null || input.Length == 0) return new int[] { };
            return new[] { input.Count(x => x > 0), input.Where(i => i < 0).Sum() };
        }

        //public static int[] CountPositivesSumNegatives(int[] input)
        //{
        //    if(input == null || !input.Any())
        //    {
        //        return new int[] {};
        //    }

        //    int countPositives = input.Count(n => n > 0);
        //    int sumNegatives = input.Where(n => n < 0).Sum();

        //    return new int[] { countPositives, sumNegatives };
        //}

        //public static int[] CountPositivesSumNegatives(int[] input)    
        //{   
        //    return (input == null || input.Length ==0) ? new int[0] : new int[] { input.Count(o => o > 0), input.Where(o => o < 0).Sum() };
        //}

        //public static int[] CountPositivesSumNegatives(int[] input)
        //{
        //    return (input == null || !input.Any()) ? new int[]{} :
        //        new int[] {input.Where(x => x > 0).Count(), input.Where(x => x < 0).Sum()};
        //}

        //public static int[] CountPositivesSumNegatives(int[] input)
        //{
        //    return input == null || !input.Any() 
        //        ? new int[] {} 
        //        : new int[] { input.Count(x => x > 0) , input.Where(x => x < 0).Sum() };
        //}

        //public static int[] CountPositivesSumNegatives(int[] input)
        //{
        //    return input == null || input.Length == 0 ? new int[0] : new int[] {input.Where(x => x > 0).Count(), input.Where(x => x < 0).Sum() }; 
        //}
    }
}