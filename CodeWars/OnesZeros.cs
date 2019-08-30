using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://www.codewars.com/kata/ones-and-zeros/train/csharp
//https://www.codewars.com/kata/578553c3a1b8d5c40300037c/solutions/csharp

//Ones and Zeros

//Given an array of ones and zeroes, convert the equivalent binary value to an integer.
//Eg: [0, 0, 0, 1] is treated as 0001 which is the binary representation of 1.

//Examples:
//Testing: [0, 0, 0, 1] ==> 1
//Testing: [0, 0, 1, 0] ==> 2
//Testing: [0, 1, 0, 1] ==> 5
//Testing: [1, 0, 0, 1] ==> 9
//Testing: [0, 0, 1, 0] ==> 2
//Testing: [0, 1, 1, 0] ==> 6
//Testing: [1, 1, 1, 1] ==> 15
//Testing: [1, 0, 1, 1] ==> 11
//However, the arrays can have varying lengths, not just limited to 4.

namespace CodeWars
{
    public class OnesZeros
    {
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            //BitArray myBitArr = new BitArray(4);
            //myBitArr[0] = Convert.ToBoolean(BinaryArray[3]);
            //myBitArr[1] = Convert.ToBoolean(BinaryArray[2]);
            //myBitArr[2] = Convert.ToBoolean(BinaryArray[1]);
            //myBitArr[3] = Convert.ToBoolean(BinaryArray[0]);
            //var result = new int[1];
            //myBitArr.CopyTo(result, 0);
            //return result[0];

            return Convert.ToInt32(string.Concat(BinaryArray), 2);
        }

        //Best Practices
        //public static int binaryArrayToNumber(int[] BinaryArray)
        //{
        //    return Convert.ToInt32(string.Join("", BinaryArray), 2);
        //}


        //public static int binaryArrayToNumber(int[] BinaryArray)
        //{
        //    int sum = 0;

        //    for (int i = BinaryArray.Length - 1, p = 0; i > -1; i--, p++)
        //    {
        //        if (BinaryArray[i] > 0) sum += (int)Math.Pow(2, p);
        //    }

        //    return sum;
        //}


        //public static int binaryArrayToNumber(int[] bitArray)
        //{
        //    return bitArray.Aggregate(0, (x, y) => x << 1 | y);
        //}


        //public static int binaryArrayToNumber(int[] bin)
        //{
        //    return bin[3] + bin[2] * 2 + bin[1] * 4 + bin[0] * 8;
        //}


        //public static int binaryArrayToNumber(int[] bitArray)
        //{
        //    int result = 0;

        //    foreach (var bit in bitArray)
        //    {
        //        result <<= 1;
        //        result |= bit;
        //    }

        //    return result;
        //}


        //public static int binaryArrayToNumber(int[] BinaryArray)
        //{
        //    string num = string.Empty;
        //    foreach (var item in BinaryArray)
        //    {
        //        num += item.ToString();
        //    }
        //    return Convert.ToInt32(num, 2);
        //}

    }
}
