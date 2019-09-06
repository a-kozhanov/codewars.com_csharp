
//https://www.codewars.com/kata/grasshopper-grade-book/train/csharp
//https://www.codewars.com/kata/55cbd4ba903825f7970000f5/solutions/csharp

//Grasshopper - Grade book

//Grade book
//Complete the function so that it finds the mean of the three scores passed to it and returns the letter value associated with that grade.

//Numerical Score Letter Grade
//90 <= score <= 100	'A'
//80 <= score< 90	'B'
//70 <= score< 80	'C'
//60 <= score< 70	'D'
//0 <= score< 60	'F'
//Tested values are all between 0 and 100. Theres is no need to check for negative values or values greater than 100.


using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class GrasshopperGradeBook
    {
        public static char GetGrade(int s1, int s2, int s3)
        {
            var array = new[] { s1, s2, s3 }.Average();

            if (array >= Math.Min(90, 100)) return 'A';
            if (array >= Math.Min(80, 90)) return 'B';
            if (array >= Math.Min(70, 80)) return 'C';
            if (array >= Math.Min(60, 70)) return 'D';
            return 'F';
        }

        //public static char GetGrade(int s1, int s2, int s3)
        //{
        //    var s = (s1 + s2 + s3) / 3;
        //    if (60 > s) return 'F';
        //    if (70 > s) return 'D';
        //    if (80 > s) return 'C';
        //    if (90 > s) return 'B';
        //    return 'A';
        //}


        //public static char GetGrade(int s1, int s2, int s3)
        //{
        //    var m = (s1 + s2 + s3) / 3.0;
        //    return m >= 90 ? 'A' : m >= 80 ? 'B' : m >= 70 ? 'C' : m >= 60 ? 'D' : 'F';
        //}


        //public static char GetGrade(int s1, int s2, int s3)
        //{
        //    int score = (s1 + s2 + s3) / 3;
        //    if (90 <= score) { return 'A'; }
        //    else if (80 <= score) { return 'B'; }
        //    else if (70 <= score) { return 'C'; }
        //    else if (60 <= score) { return 'D'; }
        //    else if (60 >= score) { return 'F'; }
        //    else { return 'N'; }
        //}


        //public static char GetGrade(int s1, int s2, int s3)
        //{
        //    int s = (s1 + s2 + s3) / 3;
        //    return s >= 60 ? (char)(74 - s / 10 + s / 100) : 'F';
        //}


        //public static char GetGrade(int s1, int s2, int s3)
        //{
        //    int s = (s1 + s2 + s3) / 3;

        //    return (s >= 90 && s <= 100) ? 'A' : (s >= 80 && s < 90) ? 'B' : (s >= 70 && s < 80) ? 'C' : (s >= 60 && s < 80) ? 'D' : 'F';

        //}


        //public static char GetGrade(int s1, int s2, int s3)
        //{
        //    double avg = (s1 + s2 + s3) / 3;
        //    return avg >= 90 ? 'A' :
        //        avg >= 80 ? 'B' :
        //        avg >= 70 ? 'C' :
        //        avg >= 60 ? 'D' :
        //        'F';
        //}


        //public static char GetGrade(int s1, int s2, int s3)
        //{
        //    var avg = (s1 + s2 + s3) / 3;
        //    if (avg < 60) return 'F';
        //    else if (avg < 70) return 'D';
        //    else if (avg < 80) return 'C';
        //    else if (avg < 90) return 'B';
        //    return 'A';
        //}


        //public static char GetGrade(int s1, int s2, int s3)
        //{
        //    var m = (s1 + s2 + s3) / 3;
        //    if (m >= 90) return 'A';
        //    if (m >= 80) return 'B';
        //    if (m >= 70) return 'C';
        //    if (m >= 60) return 'D';
        //    return 'F';
        //}


        //public static char GetGrade(params int[] grades)
        //{
        //    var dict = new Dictionary<int, char>
        //    {
        //        { 90, 'A' },
        //        { 80, 'B' },
        //        { 70, 'C' },
        //        { 60, 'D' },
        //        { 0, 'F' },
        //    };

        //    return dict.First(e => grades.Average() >= e.Key).Value;
        //}


        //public static char GetGrade(int s1, int s2, int s3)
        //{
        //    int mean = (s1 + s2 + s3) / 3;

        //    if (mean > 89) return 'A';
        //    if (mean > 79) return 'B';
        //    if (mean > 69) return 'C';
        //    if (mean > 59) return 'D';
        //    return 'F';
        //}





    }
}