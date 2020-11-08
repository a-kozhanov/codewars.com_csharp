/*
https://www.codewars.com/kata/59ddeeb2fc3c49186f00009c/csharp

7 kyu
Symbols counted

In this kata you will have to transform each string so that it contains count for every symbol it contains, starting from 2. 
The order of symbols should be preserved.

Example: abbreviation => a2b2revi2ton
*/

using System.Linq;

namespace CodeWars
{
    public class SymbolsCounted
    {
        public static string Transform(string s)
        {
            //return string.Concat(s.GroupBy(g => g).Select(g => g.Key.ToString() + (g.Count() > 1 ? g.Count().ToString(): ""))).Replace("1", "");
            //return string.Concat(s.GroupBy(g => g).Select(g => g.Key.ToString() + (g.Count() > 1 ? g.Count().ToString(): "")));
            //return string.Join("", s.GroupBy(x => x).Select(g => g.Count() > 1 ? g.Key + g.Count().ToString() : g.Key + ""));
            //return string.Concat(s.Distinct().Select(x => s.Count(c => c == x) > 1 ? $"{x}{s.Count(c => c == x)}" : $"{x}"));
            //return string.Concat(s.GroupBy(c => c).Select(g => g.Count() == 1 ? g.Key.ToString() : $"{g.Key}{g.Count()}"));
            //return string.Concat(s.GroupBy(x => x).Select(x => $"{x.Key}{(x.Count() > 1 ? x.Count().ToString() : "")}"));
            //return string.Concat(s.GroupBy(x => x).Select(x => x.Key + (x.Count() > 1 ? x.Count().ToString() : "")));
            //return string.Concat(s.GroupBy(e => e).Select(e => e.Count() > 1 ? $"{e.Key}{e.Count()}" : $"{e.Key}"));
            //return string.Concat(s.GroupBy(x => x).Select(x => $"{x.Key}{(x.Count() > 1 ? $"{x.Count()}" : "")}"));
            //return string.Concat(s.GroupBy(g => g).Select(g => g.Key.ToString() + g.Count())).Replace("1", "");

            //return string.Concat(s.GroupBy(c => c).Select(g => g.Key + (g.Count() > 1 ? $"{g.Count()}" : "")));
            return string.Concat(s.GroupBy(c => c).Select(g => $"{g.Key}" + g.Count())).Replace("1", "");
        }
    }
}