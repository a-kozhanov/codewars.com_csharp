/*
https://www.codewars.com/kata/55c1d030da313ed05100005d/csharp

7 kyu
Building Spheres

Now that we have a Block let's move on to something slightly more complex a Sphere.

#Arguments for the constructor

radius -> integer
mass -> integer
#Methods to be defined

GetRadius()       =>  radius of the Sphere
GetMass()         =>  mass of the Sphere
GetVolume()       =>  volume of the Sphere (a double rounded to 5 place after the decimal)
GetSurfaceArea()  =>  surface area of the Sphere (a double rounded to 5 place after the decimal)
GetDensity()      =>  density of the Sphere (a double rounded to 5 place after the decimal)
##Example

Sphere ball = new Sphere(2,50)
ball.GetRadius() ->       2
ball.GetMass() ->         50
ball.GetVolume() ->       33.51032
ball.GetSurfaceArea() ->  50.26548
ball.GetDensity() ->      1.49208
Any feedback would be much appreciated
*/

using System;

namespace CodeWars
{
    public class BuildingSpheres
    {
        private readonly int _radius;
        private readonly int _mass;

        // public Sphere(int radius, int mass)
        public BuildingSpheres(int radius, int mass)
        {
            _radius = radius;
            _mass = mass;
        }

        public int GetRadius() => _radius;
        public int GetMass() => _mass;
        public double GetVolume() => Math.Round(Math.PI * Math.Pow(GetRadius(), 3) * 4 / 3, 5);
        public double GetSurfaceArea() => Math.Round(Math.PI * Math.Pow(GetRadius(), 2) * 4, 5);
        public double GetDensity() => Math.Round(GetMass() / GetVolume(), 5);
    }
}