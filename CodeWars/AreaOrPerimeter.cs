/*
https://www.codewars.com/kata/5ab6538b379d20ad880000ab/train/csharp
https://www.codewars.com/kata/5ab6538b379d20ad880000ab/solutions/csharp

8 kyu
Area or Perimeter

You are given the length and width of a 4-sided polygon. The polygon can either be a rectangle or a square.
If it is a square, return its area. If it is a rectangle, return its perimeter.

area_or_perimeter(6, 10) --> 32
area_or_perimeter(4, 4) --> 16
Note: for the purposes of this kata you will assume that it is a square if its length and width are equal, otherwise it is a rectangle.
*/


namespace CodeWars
{
    public class KataAreaOrPerimeter
    {
        public static int AreaOrPerimeter(int l, int w)
        {
            //return (l + w) * 2; //ISSUE: test cases are completely wrong!!! 12.02.2020
            return l == w ? l * w : (l + w) * 2; //Correctly solution
        }

        // public static int AreaOrPerimeter(int l, int w)
        // {
        //     return l == w ? l * w : (l + w) * 2;
        // }


        // public static int AreaOrPerimeter(int l, int w) => 2 * (l + w);

        // public static int AreaOrPerimeter(int l, int w) => l == w ? l * w : 2 * (l + w);

        // public static int AreaOrPerimeter(int l, int w)
        // {
        //     return l == w ? l * w : 2 * (l + w);
        // }

        // public static int AreaOrPerimeter(int a, int b)
        // {
        //     return a == b ? a * b : 2 * (a + b);
        // }

        // public static int AreaOrPerimeter(int l, int w)
        // {
        //     if (l == w)
        //     {
        //         return l * w;
        //     }
        //     else
        //     {
        //         return l * 2 + w * 2;
        //     }
        // }


        // public static int AreaOrPerimeter(int l, int w)
        // {
        //     return 2 * l + 2 * w;
        // }


        // public static int AreaOrPerimeter(int l, int w)
        // {
        //     return l == w ? (int) Math.Pow(l, 2) : (l + w) * 2;
        // }
    }
}