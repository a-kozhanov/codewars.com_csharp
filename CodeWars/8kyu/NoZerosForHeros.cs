

//https://www.codewars.com/kata/no-zeros-for-heros/train/csharp
//https://www.codewars.com/kata/570a6a46455d08ff8d001002/solutions/solutions

//8 kyu
//No zeros for heros

//Numbers ending with zeros are boring.
//They might be fun in your world, but not here.
//Get rid of them. Only the ending ones.
//1450 -> 145
//960000 -> 96
//1050 -> 105
//-1050 -> -105
//Zero alone is fine, don't worry about it. Poor guy anyway


using System;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class NoZerosForHeros
    {
        public static int NoBoringZeros(int n)
        {
            return n == 0 ? 0 : int.Parse(n.ToString().TrimEnd('0'));
        }


        //public static int NoBoringZeros(int n) 
        //{        
        //    return (n == 0) ? 0 : Convert.ToInt32(n.ToString().TrimEnd('0'));
        //}


        //public static int NoBoringZeros(int n) 
        //{
        //    while (n != 0 && n % 10 == 0)
        //        n /= 10;

        //    return n;
        //}


        //public static int NoBoringZeros(int n) 
        //{
        //    return int.Parse(Regex.Replace(n.ToString(), "0+$", "") + "0") / 10;
        //}


        //public static int NoBoringZeros(int n) 
        //{
        //    string str = n.ToString().TrimEnd('0');

        //    if (str == "")
        //        return 0;
        //    else
        //        return int.Parse(str);
        //}



        //public static int NoBoringZeros(int n) 
        //{
        //    if (n == 0 || n%10 != 0) { return n; }
        //    return NoBoringZeros(n/10);
        //}


        //public static int NoBoringZeros(int n) 
        //{
        //    return n % 10 != 0 || n == 0 ? n : NoBoringZeros(n / 10);
        //}


        //public static int NoBoringZeros(int n)
        //{
        //    var str = n.ToString();
        //    while (str.Length > 1 && str[str.Length - 1] == '0')
        //        str = str.Substring(0, str.Length - 1);
        //    return int.Parse(str);
        //}






    }
}