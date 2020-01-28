/*
https://www.codewars.com/kata/5a651865fd56cb55760000e0/train/csharp
https://www.codewars.com/kata/5a651865fd56cb55760000e0/solutions/csharp

7 kyu
Array Leaders (Array Series #3)

Introduction and Warm-up (Highly recommended)
Playing With Lists/Arrays Series
Definition
An element is leader if it is greater than The Sum all the elements to its right side.

Task
Given an array/list [] of integers , Find all the LEADERS in the array.

Notes
Array/list size is at least 3 .

Array/list's numbers Will be mixture of positives , negatives and zeros

Repetition of numbers in the array/list could occur.

Returned Array/list should store the leading numbers in the same order in the original array/list .

Input >> Output Examples
arrayLeaders ({1, 2, 3, 4, 0}) ==> return {4}
Explanation:
4 is greater than the sum all the elements to its right side

Note : The last element 0 is equal to right sum of its elements (abstract zero).

arrayLeaders ({16, 17, 4, 3, 5, 2}) ==> return {17, 5, 2}
Explanation:
17 is greater than the sum all the elements to its right side

5 is greater than the sum all the elements to its right side

Note : The last element 2 is greater than the sum of its right elements (abstract zero).

arrayLeaders ({5, 2, -1}) ==> return {5, 2}
Explanation:
5 is greater than the sum all the elements to its right side

2 is greater than the sum all the elements to its right side

Note : The last element -1 is less than the sum of its right elements (abstract zero).

arrayLeaders ({0, -1, -29, 3, 2}) ==> return {0, -1, 3, 2}
Explanation:
0 is greater than the sum all the elements to its right side

-1 is greater than the sum all the elements to its right side

3 is greater than the sum all the elements to its right side

Note : The last element 2 is greater than the sum of its right elements (abstract zero).

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
    public class ArrayLeadersArraySeries3
    {
        public static int[] ArrayLeaders(int[] numbers)
        {
            //return numbers.Where((x, i) => x > numbers.TakeLast(numbers.Length - (i + 1)).Sum()).ToArray();
            return numbers.Where((x, i) => x > numbers.Skip(i + 1).Sum()).ToArray();
        }

        // public static int[] ArrayLeaders(int[] numbers)
        // {
        //     int sum = 0;
        //     List<int> leaders = new List<int>();
        //     for (int i = numbers.Length - 1; i >= 0; i--)
        //     {      
        //         if (numbers[i] > sum)
        //             leaders.Add(numbers[i]);
        //         sum += numbers[i];
        //     }
        //     return leaders.AsEnumerable().Reverse().ToArray();
        // }

        // public static int[] ArrayLeaders(int[] numbers)
        // {
        //     var sum = numbers.Sum();
        //     List<int> result = new List<int>(); ;
        //     foreach (var num in numbers)
        //         if (num > (sum -= num))
        //             result.Add(num);
        //
        //     return result.ToArray();
        // }


        // public static int[] ArrayLeaders(int[] numbers)
        // {
        //     var res = new List<int>();
        //     for(int i = 0; i < numbers.Length; i++)
        //     {
        //         var sum = 0;
        //         for(int u = i + 1; u < numbers.Length; u++)
        //         {
        //             sum += numbers[u];
        //         }
        //         if(numbers[i] > sum)
        //         {
        //             res.Add(numbers[i]);
        //         }
        //     }
        //     return res.ToArray();
        // }


        // public static int[] ArrayLeaders(int[] numbers)
        // {
        //     List<int> output = new List<int>();
        //     List<int> rh = new List<int>();
        //     for (int i = 0; i < numbers.Length - 1; i++)
        //     {
        //         rh.AddRange(numbers.Skip(i+1).Take(numbers.Length - i));
        //         if(numbers[i] > rh.Sum()) { output.Add(numbers[i]); }
        //         rh.Clear();
        //     }
        //     if (numbers[numbers.Length - 1] > 0) { output.Add(numbers[numbers.Length - 1]); }
        //     return output.ToArray();
        // }


        // public static int[] ArrayLeaders(IEnumerable<int> numbers)
        // {
        //     int sum = numbers.Sum();
        //     int leftSideSum = 0;
        //     return numbers
        //         .Where(value => 
        //         {
        //             leftSideSum += value;
        //             return value > sum - leftSideSum;
        //         })
        //         .ToArray();
        // }
    }
}