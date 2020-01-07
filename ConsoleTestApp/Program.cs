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
            // AddLetters(new char[] {'a', 'b', 'c'}) = 'f'
            // AddLetters(new char[] {'a', 'b'}) = 'c'
            // AddLetters(new char[] {'z'}) = 'z'
            // AddLetters(new char[] {'z', 'a'}) = 'a'
            // AddLetters(new char[] {'y', 'c', 'b'}) = 'd' // notice the letters overflowing
            // AddLetters(new char[] {}) = 'z'

            var letters = new char[] {'a', 'b', 'c'};
            //var letters = new char[] {'z', 'a'};
            //var letters = new char[] {'y', 'c', 'b'}; //AddLetters(new char[] {'y', 'c', 'b'}) = 'd' 
            //var letters = new char[] {'p', 's', 'x', 'r', 'q', 'x', 'f', 't', 'a', 'h'};
            //var letters = new char[] {'x', 'v', 'r', 't', 'o'};
            //var letters = new char[] {'z'};

            var sumLetters = letters.Sum(c => c);
            var countLetters = sumLetters > 122 ? (letters.Length - 1) : letters.Length - 1;
            var result = letters.Sum(c => c) - 96 * (letters.Length - 1);
            result = result > 122 ? result - 26 : result;

            Console.WriteLine($"letters: {string.Join("', '", letters)}");
            Console.WriteLine($"countLetters: {countLetters}");
            Console.WriteLine($"sumLetters: {sumLetters}");
            Console.WriteLine($"result: {result}");
            Console.WriteLine($"char: {(char) result}");


            // var val = letters.Sum(c => c-96) % 26;
            // return val == 0 ? 'z' : (char)(val + 96);

            //var chrCode = letters.Sum(c => c) - 96 * (letters.Length - 1);
            //var chrCode = letters.Sum(c => c - 96) % 26 + 96;
            //var chrCode = letters.Sum(c => c) % 26 + 96;
            // Console.WriteLine((char) (chrCode > 122 ? chrCode - 26 : chrCode));

            var r1 = letters.Sum(c => c - 96);
            var r2 = r1 % 26;
            var r3 = r2 + 96;

            var p1 = letters.Sum(c => c) - 96 * (letters.Length - 1) % 26;
            //array.Select((v, i) => v == n ? i : -1)

            //char[] letters2 = Enumerable.Range('a', 26).Select(c => (char) c).ToArray();

            //var letters22 = Enumerable.Range('a', 26).ToArray()[l.Sum(e => letters.Contains(e)) % 26];
            //.Sum(x => letters.Contains((char) x) ? x : 0);

            var let = Enumerable.Range('a', 26).Sum(x => letters.Contains((char) x) ? x : 0) % 26 + 96;

            Console.WriteLine();
            //var let2 = Enumerable.Range('a', 26).Select((v, i) => letters.Contains((char) v)).Sum(x => x);

            //.Sum(x => letters.Contains((char) x) ? x : 0);

            //public static char AddLetters(char[] l, string al ="zabcdefghijklmnopqrstuvwxy") => al[l.Sum(e=> al.IndexOf(e))%26];


            //Console.WriteLine((char) Math.Max(97, letters.Sum(c => c) - 96 * (letters.Length - 1)));
            //Console.WriteLine((char) Math.Max(97, letters.Sum(c => c - 96) % 26 + 96));
            //Console.WriteLine((char) (letters.Sum(c => c - 96) % 26 + 96 - letters.Length));

            //return (char) Math.Max(97, (letters.Sum(c => c - 96 % 26) + 96));


            //Math.Min(122, letters.Sum(c => c - 96) % 26 + 96);

            //var chrCode = Math.Min(122, letters.Sum(c => c - 96) % 26 + 97); //* (letters.Length - 1);
            // while (chrCode > 122)
            // {
            //     chrCode -= 26;
            // }

            //return (letters.Length == 0) ? 'z' : (char) chrCode;

            Console.WriteLine();


            // while (chrCode > 123)
            // {
            //     chrCode -= 26;
            // }

            //Console.WriteLine($"chrCode:{chrCode}");
            //Console.WriteLine($"chrCode:{chrCode}");
            //Console.WriteLine($"chrCode:{(char) chrCode}");

            // Console.WriteLine($"chrCode:{chrCode + 96}");
            // Console.WriteLine($"(char)chrCode:{(char) (chrCode + 96)}");

            //var inx = chrCode > 122 ? chrCode - 26 * m : chrCode;
            //var inx = chrCode - 26 * (m - 1);

            //Console.WriteLine($"inx:{inx}");

            // for (int i = 100; i < chrCode + 1; i++)
            // {
            //     Console.Write($"{(char) i}({i})");
            // }

            //Console.WriteLine((char) (letters.Sum(c => c - 96) % 26));
            //Expected: 'u'
            // var val = letters.Sum(c => c - 96) % 26;
            // Console.WriteLine(val == 0 ? 'z' : (char) (val + 96));
            //
            // Console.WriteLine(letters.Length == 0 ||  'z');

            // var result2 = letters.Sum(letter => letter - 96);
            //
            // result2 %= 26;
            //
            // Console.WriteLine(result2 == 0 ? 'z' : (char) (result2 + 96));
        }
    }
}