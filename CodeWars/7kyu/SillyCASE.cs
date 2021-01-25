/*
https://www.codewars.com/kata/552ab0a4db0236ff1a00017a/csharp

7 kyu
SillyCASE

Create a function that takes a string and returns that string with the first half lowercased and the last half uppercased.

eg: foobar == fooBAR

If it is an odd number then 'round' it up to find which letters to uppercase. See example below.

sillycase("brian")  
//         --^-- midpoint  
//         bri    first half (lower-cased)  
//            AN second half (upper-cased)  
*/

using System;

namespace CodeWars
{
    public class SillyCASE
    {
        public static string SillyCase(string str)
        {
            //int mid = (int) Math.Ceiling((double) str.Length / 2);
            //return str.Substring(0, mid).ToLower() + str.Substring(mid).ToUpper();

            //int half = (str.Length + 1) / 2;
            //return str.Substring(0, half).ToLower() + str.Substring(half).ToUpper();

            //int mid = str.Length / 2 + (str.Length % 2 == 0 ? 0 : 1);
            //return str.Substring(0, mid).ToLower() + str.Substring(mid, str.Length - mid).ToUpper();

            //return str[..(str.Length / 2 + str.Length % 2)].ToLower() + str[(str.Length / 2 + str.Length % 2)..].ToUpper();
            //return str[..((str.Length + 1) / 2)].ToLower() + str[((str.Length + 1) / 2)..].ToUpper();

            int half = (str.Length + 1) / 2;
            return str[..half].ToLower() + str[half..].ToUpper();
        }
    }
}