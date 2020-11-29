/*
https://www.codewars.com/kata/58249d08b81f70a2fc0001a4/csharp

7 kyu
Return the closest number multiple of 10

Given a number return the closest number to it that is divisible by 10.

Example input:
22
25
37

Expected output:
20
30
40
*/

using System;

namespace CodeWars
{
    public class ReturnClosestNumberMultipleOf10
    {
        public int ClosestMultiple10(int num)
        {
            return (int) (Math.Round(num / 10d, MidpointRounding.AwayFromZero) * 10);
        }
    }
}