
/*
https://www.codewars.com/kata/evil-or-odious/train/csharp
https://www.codewars.com/kata/56fcfad9c7e1fa2472000034/solutions/csharp

8 kyu
Evil or Odious

The number n is Evil if it has an even number of 1's in its binary representation.
The first few Evil numbers: 3, 5, 6, 9, 10, 12, 15, 17, 18, 20

The number n is Odious if it has an odd number of 1's in its binary representation.
The first few Odious numbers: 1, 2, 4, 7, 8, 11, 13, 14, 16, 19

You have to write a function that determine if a number is Evil of Odious, function should return "It's Evil!" in case of evil number and "It's Odious!" in case of odious number.

good luck :)
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class EvilOrOdious
    {
        public static string Evil(int n)
        {
            var count = 0;
            while (n > 0)
            {
                if (n % 2 == 1) count++;
                n /= 2;
            }
            return count % 2 == 1 ? "It's Odious!" : "It's Evil!";

        }


        //public static string Evil(int n)
        //    => Convert.ToString(n, 2).Count(e => e == '1') % 2 == 1 ? "It's Odious!" : "It's Evil!";


        //public static string Evil(int n)
        //{
        //    return "It's " + (Convert.ToString(n, 2).ToCharArray().Where(d => d == '1').ToArray().Length % 2 == 0 ? "Evil" : "Odious") + "!";
        //}

        //public static string Evil(int n)
        //{
        //    return Convert.ToString(n, 2).Where(a => a == '1').Count() % 2 == 0 ? "It's Evil!" : "It's Odious!";
        //}

        //public static string Evil(int n) => Convert.ToString(n, 2).Count(x => x == '1') % 2 == 0 ? "It's Evil!" : "It's Odious!";

        //public static string Evil(int n)
        //{
        //    int v = Convert.ToString(n, 2).Aggregate(0, (total, next) => total += int.Parse(next.ToString()));

        //    return v % 2 == 0 ? "It's Evil!" : "It's Odious!";
        //}

        //public static string Evil(int n)
        //{
        //    int count = 0;
        //    while (n != 0)
        //    {
        //        if ((n & 1) == 1) { ++count; }
        //        n >>= 1;
        //    }
        //    return ((count & 1) == 1) ? "It's Odious!" : "It's Evil!";
        //}


        //public static string Evil(int n)
        //{
        //    string binary = Convert.ToString(n, 2);
        //    int count = binary.Count(e => e == '1');

        //    return count % 2 == 0 ? "It's Evil!" : "It's Odious!";
        //}



    }
}