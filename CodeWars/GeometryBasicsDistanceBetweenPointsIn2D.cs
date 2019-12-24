/*
https://www.codewars.com/kata/geometry-basics-distance-between-points-in-2d/train/csharp
https://www.codewars.com/kata/58dced7b702b805b200000be/solutions/csharp

8 kyu
Geometry Basics: Distance between points in 2D

This series of katas will introduce you to basics of doing geometry with computers.
Point objects have x and y attributes (X and Y in C#) attributes.
Write a function calculating distance between Point a and Point b.
Tests round answers to 6 decimal places.
*/

using System;

namespace CodeWars
{
    public class GeometryBasicsDistanceBetweenPointsIn2D
    {
        public class Point
        {
            public double X;
            public double Y;

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
        }
        
        public static double DistanceBetweenPoints(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
    }
}