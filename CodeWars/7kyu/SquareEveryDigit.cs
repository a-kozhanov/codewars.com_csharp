using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

//https://www.codewars.com/kata/square-every-digit/train/csharp
//https://www.codewars.com/kata/546e2562b03326a88e000020/solutions/csharp

//Square Every Digit
//Welcome.In this kata, you are asked to square every digit of a number.
//For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.
//Note: The function accepts an integer and returns an integer

namespace CodeWars
{
    public class SquareEveryDigit
    {
        public static int SquareDigits(int n)
        {
            return int.Parse(string.Concat(n.ToString().Select(x => Math.Pow(int.Parse(x.ToString()), 2))));
        }

        //Best Practices
        //public static int SquareDigits(int n)
        //{
        //    string output = "";
        //    foreach (char c in n.ToString())
        //    {
        //        int square = int.Parse(c.ToString());
        //        output += (square * square);
        //    }
        //    return int.Parse(output);
        //}
    }
}
