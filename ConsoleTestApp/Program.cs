using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using CodeWars;
using Microsoft.VisualBasic;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // [TestCase("THE WIND IN THE WILLOWS", "The In", "The Wind in the Willows")]
            //var title = "the quick brown fox";
            var title = "THE WIND IN THE WILLOWS";
            //var title = "aBC deF Ghi",null,"Abc Def Ghi";
            var minorWords = "The In";

            var titleWordsArray = title.Split().Select(x => x.ToLower()).ToArray();
            var minorWordsArray = minorWords.Split().Select(x => x.ToLower()).ToArray();
            List<string> result = new List<string>();

            Console.WriteLine(string.Join(" ", titleWordsArray));
            Console.WriteLine(string.Join(" ", minorWordsArray));
            Console.WriteLine();


            for (var i = 0; i < titleWordsArray.Length; i++)
            {
                var word = titleWordsArray[i].ToLower();
                //var w1 = w.ToLower();
                //Console.WriteLine(w1);
                Console.WriteLine(minorWordsArray.Contains(word));

                if (!minorWordsArray.Contains(word) || i == 0)
                {
                    //`${word.slice(0, 1).toUpperCase()}${word.slice(1).toLowerCase()}`
                    //var w1 = w.ToLower();
                    var w2 = string.Concat(word.Take(1)).ToUpper();
                    var w3 = string.Concat(word.Skip(1));

                    //Console.WriteLine(string.Concat(w1.Take(1).Concat(w1.Skip(1))).ToUpper());
                    //Console.WriteLine(w2 + w3);
                    //Console.WriteLine(w3);

                    //result.Add(string.Concat(w1.Take(1).Concat(w1.Skip(1))));
                    result.Add(w2 + w3);
                }
                else
                {
                    //Console.WriteLine("else");
                    result.Add(word);
                }
            }

            // foreach (var w in titleWordsArray)
            // {
            //
            // }

            Console.WriteLine(string.Join(" ", result));

            //var r = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(title.ToLower());
            // var result = "";
            // if (!string.IsNullOrEmpty(minorWords))
            // {
            //     var spl = minorWords.Split();
            //     foreach (var w in spl)
            //     {
            //         Console.WriteLine(w);
            //         Console.WriteLine(r);
            //         r = r.Replace($" {r} ", w);
            //         Console.WriteLine(r);
            //     }
            // }

            Console.WriteLine();
            //Console.WriteLine(r);
        }
    }
}