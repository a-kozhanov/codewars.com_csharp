/*
https://www.codewars.com/kata/5ab6538b379d20ad880000ab/train/csharp


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
            // var r = l / (2 * 3.14);
            //
            //
            // if (l == w)
            // {
            //     //Console.WriteLine((l + w) * 2);
            // }
            // else
            // {
            //     //Console.WriteLine((l + w) * (l + w));
            // }

            return l == w ? (l + w) * 2 : (l + w) * (l + w);
        }
    }
}