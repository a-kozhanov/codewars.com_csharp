using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using CodeWars;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new string("world".Reverse().ToArray()));
            //Console.WriteLine(ReversedStrings.Solution("world"));

            //Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(new[] { 1, 1, 11, 2, 3 })); //6
            //Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(new[] { 6, 2, 1, 8, 10 })); //16
            //Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(new[] { 1, 2, 3 })); 
            //Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(new[] { 1, 2})); 
            //Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(new[] { 3 }));
            //Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(null));

            //Console.WriteLine(TitleCase.titleCase("a an the of", "a clash of KINGS"));    //"A Clash of Kings"
            //Console.WriteLine(TitleCase.titleCase("The In", "THE WIND IN THE WILLOWS"));  //"The Wind in the Willows"
            //Console.WriteLine(TitleCase.titleCase("the quick brown fox"));                         //"The Quick Brown Fox"


            //Console.WriteLine(BreakCamelCase.breakCamelCase("c a m e l CamelCasing"));
            //Console.WriteLine(BreakCamelCase.breakCamelCase("camelCasingTest"));
            //Console.WriteLine(BreakCamelCase.breakCamelCase("...Sm Xjbjr Jiw Sijuop Q Xcwt Pcy Bwowulhs Feyz Bx L N Pqjsghc J"));

            //Console.WriteLine(Divisors.divisors(30));

            //MexicanWave mexicanWave = new MexicanWave();
            //Console.WriteLine(mexicanWave.wave("hello"));
            //Console.WriteLine(mexicanWave.wave("two words"));
            //foreach (var w in mexicanWave.wave("two words"))
            //{
            //    Console.WriteLine(w);
            //}

            //Console.WriteLine(ShortestWord.FindShort("turns out random test cases are easier than writing out basic ones"));


            //var fighters = new string[][]
            //{
            //    new string[] { "Ryu", "E.Honda", "Blanka", "Guile", "Balrog", "Vega" },
            //    new string[] { "Ken", "Chun Li", "Zangief", "Dhalsim", "Sagat", "M.Bison" },
            //};

            //var moves = new string[] { "up", "left", "right", "left", "left" };
            //StreetFighter2 sf = new StreetFighter2();
            //Console.WriteLine(sf.StreetFighterSelection(fighters, new int[] { 0, 0 }, moves));

            //CountCharacters.Count("aba");

            //Console.WriteLine(MovesSquaredStrings.Oper(MovesSquaredStrings.VertMirror, "abcd\nefgh\nijkl\nmnop"));
            //Console.WriteLine();
            //WriteLine(MovesSquaredStrings.Oper(MovesSquaredStrings.HorMirror, "abcd\nefgh\nijkl\nmnop"));

            //Regex r = new Regex(@"^(\1.|^.)+$");
            ////n(n+1)/2

            //for (int n = 1; n <= 50; n++)
            //{
            //    Console.Write("{0} ", n * (n + 1) / 2);

            //    //if (r.IsMatch("".PadLeft(n)))
            //    //{
            //    //    Console.Write("({0}) ", n);
            //    //}
            //}

            //Console.WriteLine(SumTriangularNumbers.sumTriangularNumbers(6));


            //for (int i = 2; i <= 2; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            //return;

            // IEnumerable<int> squares = Enumerable.Range(2, 2).Select(x => x + x);

            // Console.WriteLine(string.Join(", ", squares));

            //foreach (int num in squares)
            //{
            //    Console.WriteLine(num);
            //}


            //sequenceSum(2,6,2) === 12 // 2 + 4 + 6
            //int start, int end, int step
            //int start = 2;
            //int stop = 6;
            //int step = 2;
            ////int x = start;

            //var numbers = new List<int>();
            //for (var i = start; i <= stop; i += step) numbers.Add(i);
            //Console.WriteLine(numbers.Sum());

            //Console.WriteLine(string.Join(", ", Enumerable.Range(start, ((stop - start) / step) + ((stop - start) % step == 0 ? 0 : 1))));

            //Console.WriteLine(string.Join(", ", RangeIterator(start, stop, step)));
            //Console.WriteLine(RangeIterator(start, stop, step).Sum());


            //Console.WriteLine(RemoveAnchorURL.RemoveUrlAnchor("www.codewars.com#about"));
            Console.WriteLine(YourOrder.Order("is2 Thi1s T4est 3a"));

        }




    }
}
