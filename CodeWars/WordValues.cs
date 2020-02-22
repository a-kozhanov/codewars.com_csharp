/*
https://www.codewars.com/kata/598d91785d4ce3ec4f000018/train/csharp
https://www.codewars.com/kata/598d91785d4ce3ec4f000018/solutions/csharp

7 kyu
Word values

Given a string "abc" and assuming that each letter in the string has a value equal to its position in the alphabet, 
our string will have a value of 1 + 2 + 3 = 6. This means that: a = 1, b = 2, c = 3 ....z = 26.

You will be given a list of strings and your task will be to return the values of the strings as explained above multiplied by the position of that string in the list. 
For our purpose, position begins with 1.

nameValue ["abc","abc abc"] should return [6,24] because of [ 6 * 1, 12 * 2 ]. Note how spaces are ignored.

"abc" has a value of 6, while "abc abc" has a value of 12. 
Now, the value at position 1 is multiplied by 1 while the value at position 2 is multiplied by 2.

Input will only contain lowercase characters and spaces.

Good luck!
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class WordValues
    {
        public static int[] WordValue(string[] a)
        {
            //return a.Select((x, i) => x.Split().Select(s => s.Sum(c => c - 96)).Select(v => v * (i + 1)).Sum()).ToArray();
            //return a.Select((x, i) => x.Where(c => !c.Equals(' ')).Sum(c => !c.Equals(' ') ? c - 96 : 0) * ++i).ToArray();
            //return a.Select((w, i) => w.Where(char.IsLetter).Sum(c => c - 'a' + 1) * (i + 1)).ToArray();
            //return a.Select((w, i) => w.Where(char.IsLetter).Sum(c => c - 96) * (i + 1)).ToArray();
            //return a.Select((x, i) => x.Replace(" ", "").Sum(y => (y - 96) * (i + 1))).ToArray();
            //return a.Select((x, i) => x.Sum(c => !c.Equals(' ') ? c - 96 : 0) * ++i).ToArray();
            //return a.Select((x, i) => x.Where(c => c != 32).Sum(c => c - 96) * ++i).ToArray();
            //return a.Select((x, i) => x.Replace(" ", "").Sum(c => c - 96) * ++i).ToArray();
            //return a.Select((x, i) => x.Replace(" ", "").Sum(c => c - 96) * ++i).ToArray();
            return a.Select((x, i) => x.Sum(c => c != 32 ? c - 96 : 0) * ++i).ToArray();
        }

        // public static int[] WordValue(string[] a)
        // {
        //     return a.Select((w, i) => w.Where(c => char.IsLetter(c)).Sum(c => c - 'a' + 1) * (i + 1)).ToArray();
        // }

        // public static int[] WordValue(string[] strs)
        // {
        //     return strs.Select((x, i) => x.Replace(" ", "").Sum(y => (y - 96) * (i + 1))).ToArray();
        // }

        // public static int[] WordValue(string[] a) => a.Select((s, i) =>
        //         (i + 1) * s.ToCharArray().Aggregate(0, (t, c) => t + 1 + "abcdefghijklmnopqrstuvwxyz".IndexOf(c)))
        //     .ToArray();

        // public static int[] WordValue(string[] a) => a
        //     .Select((t, i) => t.Select(u => Char.IsLetter(u) ? Char.ToLower(u) - 96 : 0).Sum() * (i + 1)).ToArray();

        // public static int[] WordValue(string[] a) =>
        //     a.Select((s, i) => (i + 1) * s.Sum(c => c == ' ' ? 0 : c - 'a' + 1)).ToArray();

        // public static int[] WordValue(string[] a) =>
        //     a.Select((str, i) => str.Replace(" ", "").Sum(chr => chr - 96) * (i + 1)).ToArray();


        // public static int[] WordValue(string[] a)
        // {
        //     int[] output = new int[a.Length];
        //     for (int i = 0; i < a.Length; i++)
        //     {
        //         byte[] asciiBytes = Encoding.ASCII.GetBytes(a[i]);
        //         int sum = 0;
        //         for (int j = 0; j < asciiBytes.Length; j++)
        //         {
        //             if (asciiBytes[j] > 96) sum += asciiBytes[j] - 96;
        //         }
        //
        //         output[i] = (i + 1) * sum;
        //     }
        //
        //     return output;
        // }


        // public static int[] WordValue(string[] a)
        // {
        //     return a.Select((words, index) => words.Split(' ')
        //                                           .Sum(word => word.Sum(x => (int) x - 96))
        //                                       * (index + 1))
        //         .ToArray();
        // }


        // public static int[] WordValue(string[] a) => a
        //     .Select((x, i) => Regex.Replace(x, @"[^A-z]", "").ToCharArray().Sum(y => y - 96) * (i + 1)).ToArray();
    }
}