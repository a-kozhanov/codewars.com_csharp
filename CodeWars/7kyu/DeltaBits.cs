/*
https://www.codewars.com/kata/538948d4daea7dc4d200023f/csharp

7 kyu
Delta Bits

Complete the function to determine the number of bits required to convert integer A to integer B (where A and B >= 0)

The upper limit for A and B is 216, int.MaxValue or similar.

For example, you can change 31 to 14 by flipping the 4th and 0th bit:

 31  0 0 0 1 1 1 1 1
 14  0 0 0 0 1 1 1 0
---  ---------------
bit  7 6 5 4 3 2 1 0
Thus 31 and 14 should return 2.
*/

using System;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;

namespace CodeWars
{
    public class DeltaBits
    {
        public static int ConvertBits(int a, int b)
        {
            return new BitArray(new[] {a ^ b}).Cast<bool>().Count(x => x);
            //return new BitArray(new[] {a ^ b}).OfType<bool>().Count(x => x);
            //return Convert.ToString(a ^ b, 2).Replace("0", "").Length;
            //return Convert.ToString(a ^ b, 2).Split('1').Length - 1;
            //return Convert.ToString(a ^ b, 2).Count(c => c == '1');
        }
    }
}