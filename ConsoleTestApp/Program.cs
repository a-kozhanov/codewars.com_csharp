using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using CodeWars;
using Microsoft.VisualBasic;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assert.AreEqual(KataAreaOrPerimeter.AreaOrPerimeter(4, 4), 16);
            // Assert.AreEqual(KataAreaOrPerimeter.AreaOrPerimeter(6, 10), 32);

            var l = 4;
            var w = 4;

            //var r = l / (2 * 3.14);
            //Console.WriteLine(r);
            //Console.WriteLine(Math.Pow(l, 2));


            //var p = l * 4;

            //Console.WriteLine(l * 4); //Переметр квадрата
            //Console.WriteLine(l * w); //Площадь квадрата
            //Console.WriteLine(Math.Pow(l, 2));
            // Console.WriteLine(4 * Math.Sqrt(l));
            //Console.WriteLine(4 * Math.Sqrt(w));

            //Console.WriteLine(4 * l);
            //Console.WriteLine(4 * w);

            //Console.WriteLine(l * l);
            //Console.WriteLine(w * w);

            //Console.WriteLine(Math.Pow(l, 2));
            //Console.WriteLine(Math.Pow(w, 2));


            //var P = 4 * l;
            //var S = w * w;

            //Console.WriteLine("Периметр= " + P);

            //Console.WriteLine("Площадь= " + S);

            //double p = 4 * Math.Sqrt(l * l);
            //Console.WriteLine("p=" + p);


            var a = l + w;
            var p = a * 2;
            var s = a * a;

            Console.WriteLine("a=" + a); // a-сторона квадрата
            Console.WriteLine("p=" + p); // p-периметр прямоуголника
            Console.WriteLine("s=" + s); // s-площадь квадрата

            if (l == w)
            {
                Console.WriteLine((l + w) * 2);
            }
            else
            {
                Console.WriteLine((l + w) * (l + w));
            }



        }
    }
}