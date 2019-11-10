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

            var ghost = new ColorGhost();
            //ghost.color; //=> "white" or "yellow" or "purple" or "red"
            Console.WriteLine(ghost.color);
            Console.WriteLine(ghost.GetColor());

            //var values = Enum.GetValues(typeof(ColorGhost.GhostColors));
            //var random = new Random();
            //var randomBar = (ColorGhost.GhostColors)values.GetValue(random.Next(values.Length));

            //ColorGhost.

            //Console.WriteLine(randomBar);

        }
    }
}
