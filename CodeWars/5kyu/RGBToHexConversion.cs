/*
https://www.codewars.com/kata/513e08acc600c94f01000001/csharp

5 kyu
RGB To Hex Conversion

The rgb function is incomplete. 
Complete it so that passing in RGB decimal values will result in a hexadecimal representation being returned. 
Valid decimal values for RGB are 0 - 255. 
Any values that fall out of that range must be rounded to the closest valid value.

Note: Your answer should always be 6 characters long, the shorthand with 3 will not work here.

The following are examples of expected output values:
Rgb(255, 255, 255) # returns FFFFFF
Rgb(255, 255, 300) # returns FFFFFF
Rgb(0,0,0) # returns 000000
Rgb(148, 0, 211) # returns 9400D3
*/

using System;
using System.Drawing;
using System.Linq;

namespace CodeWars
{
    public static class RGBToHexConversion
    {
        // private static string ToHex(this int n) => $"{(n > 255 ? 255 : n < 0 ? 0 : n):X2}";
        // public static string Rgb(int r, int g, int b) => $"{r.ToHex()}{g.ToHex()}{b.ToHex()}";

        public static string Rgb(params int[] rgb)
        {
            return string.Concat(rgb.Select(x => $"{Math.Clamp(x, 0, 255):X2}"));
        }
    }
}