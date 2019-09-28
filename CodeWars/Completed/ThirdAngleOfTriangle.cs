
//https://www.codewars.com/kata/third-angle-of-a-triangle/train/csharp
//https://www.codewars.com/kata/5a023c426975981341000014/solutions/csharp

//Third Angle of a Triangle

//You are given two angles (in degrees) of a triangle.
//Write a function to return the 3rd.
//Note: only positive integers will be tested.

using System;

namespace CodeWars
{
    public class ThirdAngleOfTriangle
    {
        public static int OtherAngle(int a, int b)
        {
            return 180 - (a + b);
        }
    }
}