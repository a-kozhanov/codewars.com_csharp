/*
https://www.codewars.com/kata/58989a079c70093f3e00008d/csharp

7 kyu
Cartesian neighbors

A Cartesian coordinate system is a coordinate system that specifies each point uniquely in a plane by a pair of numerical coordinates, 
which are the signed distances to the point from two fixed perpendicular directed lines, measured in the same unit of length.

The сoordinates of a point in the grid are written as (x,y). Each point in a coordinate system has eight neighboring points. 
Provided that the grid step = 1.

It is necessary to write a function that takes a coordinate on the x-axis and y-axis and returns a list of all the neighboring points. 
Points inside list don't have to been sorted (any order is valid).

For Example:
cartesianNeighbor(2,2) -> {{1,1},{1,2},{1,3},{2,1},{2,3},{3,1},{3,2},{3,3}}
cartesianNeighbor(5,7) -> {{6,7},{6,6},{6,8},{4,7},{4,6},{4,8},{5,6},{5,8}}
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class CartesianNeighbors
    {
        public static IEnumerable<int[]> cartesianNeighbor(int x, int y)
        {
            return new[]
            {
                new[] {x - 1, y - 1},
                new[] {x - 1, y},
                new[] {x - 1, y + 1},
                new[] {x, y - 1},
                new[] {x, y + 1},
                new[] {x + 1, y - 1},
                new[] {x + 1, y},
                new[] {x + 1, y + 1}
            };


            // for (int xi = x - 1; xi <= x + 1; xi++)
            // {
            //     for (int yi = y - 1; yi <= y + 1; yi++)
            //     {
            //         if (xi != x || yi != y) yield return new[] {xi, yi};
            //     }
            // }


            // return Enumerable.Range(x - 1, 3).SelectMany(xn =>
            //     Enumerable.Range(y - 1, 3).Where(yn => xn != x || yn != y).Select(yn => new[] {xn, yn}));

            // return Enumerable.Range(-1, 3).SelectMany(xc => Enumerable.Range(-1, 3).Select(yc => new int[] {xc, yc}))
            //     .Where(c => c[0] != 0 || c[1] != 0).Select(c => new int[] {x + c[0], y + c[1]});


            // yield return new[] {x - 1, y - 1};
            // yield return new[] {x - 1, y};
            // yield return new[] {x - 1, y + 1};
            // yield return new[] {x, y - 1};
            // yield return new[] {x, y + 1};
            // yield return new[] {x + 1, y - 1};
            // yield return new[] {x + 1, y};
            // yield return new[] {x + 1, y + 1};
        }
    }
}