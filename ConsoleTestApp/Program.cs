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
            Console.WriteLine(FindFirstNonConsecutiveNumber.FirstNonConsecutive(new int[] { 1, 2, 3, 4, 6, 7, 8 }));
        }
    }
}
