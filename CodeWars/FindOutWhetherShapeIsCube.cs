
//https://www.codewars.com/kata/find-out-whether-the-shape-is-a-cube/train/csharp
//https://www.codewars.com/kata/58d248c7012397a81800005c/solutions/csharp

//Find out whether the shape is a cube
//8 kyu

//To find the volume (centimeters cubed) of a cuboid you use the formula:
//volume = Length * Width * Height
//But someone forgot to use proper record keeping, so we only have the volume, and the length of a single side!
//It's up to you to find out whether the cuboid has equal sides (= is a cube).
//Return true if the cuboid could have equal sides, return false otherwise.
//Return false for invalid numbers too (e.g volume or side is less than or equal to 0).
//Note: the sides must be integers

using System;

namespace CodeWars
{
    public class FindOutWhetherShapeIsCube
    {
        //public bool IsCube(double volume, double side)
        //{
        //    return volume > 0 ? volume == Math.Pow(side, 3) : false;
        //}

        //public bool IsCube(double volume, double side)
        //{
        //    return (Math.Pow(side, 3) == volume && side > 0);
        //}


        //public bool IsCube(double volume, double side)
        //{
        //    return volume == side * side * side && volume > 0 && side > 0 ? true : false;
        //}


        //public bool IsCube(double volume, double side)
        //{ 
        //    return side <= 0 || volume <= 0 ? false : Math.Pow(side, 3) == volume; 
        //}


        //public class CubeChecker
        //{
        //    public bool IsCube(double volume, double side) => volume > 0 && volume == (side * side * side);
        //}


        //public bool IsCube(double volume, double side)
        //{
        //    double result=Math.Pow(side,3);
        //    if((result>0)&&(result==volume)) return true;
        //    return false;
        //}


    }
}