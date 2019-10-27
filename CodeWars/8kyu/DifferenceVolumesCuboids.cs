using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//https://www.codewars.com/kata/difference-of-volumes-of-cuboids/train/csharp
//https://www.codewars.com/kata/58cb43f4256836ed95000f97/solutions/csharp

//Difference of Volumes of Cuboids

//In this simple exercise, you will create a program that will take two lists of integers, a and b.
//Each list will consist of 3 positive integers above 0, representing the dimensions of cuboids a and b.
//You must find the difference of the cuboids' volumes regardless of which is bigger.
//For example, if the parameters passed are ([2, 2, 3], [5, 4, 1]), the volume of a is 12 and the volume of b is 20.
//Therefore, the function should return 8.
//
//Your function will be tested with pre-made examples as well as random ones.
//
//If you can, try writing it in one line of code.


namespace CodeWars
{
    public class DifferenceVolumesCuboids
    {
        public static int FindDifference(int[] a, int[] b)
        {
            return Math.Abs(a.Aggregate((x, y) => x * y) - b.Aggregate((x, y) => x * y));
        }


        //public static int FindDifference(int[] a, int[] b) => Math.Abs(a.Aggregate(1, (x,y) => x*y) - b.Aggregate(1, (x,y) => x*y));

        //public static int FindDifference(int[] a, int[] b) => Math.Abs((a[0] * a[1] * a[2]) - (b[0] * b[1] * b[2]));

        //public static int FindDifference(int[] a, int[] b)
        //{
        //    return (int)Math.Abs(a.Aggregate((vol,x) => vol*x) - b.Aggregate((vol,y) => vol*y));
        //}

        //public static int FindDifference(int[] a, int[] b) => Math.Abs(a.Aggregate(1,(s,n)=> s *n) - b.Aggregate(1,(s,n)=> s *n)) ;

        //public static int FindDifference(int[] a, int[] b)
        //{
        //    return Math.Abs(a.Aggregate((ag, x) => ag *= x) - b.Aggregate((ag, x) => ag *= x));
        //}

        //public static int FindDifference(int[] a, int[] b)
        //{
        //    var vol = new Func<int[], int>((x) => { return x[0]*x[1]*x[2]; });
        //    return Math.Abs(vol(a) - vol(b)); 
        //}

        //public static int FindDifference(int[] a, int[] b)
        //{
        //    return Math.Abs(a.Aggregate(1,(y, x) => y * x) - b.Aggregate(1,(y, x) => y * x));
        //}

    }
}
