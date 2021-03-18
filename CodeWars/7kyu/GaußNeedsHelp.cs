/*
https://www.codewars.com/kata/54df2067ecaa226eca000229/csharp

7 kyu
Gauß needs help! (Sums of a lot of numbers).

Due to another of his misbehaved, the primary school's teacher of the young Gauß, Herr J.G. Büttner, 
to keep the bored and unruly young schoolboy Karl Friedrich Gauss busy for a good long time, 
while he teaching arithmetic to his mates, 
assigned him the problem of adding up all the whole numbers from 1 through a given number n.

Your task is to help the young Carl Friedrich to solve this problem as quickly as you can; so, 
he can astonish his teacher and rescue his recreation interval.

Here's, an example:

f(n=100) // returns 5050 
It's your duty to verify that n is a valid positive integer number. If not, please, return false (None for Python, null for C#).

Note: the goal of this kata is to invite you to think about some 'basic' mathematic formula and how you can do performance optimization on your code. 

Advanced - experienced users should try to solve it in one line, without loops, or optimizing the code as much as they can.

Credits: this kata was inspired by the farzher's kata 'Sum of large ints' . In fact, it can be seen as a sort of prep kata for that one.
*/

namespace CodeWars
{
    public class GaußNeedsHelp
    {
        //public static long? RangeSum(long n)
        public static long? RangeSum(long? n)
        {
            //return n > 0 ? n * (n + 1) / 2 : default(long?);
            //return n > 0 ? (n + n * n) / 2 : default(long?);
            //return n > 0 ? (long?) (n * (n + 1) / 2) : null;
            //return n < 1 ? (long?) null : n * (n + 1) / 2;
            //return n < 1 ? (long?) null : (n * n + n) / 2;
            //return n < 1 ? (long?) null : (1 + n) * n / 2;
            //return n > 0 ? n * (1 + n) / 2 : (long?) null;
            //return n <= 0 ? new long?() : n * (n + 1) / 2;
            //return n > 0 ? n * (n + 1) / 2 : new long?();
            //return n <= 0 ? null : (n + n * n) / 2;
            //return n < 1 ? null : (1 + n) * n / 2;
            //return n > 0 ? n * (n + 1) / 2 : null;
            return n > 0 ? n++ * n / 2 : null;
        }
    }
}