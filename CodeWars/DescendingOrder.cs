using System;
using System.Collections.Generic;
using System.Linq;

//https://www.codewars.com/kata/5467e4d82edf8bbf40000155/train/csharp
//

//Your task is to make a function that can take any non-negative integer as a argument and return it with its digits in descending order.Essentially, rearrange the digits to create the highest possible number.

//Examples:
//Input: 21445 Output: 54421

//Input: 145263 Output: 654321

//Input: 1254859723 Output: 9875543221

namespace CodeWars
{
    public class DescendingOrder
    {
        public static int descendingOrder(int num)
        {
            return Int32.Parse(string.Join("", num.ToString().Select(o => int.Parse(o.ToString())).Reverse()));
        }

        //Best Practices
        //public static int descendingOrder(int num)
        //{
        //    return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
        //}
    }
}