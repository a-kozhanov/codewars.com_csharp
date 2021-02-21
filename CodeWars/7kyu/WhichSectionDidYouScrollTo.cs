/*
https://www.codewars.com/kata/5cb05eee03c3ff002153d4ef/csharp

7 kyu
Which section did you scroll to?

Your website is divided vertically in sections, and each can be of different size (height).
You need to establish the section index (starting at 0) you are at, given the scrollY and sizes of all sections.
Sections start with 0, so if first section is 200 high, it takes 0-199 "pixels" and second starts at 200.

Example:
getSectionIdFromScroll( 300, [300,200,400,600,100] )

will output number 1 as it's the second section.

getSectionIdFromScroll( 1600, [300,200,400,600,100] )

will output number -1 as it's past last section.

Given the scrollY integer (always non-negative) and an array of non-negative integers (with at least one element), 
calculate the index (starting at 0) or -1 if scrollY falls beyond last section (indication of an error).

*/

using System;
using System.Linq;

namespace CodeWars
{
    public class WhichSectionDidYouScrollTo
    {
        public static int GetSectionId(int n, int[] a)
        {
            return a.Sum() > n ? a.Count(x => (n -= x) >= 0) : -1;
            //return a.Sum() > n ? a.TakeWhile(s => (n -= s) >= 0).Count() : -1;
            //return Array.FindIndex(a, x => (n -= x) < 0);

            // int sum = 0;
            // for (int i = 0; i < a.Length; i++)
            // {
            //     sum += a[i];
            //     if (n < sum)
            //         return i;
            // }
            // return -1;
        }
    }
}