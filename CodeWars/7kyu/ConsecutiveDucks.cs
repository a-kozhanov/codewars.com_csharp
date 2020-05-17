/*
https://www.codewars.com/kata/5dae2599a8f7d90025d2f15f

7 kyu
Consecutive Ducks

Positive integers have so many gorgeous features. 
Some of them could be expressed as a sum of two or more consecutive positive numbers.

Consider an Example :
10 , could be expressed as a sum of 1 + 2 + 3 + 4.
Task
Given Positive integer, N , 
Return true if it could be expressed as a sum of two or more consecutive positive numbers , OtherWise return false .

Notes
Guaranteed constraint : 2 ≤ N ≤ (2^31) -1 .
Input >> Output Examples:

* consecutiveDucks(9)  ==>  return (true)  //  9 , could be expressed as a sum of ( 2 + 3 + 4 ) or ( 4 + 5 )
* consecutiveDucks(64)  ==>  return (false)
* consecutiveDucks(42)  ==>  return (true) //  42 , could be expressed as a sum of ( 9 + 10 + 11 + 12 )

Playing with Numbers Series
Playing With Lists/Arrays Series
Bizarre Sorting-katas
For More Enjoyable Katas
ALL translations are welcomed
Enjoy Learning !!
Zizou
*/

using System;

namespace CodeWars
{
    public class KataConsecutiveDucks
    {
        public static bool ConsecutiveDucks(int n)
        {
            // return Math.Log(n, 2) % 1 == 0 ? false : true;
            // return Math.Log2(n) % 1 != 0;
            // return (n & (n - 1)) != 0;
            return (n-- & n) != 0;
        }
    }
}