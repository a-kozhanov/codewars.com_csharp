/*
https://www.codewars.com/kata/57d2807295497e652b000139/train/csharp

7 kyu
Averages of numbers

#Get the averages of these numbers

Write a method, 
that gets an array of integer-numbers and return an array of the averages of each integer-number and his follower, 
if there is one.

Example:

Input:  [ 1, 3, 5, 1, -10]
Output:  [ 2, 4, 3, -4.5]
If the array has 0 or 1 values or is null or None, your method should return an empty array.

Have fun coding it and please don't forget to vote and rank this kata! :-)
*/

using System.Linq;

namespace CodeWars
{
    public class AveragesOfNumbers
    {
        public static double[] Averages(int[] numbers)
        {
            //return numbers?.Skip(1).Select((x, i) => (x + numbers[i]) / 2.0).ToArray() ?? new double[0];
            return numbers?.Zip(numbers.Skip(1), (x, y) => (x + y) / 2.0).ToArray() ?? new double[0];
        }

        // public static double[] Averages(int[] numbers)
        // {
        //     if (numbers == null || numbers.Length < 2)
        //         return new double[0];
        //     double[] averages = new double[numbers.Length - 1];
        //     for (int i = 1; i < numbers.Length; i++)
        //         averages[i - 1] = (double) (numbers[i - 1] + numbers[i]) / 2;
        //     return averages;
        // }


        // public static double[] Averages(int[] numbers)
        // {
        //     return numbers == null || numbers.Length <= 1
        //         ? new double[] { }
        //         : Enumerable.Range(0, numbers.Length - 1)
        //             .Select(i => numbers.Skip(i).Take(2).Average())
        //             .ToArray();
        // }


        // public static double[] Averages(int[] numbers)
        // {
        //     return (numbers == null || numbers.Length < 2)
        //         ? new double[0]
        //         : Enumerable.Range(0, numbers.Length - 1).Select(n => (double) (numbers[n] + numbers[n + 1]) / 2)
        //             .ToArray();
        // }


        // public static double[] Averages(int[] numbers)
        // {
        //     if (numbers == null || numbers.Length < 2)
        //     {
        //         return new double[] { };
        //         ;
        //     }
        //
        //     var result = new double[numbers.Length - 1];
        //     for (var i = 0; i < numbers.Length - 1; i++)
        //     {
        //         result[i] = (numbers[i] + numbers[i + 1]) / 2.0;
        //     }
        //
        //     return result;
        // }


        // public static double[] Averages(int[] numbers)
        // {
        //     if (numbers == null || numbers.Length < 2) return new double[0];
        //
        //     double[] result = new double[numbers.Length - 1];
        //     for (int i = 0; i < numbers.Length - 1; i++)
        //         result[i] = (numbers[i] + numbers[i + 1]) / 2f;
        //
        //     return result;
        // }
    }
}