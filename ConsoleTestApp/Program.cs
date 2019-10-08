using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text.RegularExpressions;
using CodeWars;

namespace ConsoleTestApp
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine(KataHowMuchILoveYou.HowMuchILoveYou(10));


            for (int i = 1; i < 150; i++)
            {
                var r = (i) % 6;
                //                var r = i > 6 ? (i) % 6 : i;
                if (r == 1) Console.WriteLine();

                Console.WriteLine(r);
            }

        }
    }
}
