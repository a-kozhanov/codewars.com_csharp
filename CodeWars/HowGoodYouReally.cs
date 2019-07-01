using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


//https://www.codewars.com/kata/how-good-are-you-really/train/csharp
//https://www.codewars.com/kata/5601409514fc93442500010b/solutions/csharp

//How good are you really?

//There was a test in your class and you passed it.Congratulations!
//But you're an ambitious person. You want to know if you're better than the average student in your class.
//You receive an array with your peers' test scores. Now calculate the average and compare your score!
//Return True if you're better, else False!
//Note:
//Your points are not included in the array of your class's points. For calculating the average point you may add your point to the given array!



namespace CodeWars
{
    public class HowGoodYouReally
    {
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            List<int> points = new List<int> { YourPoints };
            points.AddRange(ClassPoints);
            return points.Average() < YourPoints;
        }

        //public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        //{
        //    return YourPoints > ClassPoints.Average();
        //}

        //public static bool BetterThanAverage(int[] classPoints, int yourPoints)
        //{
        //    int average = (classPoints.Sum() + yourPoints) / (classPoints.Length + 1);
        //    return yourPoints > average;
        //}

        //public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        //{
        //    return YourPoints > ClassPoints.Average();
        //}

        //public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        //{
        //    //Insert brain here
        //    return (YourPoints > (ClassPoints.Sum() / ClassPoints.Length)) ? true : false;
        //}

        //public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        //{
        //    return ClassPoints.Average() <= YourPoints;
        //}

        //public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        //{
        //    List<int> pointList = ClassPoints.ToList();
        //    pointList.Add(YourPoints);
        //    return YourPoints > pointList.Average() ? true : false;
        //}

    } 
}
