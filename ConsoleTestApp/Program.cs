using System;
using System.Linq;
using CodeWars;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new string("world".Reverse().ToArray()));
            //Console.WriteLine(ReversedStrings.Solution("world"));

            Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(new[] { 1, 1, 11, 2, 3 })); //6
            Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(new[] { 6, 2, 1, 8, 10 })); //16
            Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(new[] { 1, 2, 3 })); 
            Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(new[] { 1, 2})); 
            Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(new[] { 3 }));
            Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(null));


        }
    }
}
