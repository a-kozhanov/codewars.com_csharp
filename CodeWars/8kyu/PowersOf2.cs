using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

//https://www.codewars.com/kata/powers-of-2/train/csharp
//https://www.codewars.com/kata/57a083a57cb1f31db7000028/solutions/csharp

//8 kyu
//Powers of 2

//Complete the function that takes a non-negative integer n as input, and returns a list of all the powers of 2 with the exponent ranging from 0 to n (inclusive).

//Examples
//n = 0  ==> [1]        # [2^0]
//n = 1  ==> [1, 2]     # [2^0, 2^1]
//n = 2  ==> [1, 2, 4]  # [2^0, 2^1, 2^2]

namespace CodeWars
{
    public class PowersOf2
    {
        public static BigInteger[] PowersOfTwo(int n)
        {
            return Enumerable.Range(0, n + 1).Select(x => (BigInteger)Math.Pow(2, x)).ToArray();
        }


        //public static BigInteger[] PowersOfTwo(int n)
        //{
        //    return (from x in Enumerable.Range(0, n+1) select BigInteger.Pow(2, x)).ToArray();
        //}


        //public static BigInteger[] PowersOfTwo(int n)
        //{
        //    return Enumerable.Range(0, n+1).Select(x => BigInteger.Pow(2, x)).ToArray();
        //}

        //public static BigInteger[] PowersOfTwo(int n)
        //{
        //    return Enumerable.Range(0, n + 1).Select(i => BigInteger.One << i).ToArray();
        //}


        //public static BigInteger[] PowersOfTwo(int n)
        //{
        //    BigInteger[] result = new BigInteger[n+1];

        //    for(int i = 0; i < result.Length; i++)
        //    {
        //        result[i] = (BigInteger)Math.Pow(2,i);
        //    }

        //    return result;
        //}


        //public static BigInteger[] PowersOfTwo(int n)
        //{
        //    BigInteger[] countArray = new BigInteger[1 + n];
        //    for(int i = 0 ; i <= n ; i++)
        //    {
        //        countArray[i] = BigInteger.Pow(2, i);
        //    }
        //    return countArray;
        //}



    }
}