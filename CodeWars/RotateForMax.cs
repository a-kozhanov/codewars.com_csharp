/*
https://www.codewars.com/kata/56a4872cbb65f3a610000026/train/csharp
https://www.codewars.com/kata/56a4872cbb65f3a610000026/solutions/csharp

7 kyu
Rotate for a Max

Let us begin with an example:
Take a number: 56789. Rotate left, you get 67895.
Keep the first digit in place and rotate left the other digits: 68957.
Keep the first two digits in place and rotate the other ones: 68579.
Keep the first three digits and rotate left the rest: 68597. Now it is over since keeping the first four it remains only one digit which rotated is itself.
You have the following sequence of numbers:
56789 -> 67895 -> 68957 -> 68579 -> 68597
and you must return the greatest: 68957.

Task
Write function max_rot(n) which given a positive integer n returns the maximum number you got doing rotations similar to the above example.

So max_rot (or maxRot or ... depending on the language) is such as:
max_rot(56789) should return 68957
max_rot(38458215) should return 85821534
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class RotateForMax
    {
        public static long MaxRot(long n)
        {
            var result = new List<long> {n};
            for (var i = 0; i < n.ToString().Length; i++)
            {
                n = long.Parse(n.ToString().Remove(i, 1) + n.ToString()[i]);
                result.Add(n);
            }

            return result.Max();
        }

        // public static long MaxRot (long n) 
        // {
        //     long max = n;
        //     string number = n.ToString();
        //     for(int i = 0; i < number.Length - 1; i++)
        //     {
        //         number = number.Substring(0, i) + number.Substring(i + 1) + number[i];
        //         n = long.Parse(number);
        //         if(n > max) max = n;
        //     }
        //     return max;
        // }


        // public static long MaxRot (long n) 
        // {
        //     var rs=new List<string>();
        //     var s=""+n;
        //     for (int i=0,len=s.Length;i<len;s=s.Substring(0,i++)+s.Substring(i)+s[i-1]) rs.Add(s);
        //     return rs.Max(long.Parse);
        // }

        // public static long MaxRot (long n) 
        // {
        //     List<long> tmp = new List<long>();
        //
        //     string s=Convert.ToString(n);
        //     tmp.Add(Convert.ToInt64(s)); 
        //
        //     for (int i = 1; i <= s.Length; i++) {
        //         s=s.Substring(0,i-1)+s.Substring(i,s.Length-i)+s.Substring(i-1,1);
        //         tmp.Add(Convert.ToInt64(s));
        //     }        
        //
        //     return tmp.Max(x=>x);
        // }


        // public static long MaxRot (long n) 
        // {
        //     string str = n.ToString();
        //     string[] arr = new string[str.Length];
        //     for (int i = 0; i < str.Length; i++)
        //     {
        //         arr[i] = str;
        //         str = str.Remove(i, 1) + str[i];                
        //     }
        //     return long.Parse(arr.Max());
        // }


        // public static long MaxRot(long n)
        // {
        //     string[] rotAr = new string[n.ToString().Length];
        //     rotAr[0] = n.ToString();
        //     for (int i = 1; i < rotAr[0].Length; i++)
        //     {
        //         rotAr[i] = rotAr[i - 1].Substring(0, i - 1) + rotAr[i - 1].Substring(i) + rotAr[i - 1][i - 1];
        //     }
        //     return rotAr.Select(x => Int64.Parse(x)).Max();
        // }


        // public static long MaxRot(long n)
        // {
        //     string s = n.ToString();
        //     long max = n;
        //
        //     for (int i = 0; i < s.Length; i++)
        //     {
        //         s = s.Substring(0, i) + s.Substring(i + 1) + s[i];
        //         max = Math.Max(max, long.Parse(s));
        //     }
        //
        //     return max;
        // }
    }
}