/*
https://www.codewars.com/kata/58a5aeb893b79949eb0000f1/csharp

7 kyu
Shared Bit Counter

In this Kata you need to write the method SharedBits that returns true if 2 integers share at least two '1' bits. 
For simplicity assume that all numbers are positive

For example 
int seven = 7; //0111 
int ten = 10; //1010 
int fifteen = 15; //1111 
SharedBits(seven, ten); //false 
SharedBits(seven, fifteen); //true 
SharedBits(ten, fifteen); //true

seven and ten share only a single '1' (at index 3)
seven and fifteen share 3 bits (at indexes 1, 2, and 3)
ten and fifteen share 2 bits (at indexes 0 and 2)
Hint: you can do this with just string manipulation, but binary operators will make your life much easier.
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class SharedBitCounter
    {
        public static bool SharedBits(int a, int b)
        {
            //return Regex.Matches(Convert.ToString(a & b, 2), "1").Count > 1;
            //return Convert.ToString(a & b, 2).Count(x => x == '1') >= 2;
            //return Enumerable.Range(0, 32).Sum(i => (a & b) >> i & 1) > 1;
            //return (a & b & ((a & b) - 1)) != 0;
            //return (a & b & ((a & b) - 1)) != 0;
            return ((a &= b) & (a - 1)) > 0;
        }
    }
}