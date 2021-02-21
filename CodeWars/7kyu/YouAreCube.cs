/*
https://www.codewars.com/kata/57da5365a82a1998440000a9/csharp

7 kyu
You are a Cube!

In geometry, a cube is a three-dimensional solid object bounded by six square faces, 
facets or sides, with three meeting at each vertex.
The cube is the only regular hexahedron and is one of the five Platonic solids. 

It has 12 edges, 6 faces and 8 vertices.The cube is also a square parallelepiped, 
an equilateral cuboid and a right rhombohedron. It is a regular square prism in three orientations, 
and a trigonal trapezohedron in four orientations.

You are given a task of finding a if the provided value is a perfect cube!
*/

using System;

namespace CodeWars
{
    public class YouAreCube
    {
        public static bool YouAreACube(int value)
        {
            // double cubeRoot = Math.Pow(value, 1.0 / 3.0);
            // int c = (int) Math.Round(cubeRoot);
            // return c * c * c == value;


            // double cubeRoot = Math.Pow(value, 1.0 / 3.0);
            // int c = (int) Math.Round(cubeRoot);
            // return c * c * c == value;


            // for (int i = 1; i <= value; i++)
            //     if (i * i * i == value)
            //         return true;
            // return false;


            // return Math.Round(Math.Pow(Convert.ToDouble(value), 1.0 / 3), 2) % 1 == 0.0;

            return Math.Round(Math.Pow(value, 1 / 3d), 2) % 1 == 0;
        }
    }
}