using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text.RegularExpressions;
using CodeWars;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //DifferenceVolumesCuboids.FindDifference(new int[] { 2, 2, 3 }, new int[] { 5, 4, 1 });
            //            Assert.AreEqual(new[] { 88, 48 }, SurfaceAreaVolumeBox.Get_size(4, 2, 6));
            //            Assert.AreEqual(new[] { 6, 1 }, SurfaceAreaVolumeBox.Get_size(1, 1, 1));
            //            Assert.AreEqual(new[] { 10, 2 }, SurfaceAreaVolumeBox.Get_size(1, 2, 1));
            //            Assert.AreEqual(new[] { 16, 4 }, SurfaceAreaVolumeBox.Get_size(1, 2, 2));
            //            Assert.AreEqual(new[] { 600, 1000 }, SurfaceAreaVolumeBox.Get_size(10, 10, 10));
            SurfaceAreaVolumeBox.Get_size(4, 2, 6);     //88, 48
            SurfaceAreaVolumeBox.Get_size(1, 1, 1);     //6, 1
            SurfaceAreaVolumeBox.Get_size(10, 10, 10);  //600, 1000
        }
    }
}
