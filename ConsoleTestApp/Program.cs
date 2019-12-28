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
            var UpSpeed = 100;
            var DownSpeed = 10;
            var DesiredHeight = 910;

            var height = 0;
            var days = 0;

            while (height < DesiredHeight)
            {
                days++;
                height += UpSpeed;
                if (height >= DesiredHeight) break;
                height -= DownSpeed;
            }

            Console.WriteLine(days);
        }
    }
}