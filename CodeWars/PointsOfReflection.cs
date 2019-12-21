/*
https://www.codewars.com/kata/points-of-reflection/train/csharp
https://www.codewars.com/kata/57bfea4cb19505912900012c/solutions/csharp

8 kyu
Points of Reflection

"Point reflection" or "point symmetry" is a basic concept in geometry where a given point, P, 
at a given position relative to a mid-point, Q has a corresponding point, P1, 
which is the same distance from Q but in the opposite direction.

Task
Given two points P and Q, output the symmetric point of point P about Q. 
Each argument is a two-element array of integers representing the point's X and Y coordinates. 
Output should be in the same format, giving the X and Y coordinates of point P1. 
You do not have to validate the input.

This kata was inspired by the Hackerrank challenge Find Point

*/

namespace CodeWars
{
    public class PointsOfReflection
    {
        public static int[] SymmetricPoint(int[] p, int[] q)
        {
            return new[] { q[0] * 2 - p[0], q[1] * 2 - p[1] };
        }
    }
}


//public class Kata
//{
//    public static int[] SymmetricPoint(int[] p, int[] q) => new[] { 2 * q[0] - p[0], 2 * q[1] - p[1] };
//}


//public class Kata
//{
//    public static int[] SymmetricPoint(int[] p, int[] q) => new int[] { 2 * q[0] - p[0], 2 * q[1] - p[1] };
//}


//public class Kata
//{
//    public static int[] SymmetricPoint(int[] p, int[] q)
//    {
//        int x = (q[0] * 2) - p[0];
//        int y = (q[1] * 2) - p[1];
//        return new int[] { x, y };
//    }
//}


//using System;
//public class Kata
//{
//    public static int[] SymmetricPoint(int[] p, int[] q)
//    {
//        return new int[] { 2 * q[0] - p[0], 2 * q[1] - p[1] };
//    }
//}


//public class Kata
//{
//    public static int[] SymmetricPoint(int[] p, int[] q)
//    {
//        p[0] = 2 * q[0] - p[0];
//        p[1] = 2 * q[1] - p[1];
//        return p;
//    }
//}