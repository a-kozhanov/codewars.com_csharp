/*
https://www.codewars.com/kata/58aa68605aab54a26c0001a6/train/csharp

7 kyu
Simple Fun #144: Distinct Digit Year

Task
The year of 2013 is the first year after the old 1987 with only distinct digits.

Now your task is to solve the following problem: given a year number, 
find the minimum year number which is strictly larger than the given one and has only distinct digits.

Input/Output
[input] integer year

1000 ≤ year ≤ 9000

[output] an integer

the minimum year number that is strictly larger than the input number year and all its digits are distinct.
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class SimpleFun144DistinctDigitYear
    {
        public int DistinctDigitYear(int year)
        {
            return (++year).ToString().Distinct().Count() == 4 ? year : DistinctDigitYear(year);


            //return Regex.IsMatch(++year + "", "(.).*\\1") ? DistinctDigitYear(year) : year;
            //return new[] {year}.Append(Enumerable.Range(year + 1, 9000 - year).First(x => x.ToString().Distinct().Count() == 4)).Last();
            //return Enumerable.Range(year + 1, 9000 - year).Where(x => x.ToString().Distinct().Count() == 4).DefaultIfEmpty(year).First();
            //return int.Parse(Enumerable.Range(1, 1000).Select(t => string.Concat((year + t).ToString().Distinct())).Where(u => u.Length == 4).ElementAt(0));

            // return Enumerable.Range(year + 1, 9012 - year)
            //     .First(n => n.ToString().Distinct().Count() == n.ToString().Length);

            // var result = year;
            // for (var i = year + 1; i < 9000; i++)
            // {
            //     if (i.ToString().Distinct().Count() != 4) continue;
            //     result = i;
            //     break;
            // }
            //
            // return result;
        }
    }
}