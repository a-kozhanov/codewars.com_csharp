
/*
https://www.codewars.com/kata/name-shuffler/train/csharp
https://www.codewars.com/kata/559ac78160f0be07c200005a/solutions/csharp

8 kyu
Name Shuffler

Write a function that returns a string in which firstname is swapped with last name.

Kata.NameShuffler("john McClane") => "McClane john"

*/

using System;
using System.Linq;

namespace CodeWars
{
    public class KataNameShuffler
    {
        public static string NameShuffler(string str)
        {
            var result = str.Split();
            Array.Reverse(result);
            return string.Join(" ", result);
        }

        //public static string NameShuffler(string str) => string.Join(" ", str.Split(' ').Reverse());


        //public static string NameShuffler(string str)
        //{
        //    return string.Join(' ', str.Split(' ').Reverse());
        //}


        //public static string NameShuffler(string str)
        //{
        //    var s = str.Split(' ');
        //    return $"{s[1]} {s[0]}";
        //}

        //public static string NameShuffler(string str) => string.Join(" ", str.Split(' ').Reverse());

        //public static string NameShuffler(string str) => str.Substring(str.IndexOf(' ') + 1) + " " + str.Substring(0, str.IndexOf(' '));

        //public static string NameShuffler(string str)
        //{
        //    return string.Join(" ",Enumerable.Reverse(str.Split(" ")));
        //}


        //public static string NameShuffler(string str)
        //{
        //    string[] x = str.Split(" ");
        //    return x[1] + " " + x[0];
        //}





    }
}