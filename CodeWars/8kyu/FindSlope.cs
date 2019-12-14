/*
https://www.codewars.com/kata/find-the-slope/train/csharp
https://www.codewars.com/kata/55a75e2d0803fea18f00009d/solutions/csharp

8 kyu
Find the Slope

Given an array of 4 integers
[a,b,c,d] representing two points (a, b) and (c, d), return a string representation of the slope of the line joining these two points.

For an undefined slope (division by 0), return undefined . Note that the "undefined" is case-sensitive.

   a:x1
   b:y1
   c:x2
   d:y2```

Assume that ```[a,b,c,d]``` and the answer are all integers 
(no floating numbers!).
Slope: <https://en.wikipedia.org/wiki/Slope>
*/

using System;

namespace CodeWars
{
    public class FindSlope
    {
        public string slope(int[] points)
        {
            try
            {
                return ((points[3] - points[1]) / (points[2] - points[0])).ToString();
            }
            catch
            {
                return "undefined";
            }

        }

        //public string slope(int[] points) => points[2] == points[0] ? "undefined" : ((points[3] - points[1]) / (points[2] - points[0])).ToString();

        //public String slope(int[] points)
        //{
        //    return points[2] - points[0] == 0 ? "undefined" : ((points[3] - points[1]) / (points[2] - points[0])).ToString();
        //}
    }
}