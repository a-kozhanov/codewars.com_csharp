using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

//https://www.codewars.com/kata/adding-big-numbers/train/csharp
//https://www.codewars.com/kata/525f4206b73515bffb000b21/solutions/csharp

//Adding Big Numbers



namespace CodeWars
{
    public class AddingBigNumbers
    {
        public static string Add(string a, string b)
        {
            BigInteger.TryParse(a, out var bigIntA);
            BigInteger.TryParse(b, out var bigIntB);

            return (bigIntA + bigIntB).ToString();
        }

        //public static string Add(string a, string b)
        //{
        //    return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString(); // Fix this!
        //}

        //public static string Add(string a, string b)
        //{
        //    return BigInteger.Add(BigInteger.Parse(a), BigInteger.Parse(b)).ToString();
        //}


        //public static string Add(string a, string b)
        //{
        //    var reverseResult = new StringBuilder();
        //    int aLength = a.Length, bLength = b.Length, length = aLength > bLength ? aLength : bLength, carry = 0;
        //    a = a.PadLeft(length, '0');
        //    b = b.PadLeft(length, '0');

        //    for (var index = length - 1; index >= 0; index--)
        //    {
        //        var sum = carry + a[index] - 48 + b[index] - 48;
        //        reverseResult.Append(sum % 10);
        //        carry = sum / 10;
        //    }

        //    if (carry > 0)
        //    {
        //        reverseResult.Append(1);
        //    }

        //    var result = reverseResult.ToString().ToCharArray();

        //    Array.Reverse(result);

        //    return String.Join(String.Empty, result);
        //}


        //public static string Add(string a, string b)
        //{
        //    var maxLength = Math.Max(a.Length, b.Length);
        //    var stack = new Stack<char>();
        //    var remainder = 0;
        //    for (var i = 1; i <= maxLength; i++)
        //    {
        //        var digit1 = (a.Length >= i ? a[a.Length - i] : '0') - '0';
        //        var digit2 = (b.Length >= i ? b[b.Length - i] : '0') - '0';
        //        var sum = digit1 + digit2 + remainder;
        //        stack.Push((char)('0' + (sum % 10)));
        //        remainder = sum / 10;
        //    }
        //    if (remainder > 0)
        //        stack.Push(remainder.ToString()[0]);
        //    return new string(stack.ToArray());
        //}


        //public static string Add(string a, string b)
        //{
        //    BigInteger c = BigInteger.Parse(a);
        //    BigInteger d = BigInteger.Parse(b);

        //    BigInteger e = c + d;
        //    return e.ToString(); // Fix this!
        //}


        //public static string Add(string a, string b)
        //{
        //    var aa = a.PadLeft(Math.Max(a.Length, b.Length)).Replace(" ", "0").Select(x => x - 48).ToArray();
        //    var bb = b.PadLeft(Math.Max(a.Length, b.Length)).Replace(" ", "0").Select(x => x - 48).ToArray();
        //    var rs = "";
        //    var add = 0;
        //    for (int i = aa.Length - 1; i > 0; i--)
        //    {
        //        rs = (aa[i] + bb[i] + add) % 10 + rs;
        //        add = (aa[i] + bb[i] + add) / 10;
        //    }
        //    return (aa[0] + bb[0] + add) + rs;
        //}


        //public static string Add(string a, string b)
        //{
        //    return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
        //}


        //public static string Add(string a, string b)
        //{
        //    BigInteger bigIntA = BigInteger.Parse(a);
        //    BigInteger bigIntB = BigInteger.Parse(b);
        //    BigInteger result = bigIntA + bigIntB;

        //    return result.ToString();
        //}


        //public static string Add(string a, string b) =>
        //    BigInteger.Add(
        //        BigInteger.Parse(a),
        //        BigInteger.Parse(b)
        //    ).ToString();


        //public static string Add(string a, string b)
        //{
        //    return Convert.ToString(BigInteger.Parse(a) + BigInteger.Parse(b)); // Fix this!
        //}


        //public static string Add(string a, string b)
        //{
        //    return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
        //}




    }
}