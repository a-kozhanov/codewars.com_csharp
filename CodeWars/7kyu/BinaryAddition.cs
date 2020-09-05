/*
https://www.codewars.com/kata/551f37452ff852b7bd000139/csharp

7 kyu
Binary Addition

Implement a function that adds two numbers together and returns their sum in binary. 
The conversion can be done before, or after the addition.

The binary number returned should be a string.
*/

using System;

namespace CodeWars
{
    public class BinaryAddition
    {
        public static string AddBinary(int a, int b)
        {
            return Convert.ToString(a + b, 2);
        }
    }
}