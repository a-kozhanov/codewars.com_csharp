/*
https://www.codewars.com/kata/604287495a72ae00131685c7/csharp

7 kyu
Doubleton number

We will call a natural number a "doubleton number" if it contains exactly two distinct digits. 
For example, 23, 35, 100, 12121 are doubleton numbers, and 123 and 9980 are not.

For a given natural number n (from 1 to 1 000 000), you need to find the next doubleton number. 
If n itself is a doubleton, return the next bigger than n.

Examples:
Doubleton(120) == 121
Doubleton(1234) == 1311
Doubleton(10) == 12
*/

using System.Linq;

namespace CodeWars
{
    public class DoubletonNumber
    {
        public static int Doubleton(int num)
        {
            while ((++num).ToString().Distinct().Count() != 2) ;
            return num;


            // num++;
            // while (num.ToString().Distinct().Count() != 2)
            // {
            //     num++;
            // }
            //
            // return num;


            // return Enumerable.Range(num + 1, 1000000 - (num + 1))
            //     .First(x => x.ToString().ToCharArray().Distinct().Count() == 2);


            // for (num++; (num + "").Distinct().Count() != 2; num++) ;
            // return num;


            // while ($"{++num}".Distinct().Count() != 2) ;
            // return num;
        }
    }
}