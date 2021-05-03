/*
https://www.codewars.com/kata/599da159a30addffd00000af/csharp

7 kyu
Collision Detection

Create a function to determine whether or not two circles are colliding. You will be given the position of both circles in addition to their radii:

function collision(x1, y1, radius1, x2, y2, radius2) {
  // collision?
}
If a collision is detected, return true. If not, return false.

Here's a geometric diagram of what the circles passed in represent:
*/

using System;

namespace CodeWars
{
    public class CollisionDetection
    {
        public static bool Collision(double x1, double y1, double r1, double x2, double y2, double r2)
        {
            return r1 + r2 >= Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            // return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)) <= r1 + r2;
        }
    }
}