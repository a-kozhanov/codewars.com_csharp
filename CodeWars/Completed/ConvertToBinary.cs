using System;
using System.Collections.Generic;
using System.Text;

//https://www.codewars.com/kata/convert-to-binary/train/csharp
//https://www.codewars.com/kata/59fca81a5712f9fa4700159a/solutions/csharp

//Convert to Binary

//Task Overview
//Given a non-negative integer n, write a function toBinary/ToBinary which returns that number in a binary format.

//Documentation:
//Kata.ToBinary Method(Int32)
//Returns the binary representation of a non-negative integer as an integer.

//Syntax
//public static int ToBinary(
//int n
//)

//Parameters
//n
//Type: System.Int32
//The integer to convert.

//Return Value
//Type: System.Int32
//The binary representation of the argument as an integer.
//to_binary(1)  /* should return 1 */
//to_binary(5)  /* should return 101 */
//to_binary(11) /* should return 1011 */

namespace CodeWars
{
    public class ConvertToBinary
    {
        public static int ToBinary(int n)
        {
            return int.Parse(Convert.ToString(n, 2));
        }

        //Best Practices
        //public static int ToBinary(int n)
        //{
        //    return Convert.ToInt32(Convert.ToString(n, 2));
        //}

        //public static int ToBinary(int n)
        //{
        //    return int.Parse(Convert.ToString(n, 2));
        //}

        //public static int ToBinary(int n)
        //{
        //    int q = n, tmp = 0, m = 1;
        //    while (q != 0)
        //    {
        //        tmp += q % 2 * m;
        //        q = q / 2;
        //        m *= 10;
        //    }
        //    return tmp;
        //}

        //public static int ToBinary(int n)
        //{
        //    int result = 0;
        //    for (int i = 0; n > 0; i++, n /= 2)
        //    {
        //        int pow = 1;
        //        int exp = i;
        //        while (exp-- != 0) { pow *= 10; }
        //        result = n % 2 * pow + result;
        //    }
        //    return result;
        //}

        //public static int ToBinary(int num)
        //{
        //    string stringBinary = Convert.ToString(num, 2);
        //    return Convert.ToInt32(stringBinary);
        //}
    }
}
