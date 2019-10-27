
//https://www.codewars.com/kata/surface-area-and-volume-of-a-box/train/csharp
//https://www.codewars.com/kata/565f5825379664a26b00007c/solutions/csharp

//Surface Area and Volume of a Box

//Write a function that returns the total surface area and volume of a box as an array: [area, volume]

using System;

namespace CodeWars
{
    public class SurfaceAreaVolumeBox
    {
        public static int[] Get_size(int w, int h, int d)
        {
            return new[] { 2 * h * w + 2 * d * h + 2 * w * d, w * h * d };
        }


        //public static int[] Get_size(int w,int h,int d)
        //{
        //    int area = 2 * (w * h + w * d + h * d);
        //    int volume = w * h * d;
        //    return new int[] {area, volume};
        //}

        //public static int[] Get_size(int w,int h,int d)
        //{
        //    return new int[] {2*(h*w + h*d + w*d), w*h*d};
        //}

        //public static int[] Get_size(int w,int h,int d)
        //{
        //    return new int[] { 2 * (w * h + h * d + w * d), w * h * d};
        //}

        //public static int[] Get_size(int Width, int Height, int Depth) => new int[]{
        //    2 * (Width * Height  + Height * Depth + Width * Depth),
        //    Width * Height * Depth
        //};

        //public static int[] Get_size(int w,int h,int d)
        //{
        //    return new int[] { 2 * (w * h + w * d + h * d), w * h * d };
        //}

        //public static int[] Get_size(int w,int h,int d) => new int[]{2 *(w * h + w * d + d * h), w * h * d};

        //public static int[] Get_size(int w,int h,int d)
        //{
        //    return new int[]{ 2 * ( w * h + h * d + d * w), w * h * d};
        //}

        //public static int[] Get_size(int w,int h,int d)
        //{
        //    return new int [] {(w*h + w*d + d*h) * 2, w * d * h};
        //}



    }
}