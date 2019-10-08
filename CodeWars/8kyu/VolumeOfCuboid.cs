
//https://www.codewars.com/kata/volume-of-a-cuboid/train/csharp
//https://www.codewars.com/kata/58261acb22be6e2ed800003a/solutions/csharp

//Volume of a Cuboid
//8 kyu

//Bob needs a fast way to calculate the volume of a cuboid with three values: length, width and the height of the cuboid.
//Write a function to help Bob with this calculation.

namespace CodeWars
{
    public class VolumeOfCuboid
    {
        public static double getVolumeOfCubiod(double length, double width, double height)
        {
            return length * width * height;
        }
    }
}