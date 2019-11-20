/*
https://www.codewars.com/kata/beginner-series-number-1-school-paperwork/train/csharp
https://www.codewars.com/kata/55f9b48403f6b87a7c0000bd/solutions/csharp

8 kyu
Beginner Series #1 School Paperwork

Your classmates asked you to copy some paperwork for them. You know that there are 'n' classmates and the paperwork has 'm' pages.
Your task is to calculate how many blank pages do you need.

Example:
Paperwork(5, 5) == 25

Note! if n or m < 0 return 0! Waiting for translations and Feedback! Thanks!
*/

using System;

namespace CodeWars
{
    public class BeginnerSeries1SchoolPaperwork
    {
        public static int Paperwork(int n, int m)
        {
            return n < 0 || m < 0 ? 0 : n * m;
        }

        //public static int Paperwork(int n, int m) => (n > 0 && m > 0) ? m*n : 0;


        //public static int Paperwork(int n, int m)
        //{
        //    //#Happy Coding! ^_^
        //    return (n < 0 | m < 0) ? 0 : n * m;
        //}

        //public static int Paperwork(int n, int m)
        //{
        //    if (n < 0) n = 0;
        //    if (m < 0) m = 0;

        //    return n*m;
        //}


        //public static int Paperwork(int n, int m) => Math.Max(n,0) * Math.Max(m, 0);


        //public static int Paperwork(int n, int m)
        //{
        //    return (n < 0) ? 0 : (m < 0) ? 0 : n * m;
        //}


    }
}