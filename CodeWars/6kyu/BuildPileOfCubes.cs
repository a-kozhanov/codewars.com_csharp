/*
https://www.codewars.com/kata/5592e3bd57b64d00f3000047/csharp

6 kyu
Build a pile of Cubes

our task is to construct a building which will be a pile of n cubes. The cube at the bottom will have a volume of n^3, 
the cube above will have volume of (n-1)^3 and so on until the top which will have a volume of 1^3.

You are given the total volume m of the building. Being given m can you find the number n of cubes you will have to build?

The parameter of the function findNb (find_nb, find-nb, findNb) will be an integer m and you have to return the integer n such as n^3 + (n-1)^3 + ... + 1^3 = m if such a n exists or -1 if there is no such n.

Examples:
findNb(1071225) --> 45
findNb(91716553919377) --> -1
mov rdi, 1071225
call find_nb            ; rax <-- 45

mov rdi, 91716553919377
call find_nb            ; rax <-- -1
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class BuildPileOfCubes
    {
        public static long findNb(long m)
        {
            long c = 0;
            while (m > 0)
                m -= c * c * c++;
            return m == 0 ? --c : -1;

            // long count = 0;
            // while (m > 0)
            // {
            //     m -= ++count * count * count;
            // }
            //
            // return m == 0 ? count : -1;


            // long volume = 1, i = 2;
            // for (; volume < m; i++)
            // {
            //     volume += i * i * i;
            // }
            //
            // return volume == m ? i - 1 : -1;


            // long s = 0;
            // long n = 0;
            // while (s < m)
            // {
            //     s += (long) Math.Pow(++n, 3);
            // }
            //
            // return s == m ? n : -1;


            // long count = 0;
            // while (m > 0)
            // {
            //     count += 1;
            //     m -= count * count * count;
            // }
            //
            // return m == 0 ? count : -1;


            // var count = 0;
            // while (m > 0)
            // {
            //     count++;
            //     m -= (long) Math.Pow(count, 3);
            // }
            //
            // return m == 0 ? count : -1;


            // long mm = 0, n = 0;
            // while (mm < m) mm += ++n * n * n;
            // return mm == m ? n : -1;


            // var result = Enumerable.Range(1, 999999999)
            //     .TakeWhile(x =>
            //     {
            //         m -= (long) Math.Pow(x, 3);
            //         return m > 0;
            //     })
            //     .Count() + 1;
            //
            // return m == 0 ? (long) result : -1;
        }
    }
}