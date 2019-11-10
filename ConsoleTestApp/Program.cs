using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using CodeWars;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[] { 1, 2, 3, 4 };
            var n = 2;
            //var t = 2;
            //var s = 0;
            double result = 0;
            //string line;
            //short N = 0;
            //Console.WriteLine("Введите степень");
            //line = "2"; //Console.ReadLine();
            //int s = 3;

            for (var i = 0; i <= n; i++)
            {
                result = Math.Pow(3, i);
            }

            Console.WriteLine($"{result}");
            Console.ReadLine();
            //return array[n] ** n if n < len(array) else -1
        }
    }
}
