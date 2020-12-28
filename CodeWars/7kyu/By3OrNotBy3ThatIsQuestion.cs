/*
https://www.codewars.com/kata/59f7fc109f0e86d705000043/train/csharp

7 kyu
By 3, or not by 3? That is the question . . .

A trick I learned in elementary school to determine whether or not a number was divisible by three is to add all of the integers in the number together and to divide the resulting sum by three. 
If there is no remainder from dividing the sum by three, then the original number is divisible by three as well.
Given a series of digits as a string, determine if the number represented by the string is divisible by three.
You can expect all test case arguments to be strings representing values greater than 0.

Example:
"123"      -> true
"8409"     -> true
"100853"   -> false
"33333333" -> true
"7"        -> false
Try to avoid using the % (modulo) operator.
*/


using System;
using System.Linq;
using System.Numerics;

namespace CodeWars
{
    public class By3OrNotBy3ThatIsQuestion
    {
        public static bool DivisibleByThree(string n)
        {
            // return n.Select(x => int.Parse(x.ToString())).Sum() % 3 == 0;
            // return n.Sum(d => int.Parse(d.ToString())) % 3 == 0;
            // return n.Aggregate(0, (x, y) => (x + y) % 3) == 0;
            // return n.Select(Convert.ToInt32).Sum() % 3 == 0;
            // return BigInteger.Parse(n) % 3 == 0;
            // return n.Sum(c => c - '0') % 3 == 0;
            // return n.Sum(e => e - 48) % 3 == 0;
            // return n.Sum(x => x - 48) % 3 == 0;
            return n.Sum(x => x) % 3 == 0;
        }
    }
}