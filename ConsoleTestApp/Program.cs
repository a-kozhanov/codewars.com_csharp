using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using CodeWars;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Enumerable.Range(1, 3).ToArray();
            //Console.WriteLine(RetrieveArrayValueByIndexWithDefault.Solution(range, 1, -1));
            // Console.WriteLine(RetrieveArrayValueByIndexWithDefault.Solution(range, -1, -1));
            // Console.WriteLine(RetrieveArrayValueByIndexWithDefault.Solution(range, -5, -1));
            //Console.WriteLine(RetrieveArrayValueByIndexWithDefault.Solution(range, -3, -1));


            var i2 = ^1;
            Console.WriteLine(range[i2]);

            var index = -1;

            //var result = range.Length - Math.Abs(index) + 1;
            var result = range[range.Length - Math.Abs(index)];

            Console.WriteLine(result);
        }
    }
}