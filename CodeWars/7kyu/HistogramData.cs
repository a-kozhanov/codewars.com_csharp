/*
https://www.codewars.com/kata/5704bf9b38428f1446000a9d/csharp

7 kyu
Histogram data

You will be given an array of non-negative integers and positive integer bin width.

Your task is to create the Histogram method that will return histogram data corresponding to the input array. 
The histogram data is an array that stores under index i the count of numbers that belong to bin i. 
The first bin always starts with zero.

On empty input you should return empty output.

Examples:
For input data [1, 1, 0, 1, 3, 2, 6] and binWidth=1 the result will be [1, 3, 1, 1, 0, 0, 1] as the data contains single element "0", 3 elements "1" etc.
For the same data and binWidth=2 the result will be [4, 2, 0, 1]
For input data [7] and binWidth=1 the result will be [0, 0, 0, 0, 0, 0, 0, 1]
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class HistogramData
    {
        public static uint[] Histogram(uint[] data, uint binWidth)
        {
            // uint[] bins = new uint[data.Length == 0 ? 0 : data.Max() / binWidth + 1];
            //
            // foreach (var d in data)
            //     bins[d / binWidth] += 1;
            //
            // return bins;

            // if (data.Length == 0)
            // {
            //     return new uint[0];
            // }
            //
            // var ix = new uint[(data.Max() + binWidth) / binWidth];
            // foreach (var v in data)
            // {
            //     ix[v / binWidth]++;
            // }
            //
            // return ix;


            // if (data.Length == 0) return new uint[0];
            // uint[] hist = new uint[data.Max() / binWidth + 1];
            // foreach (uint num in data) hist[num / binWidth]++;
            // return hist;


            // return data.Length == 0
            //     ? data
            //     : Enumerable.Range(0, (int) Math.Ceiling((1.0 + data.Max()) / binWidth))
            //         .Select(i => (uint) data.Count(num => num >= binWidth * i && num < binWidth * (i + 1)))
            //         .ToArray();


            // if (!data.Any())
            //     return data;
            // return Enumerable
            //     .Range(0, (int) Math.Ceiling((data.Max() + 1d) / binWidth))
            //     .Select((e, i) => (uint) (data.Where(b => b >= i * binWidth && b < (i + 1) * binWidth).Count()))
            //     .ToArray();


            //     return data.Length == 0
            //         ? data
            //         : new int[data.Max() / binWidth + 1].Select((_, i) => (uint) data.Count(x => x / binWidth == i))
            //             .ToArray();

            return data.Length == 0
                ? data
                : new int[data.Max() / binWidth + 1].Select((_, i) => (uint) data.Count(u => u / binWidth == i)).ToArray();
        }
    }
}