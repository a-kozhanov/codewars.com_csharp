/*
https://www.codewars.com/kata/57f59da8d3978bb31f000152/csharp

7 kyu
Make Me Slow

Make me slow! Calling makeMeSlow() should take at least 7 seconds.
*/

using System;
using System.Threading;
using System.Threading.Tasks;

namespace CodeWars
{
    public class KataMakeMeSlow
    {
        public static void MakeMeSlow()
        {
            Thread.Sleep(7000);
            //Task.Delay(7000).GetAwaiter().GetResult();
            //System.Threading.Thread.Sleep(8000);

            // var end = DateTime.Now.AddMilliseconds(7000);
            // while (DateTime.Now < end);
        }
    }
}