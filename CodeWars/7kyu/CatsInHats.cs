/*
https://www.codewars.com/kata/57b5907920b104772c00002a/csharp

7 kyu
Cats in hats

The Cat In The Hat has cat A under his hat, cat A has cat B under his hat and so on until Z
The Cat In The Hat is 2,000,000 cat units tall.
Each cat is 2.5 times bigger than the cat underneath their hat.
Find the total height of the cats if they are standing on top of one another.
Counting starts from the Cat In The Hat
n = the number of cats
fix to 3 decimal places.
*/

using System;

namespace CodeWars
{
    public class CatsInHats
    {
        public static string Height(int n)
        {
            return $"{2000000 * (1 - Math.Pow(.4, ++n)) / .6:F3}";
            // return $"{2000000 * (1 - Math.Pow(.4, ++n)) / .6:F3}";
            // return $"{2000000 * (1 - Math.Pow(.4, n + 1)) / .6:F3}";
            // return $"{2000000 * (1 - Math.Pow(0.4, n + 1)) / (1 - 0.4):F3}";

            // double height = 0, r = 2000000;
            // for (var i = 0; i <= n; i++, r /= 2.5)
            //     height += r;
            // return height.ToString("0.000");
        }
    }
}