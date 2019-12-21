/*
https://www.codewars.com/kata/geometry-basics-circle-area-in-2d/train/csharp
https://www.codewars.com/kata/58e3f824a33b52c1dc0001c0/solutions/csharp

8 kyu
Geometry Basics: Circle Area in 2D

This series of katas will introduce you to basics of doing geometry with computers.

Write the function circleArea/CircleArea which takes in a Circle object and calculates the area of that circle.
The Circle class can be seen below:

public class Circle
{
  public Point Center { get; private set; }
  public double Radius { get; private set; }

  public Circle(Point center, double radius)
  {
    this.Center = center;
    this.Radius = radius;
  }
}
And the Point class can be seen below:

public class Point
{
  public double X { get; private set; }
  public double Y { get; private set; }

  public Point(double x, double y)
  {
    this.X = x;
    this.Y = y;
  }
}

Documentation:
Kata.CircleArea Method (Circle)
Returns the area of a circle.

Syntax
public static double CircleArea(
Circle circle
)

Parameters
circle
Type: Circle
The circle to calculate the area of.

Return Value
Type: System.Double
A double representing the area of the circle.
Tests round answers to 6 decimal places.

*/

using System;

namespace CodeWars
{
    public class GeometryBasicsCircleAreaIn2D
    {
        public class Circle
        {
            public Point Center;
            public double Radius;

            public Circle(Point center, double radius)
            {
                Center = center;
                Radius = radius;
            }
        }

        public class Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public static double CircleArea(Circle circle)
        {
            return Math.Round(Math.PI * Math.Pow(circle.Radius, 2), 6);
        }
    }
}