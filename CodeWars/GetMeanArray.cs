
//https://www.codewars.com/kata/get-the-mean-of-an-array/train/csharp
//https://www.codewars.com/kata/563e320cee5dddcf77000158/solutions/csharp

//Get the mean of an array

//It's the academic year's end, fateful moment of your school report.The averages must be calculated.All the students come to you and entreat you to calculate their average for them.Easy ! You just need to write a script.
//Return the average of the given array rounded down to its nearest integer.
//The array will never be empty.

using System;
using System.Linq;

namespace CodeWars
{
    public class GetMeanArray
    {
        public static int GetAverage(int[] marks)
        {
            return (int)marks.Average();
        }

        //public static int GetAverage(int[] marks)
        //{
        //    return marks.Sum() / marks.Length;
        //}



        //public static int GetAverage(int[] marks)
        //{
        //    long marksSum = 0;
        //    foreach (int mark in marks)
        //    {
        //        marksSum += mark;
        //    }
        //    long result = marksSum / (long)marks.Length;

        //    return (int)result;
        //}


        //public static int GetAverage(int[] marks)
        //{
        //    var result = 0;

        //    foreach (var val in marks)
        //    {
        //        result += val;
        //    }

        //    return result / marks.Length;
        //}


        //public static int GetAverage(int[] marks)
        //{
        //    double now = marks.Average();
        //    int then = (int)Math.Floor(now);
        //    return then;

        //}

        //public static int GetAverage(int[] marks)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < marks.Length; i++)
        //    {
        //        sum += marks[i];
        //    }

        //    return marks.Length == 0 ? 0 : sum / marks.Length;
        //}

        //public static int GetAverage(int[] marks)
        //{
        //    int sum = 0, count = 0;
        //    foreach (int elem in marks)
        //    {
        //        sum += elem;
        //        count++;
        //    }

        //    return sum / count;
        //}


        //public static int GetAverage(int[] marks)
        //{
        //    int total = marks.Sum();
        //    int length = marks.Length;
        //    return total / length;
        //}

        //public static int GetAverage(int[] marks)
        //{
        //    int average = 0;
        //    for (int i = 0; i <= marks.Length - 1; i++)
        //    {
        //        average += marks[i];
        //    }
        //    return average / marks.Length;
        //}

    }
}