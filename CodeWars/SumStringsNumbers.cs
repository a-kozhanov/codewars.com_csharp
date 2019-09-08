using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

//https://www.codewars.com/kata/sum-strings-as-numbers/train/csharp
//https://www.codewars.com/kata/5324945e2ece5e1f32000370/solutions/csharp

//Sum Strings as Numbers

//Given the string representations of two integers, return the string representation of the sum of those integers.

//For example:
//sumStrings('1','2') // => '3'
//A string representation of an integer will contain no characters besides the ten numerals "0" to "9".


namespace CodeWars
{
    public class SumStringsNumbers
    {
        public static string sumStrings(string a, string b)
        {
            var builder = new StringBuilder();
            var maxLength = Math.Max(a.Length, b.Length);
            var remainder = 0;

            a = a.PadLeft(maxLength, '0');
            b = b.PadLeft(maxLength, '0');

            for (var index = maxLength - 1; index >= 0; index--)
            {
                var sum = a[index] - 48 + b[index] - 48 + remainder;
                builder.Insert(0, sum % 10);
                remainder = sum / 10;

                if (index == 0) builder.Insert(0, remainder);
            }

            return string.Join("", builder.ToString().TrimStart('0'));
        }


        //public static string sumStrings(string a, string b)
        //{
        //    BigInteger aInt;
        //    BigInteger bInt;

        //    BigInteger.TryParse(a, out aInt);
        //    BigInteger.TryParse(b, out bInt);

        //    return (aInt + bInt).ToString();
        //}


        //public static string sumStrings(string a, string b)
        //{
        //    return (Convert.ToInt32(a) + Convert.ToInt32(b)).ToString();
        //}


        //public static string sumStrings(string a, string b)
        //{
        //    var res = "";
        //    var c = 0;
        //    var aChars = new Stack<char>(a.ToCharArray());
        //    var bChars = new Stack<char>(b.ToCharArray());
        //    while (aChars.Count + bChars.Count + c > 0)
        //    {
        //        c += (aChars.Count > 0 ? (aChars.Pop() - '0') : 0) +
        //             (bChars.Count > 0 ? (bChars.Pop() - '0') : 0);
        //        res = c % 10 + res;
        //        c /= 10;
        //    }
        //    return new Regex("^0").Replace(res, "");
        //}


        //public static string sumStrings(params string[] numbers)
        //{
        //    return numbers
        //        .Select(s => String.IsNullOrEmpty(s)
        //            ? BigInteger.Zero
        //            : BigInteger.Parse(s)).Aggregate((a, b) => a + b)
        //        .ToString();
        //}



        //public static string sumStrings(string a, string b)
        //{
        //    BigInteger bigA;
        //    BigInteger bigB;
        //    BigInteger.TryParse(a, out bigA);
        //    BigInteger.TryParse(b, out bigB);

        //    return (bigA + bigB).ToString("R");
        //}


        //public static string sumStrings(string a, string b)
        //{
        //    return (int.Parse(a) + int.Parse(b)).ToString();
        //}


        //public static class Kata
        //{
        //    public static string sumStrings(string a, string b)
        //    {
        //        return (BigInteger.Add(ToBigInteger(a), ToBigInteger(b))).ToString();
        //    }

        //    public static BigInteger ToBigInteger(string str)
        //    {
        //        BigInteger BI;
        //        return (BigInteger.TryParse(str, out BI) == true) ? BI : 0;
        //    }
        //}


        //public static string sumStrings(string a, string b)
        //{
        //    if (!String.IsNullOrEmpty(a) && !String.IsNullOrEmpty(b))
        //    {
        //        BigInteger first = BigInteger.Parse(a);
        //        BigInteger second = BigInteger.Parse(b);
        //        string outConverted = (first + second).ToString();
        //        return outConverted;
        //    }
        //    else
        //    {
        //        return (a + b).ToString();
        //    }
        //}



        //public static string sumStrings(string a, string b)
        //{
        //    BigInteger val1, val2;

        //    BigInteger.TryParse(a, out val1);
        //    BigInteger.TryParse(b, out val2);

        //    return (val1 + val2).ToString();
        //}


        //public static class Kata
        //{
        //    public static string sumStrings(string a, string b)
        //    {
        //        return (getInteger(a) + getInteger(b)).ToString();
        //    }

        //    private static BigInteger getInteger(string input)
        //    {
        //        BigInteger result;
        //        if (input == null || string.IsNullOrWhiteSpace(input.Trim()))
        //            result = 0;
        //        else
        //        {
        //            if (!BigInteger.TryParse(input.Trim(), out result))
        //                result = 0;
        //        }

        //        return result;
        //    }
        //}

        //public static string sumStrings(string a, string b)
        //{
        //    BigInteger al = (a.Length == 0) ? 0 : BigInteger.Parse(a);
        //    BigInteger bl = (b.Length == 0) ? 0 : BigInteger.Parse(b);
        //    return (al + bl).ToString();
        //}

        //public static string sumStrings(string a, string b)
        //{
        //    return String.Join("", Int32.Parse(a) + Int32.Parse(b));
        //}


        //public static string sumStrings(string a, string b)
        //{
        //    return ((string.IsNullOrWhiteSpace(a) ? 0 : BigInteger.Parse(a)) + (string.IsNullOrWhiteSpace(b) ? 0 : BigInteger.Parse(b))).ToString();
        //}


        //public static string sumStrings(string a, string b)
        //{
        //    return (BigInteger.Parse(string.IsNullOrEmpty(a) ? "0" : a) +
        //            BigInteger.Parse(string.IsNullOrEmpty(b) ? "0" : b)).ToString();
        //}


        //public static string sumStrings(string a, string b)
        //{
        //    Int32 num1 = Int32.Parse(a);
        //    Int32 num2 = Int32.Parse(b);

        //    return (num1 + num2).ToString();
        //}




    }
}