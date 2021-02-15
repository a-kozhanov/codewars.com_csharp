/*
https://www.codewars.com/kata/560e80734267381a270000a2/csharp

7 kyu
Binary operations #1

Your work is to write a method that takes a value and an index, and returns the value with the bit at given index flipped.

The bits are numbered from the least significant bit (index 1).

Example:

FlipBit(15,4) == 7  // 15 in binary is 1111, after flipping 4th bit, it becomes 0111, i.e. 7
FlipBit(15,5) == 31 // 15 in binary is 1111, 5th bit is 0, after flipping, it becomes 11111, i.e., 31
Note : index number can be out of number's range : e.g number is 3 (it has 2 bits) and index number is 8(for C# this number is up to 31) -> result will be 131

See more examples in test classes

Good luck!
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class BinaryOperations1
    {
        public static int FlipBit(int value, int bitIndex)
        {
            return (1 << bitIndex - 1) ^ value;

            // var arr = Convert.ToString(value, 2).PadLeft(bitIndex, '0').ToCharArray();
            // arr[^bitIndex] = arr[^bitIndex] == '0' ? '1' : '0';
            // return Convert.ToInt32(new string(arr), 2);

            
            // return Convert.ToInt32(
            //     string.Concat(
            //         Convert.ToString(value, 2)
            //             .PadLeft(32, '0')
            //             .Reverse()
            //             .Select((c, i) => i == bitIndex - 1 ? c == '0' ? '1' : '0' : c)
            //             .Reverse()
            //     ), 2);


            // string s = Convert.ToString(value, 2).PadLeft(bitIndex, '0');
            // string result = "";
            // for (int i = 0; i < s.Length; i++)
            // {
            //     if (i == s.Length - bitIndex)
            //         result += s[i] == '0' ? "1" : "0";
            //     else result += s[i];
            // }
            // return Convert.ToInt32(result, 2);
        }
    }
}