using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

//https://www.codewars.com/kata/if-you-cant-sleep-just-count-sheep/train/csharp
//https://www.codewars.com/kata/5b077ebdaf15be5c7f000077/solutions/csharp

//If you can't sleep, just count sheep!!

//Task:
//Given a non-negative integer, 3 for example, return a string with a murmur: "1 sheep...2 sheep...3 sheep...". Input will always be valid, i.e.no negative integers.


namespace CodeWars
{
    public class JustCountSheep
    {
        public static string CountSheep(int n)
        {
            
            //return string.Join(" sheep...", Enumerable.Range(1, n)) + " sheep...";
            return $"{string.Join(" sheep...", Enumerable.Range(1, n))} sheep...";
            //string.Join(" sheep...", Enumerable.Range(1, n));
            
            var sb = new StringBuilder();
            for (var i = 1; i <= n; i++) sb.Append($"{i} sheep...");
            return sb.ToString();
        }


        //public static string CountSheep(int n)
        //{
        //    string result = "";
        //    for (int i = 1; i <= n; i++)
        //    {
        //        result += $"{i} sheep...";
        //    }
        //    return result;
        //}


        //public static string CountSheep(int n)
        //{
        //    return string.Concat(Enumerable.Range(1, n).Select(i => $"{i} sheep..."));
        //}


        //public static string CountSheep(int n)
        //{
        //    return Enumerable.Range(1, n)
        //      .Select(i => $"{i} sheep...")
        //      .Aggregate(new StringBuilder(), (sb, part) => sb.Append(part))
        //      .ToString();
        //}


        //public static string CountSheep(int n)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    Enumerable.Range(1, n).ToList().ForEach(x => sb.Append($"{x} sheep..."));
        //    return sb.ToString();
        //}

        //public static string CountSheep(int n)
        //{
        //    return string.Concat(Enumerable.Range(1, n).Select(z => z + " sheep..."));
        //}


        //public static string CountSheep(int n)
        //{
        //    return string.Concat(Enumerable.Range(1, n).Select(s => string.Format("{0} sheep...", s)));
        //}

        //public static string CountSheep(int n) => string.Join("", Enumerable.Range(1, n).Select(x => $"{x} sheep..."));

        //public static string CountSheep(int n)
        //{
        //    return string.Join(" sheep...", Enumerable.Range(1, n)) + " sheep...";
        //}

        //public static string CountSheep(int n)
        //{
        //    return string.Join("", Enumerable.Range(0, n).Select(x => $"{x + 1} sheep..."));
        //}

        //public static string CountSheep(int n)
        //{
        //    return string.Concat(Enumerable.Range(1, n).Select(a => a.ToString() + " sheep..."));
        //}

        //public static string CountSheep(int numberOfSheep)
        //{
        //    return Enumerable.Range(1, numberOfSheep).Select(x => $"{x} sheep...").Aggregate((s1, s2) => $"{s1}{s2}");
        //}

    }
}
