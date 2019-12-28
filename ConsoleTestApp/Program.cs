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
            var kata = new SimpleFun37HouseNumbersSum();
            Console.WriteLine(string.Join(",", kata.HouseNumbersSum(new int[] {4, 2, 0, 6, 0})));
        }
    }
}