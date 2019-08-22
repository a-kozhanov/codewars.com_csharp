
//https://www.codewars.com/kata/extra-perfect-numbers-special-numbers-series-number-7/train/csharp
//https://www.codewars.com/kata/5a662a02e626c54e87000123/solutions/csharp

//Extra Perfect Numbers (Special Numbers Series #7)

//Definition
//Extra perfect number is the number that first and last bits are set bits.

//Task
//Given a positive integer N , Return the extra perfect numbers in range from 1 to N .

//Warm-up (Highly recommended)
//Playing With Numbers Series
//Notes
//Number passed is always Positive .

//Returned array/list should contain the extra perfect numbers in ascending order from lowest to highest

//Input >> Output Examples
//extraPerfect(3)  ==>  return {1,3}
//Explanation:
//(1)10 =(1)2
//First and last bits as set bits.

//(3)10 = (11)2
//First and last bits as set bits.

//extraPerfect(7)  ==>  return {1,3,5,7}
//Explanation:
//(5)10 = (101)2
//First and last bits as set bits.

//(7)10 = (111)2
//First and last bits as set bits.

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class ExtraPerfectNumbers
    {
        public static int[] ExtraPerfect(int n)
        {
            return Enumerable.Range(1, n).Where(x => x % 2 == 1).ToArray();
        }


        //public static IEnumerable<int> ExtraPerfect(int n)
        //{
        //    return Enumerable.Range(1, n).Where(x => x % 2 != 0);
        //}


        //public static int[] ExtraPerfect(int n)
        //{
        //    List<int> list = new List<int>();

        //    for (int i = 0; i <= n; i++)
        //    {
        //        if (i % 2 != 0)
        //            list.Add(i);
        //    }
        //    return list.ToArray();
        //}


        //public static int[] ExtraPerfect(int n) => Enumerable.Range(1, (n + 1) / 2).Select((i => i * 2 - 1)).ToArray(


        //public static int[] ExtraPerfect(int n)
        //{
        //    List<int> result = new List<int>();
        //    for (int i = 1; i <= n; i += 2)
        //    {
        //        result.Add(i);
        //    }
        //    return result.ToArray();
        //}




    }
}