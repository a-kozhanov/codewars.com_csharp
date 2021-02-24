/*
https://www.codewars.com/kata/559011063089b0d5500001aa/csharp

7 kyu
Vasya in his free time

Vasya has a very limited amount of free time. 
During these precision minutes he likes to think about strings containing zeros and ones.

Vasya considers the following operation: he chooses any two adjacent positions in the string, and if one of them contains 0, 
and the other contains 1, then we are allowed to remove these two digits from the string.

Now Vasya thinks of what is the minimum length of the string that can remain after applying the described operation several times (possibly, zero)? 
Help him to calculate this number.

###Input First line of the input contains a single integer n, (1 ≤ n ≤ 500000), the length of the string Vasya has. 
The second line contains the string of length n consisting only from zeros and ones.

###Output Output the minimum length of the string that may remain after applying the described operations several times.

###Examples:
Task.ResultString(4, "1100") // answer is 0 =>  sequence of the possible steps: 1100 --> 10 --> empty string
Task.ResultString(5, "01010") // answer is 1 =>  sequence of the possible steps: 01010 --> 010 --> 0
Task.ResultString(8, "11101111") // answer is 6 =>  sequence of the possible steps: 11101111 --> 111111
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class VasyaInHisFreeTime
    {
        public static int ResultString(int b, string numbers)
        {
            return Math.Abs(numbers.Sum(c => c == '1' ? 1 : -1));
            //return Math.Abs(b - 2 * numbers.Count(x => x == '0'));
            //return Math.Abs(numbers.Count(i => i == '1') - numbers.Count(i => i == '0'));
            //return b - Math.Min(numbers.Split('0').Length - 1, numbers.Split('1').Length - 1) * 2;


            // string o = numbers.Replace("0", "");
            // string z = numbers.Replace("1", "");
            // return Math.Abs(o.Length - z.Length);

            // int zeroCount = numbers.Count(n => n == '0');
            // int oneCount = b - zeroCount;
            // return Math.Abs(oneCount - zeroCount);


            // while (Regex.Match(numbers, "01|10").Success)
            //     numbers = Regex.Replace(numbers, "01|10", "");
            // return numbers.Length;
        }
    }
}