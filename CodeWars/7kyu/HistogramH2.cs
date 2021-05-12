/*
https://www.codewars.com/kata/5d5f5ea8e3d37b001dfd630a/csharp

7 kyu
Histogram - H2

This Kata is a variation of Histogram - H1

Kata in this series

Histogram - H1
Histogram - H2
Histogram - V1
Histogram - V2
Background
A 6-sided die is rolled a number of times and the results are plotted as percentages in a character-based horizontal histogram.

Example:

6|██ 5%
5|
4|███████ 15%
3|███████████████████████████████████ 70%
2|█ 3%
1|███ 7%
Task
You will be passed the dice value frequencies, and your task is to write the code to return a string representing a histogram, 
so that when it is printed it has the same format as the example.

Notes
There are no trailing spaces on the lines
All lines (including the last) end with a newline \n
The percentage is displayed beside each bar except where it is 0%
The total number of rolls varies, but won't exceed 10,000
The bar lengths are scaled so that 100% = 50 x bar characters
The bar character is █, which is the Unicode U+2588 char
When calculating percentages and bar lengths always floor/truncate to the nearest integer
*/

using System.Linq;

namespace CodeWars
{
    public class HistogramH2
    {
        public static string Histogram(int[] results)
        {
            return string.Concat(results.Select(x => x > 0 ? 100 * x / results.Sum() : 0)
                .Select((x, i) => $"{i + 1}|{(x == 0 ? "\n" : $"{new string('█', x / 2)} {x}%\n")}").Reverse());


            // return string.Concat(results
            //     .Select(rolls => results.Sum() > 0 ? rolls * 100 / results.Sum() : 0)
            //     .Select((p, i) => $"{i + 1}|{new string('\u2588', p / 2)}" + ((p > 0) ? $" {p}%" : null) + "\n")
            //     .Reverse());


            // return string.Concat(results.Select((x, i) =>
            //     i + 1 + "|" +
            //     (x > 0 ? $"{new string('█', 50 * x / results.Sum())} {100 * x / results.Sum()}%\n" : "\n")).Reverse());
        }
    }
}