/*
https://www.codewars.com/kata/grader/train/csharp
https://www.codewars.com/kata/53d16bd82578b1fb5b00128c/solutions/csharp

8 kyu
Grader

Create a function that takes a number as an argument and returns a grade based on that number.

Score	Grade
Anything greater than 1 or less than 0.6	"F"
0.9 or greater	"A"
0.8 or greater	"B"
0.7 or greater	"C"
0.6 or greater	"D"
Examples:

grader(0)   should be "F"
grader(1.1) should be "F"

grader(0.9) should be "A"
grader(0.8) should be "B"
grader(0.7) should be "C"
grader(0.6) should be "D"
*/


using System;

namespace CodeWars
{
    public class KataGrader
    {
        public static char Grader(double score)
        {
            if (score > 1 || score < 0.6) return 'F';
            if (score >= 0.9) return 'A';
            if (score >= 0.8) return 'B';
            if (score >= 0.7) return 'C';
            return 'D';
        }


        //public static char Grader(double v) => v > 1 || v < 0.6 ? 'F' : v >= 0.9 ? 'A' : v >= 0.8 ? 'B' : v >= 0.7 ? 'C' : 'D';


        //public static char Grader(double score)
        //{
        //    return score > 1.0 ? 'F'
        //        : score >= 0.9 ? 'A'
        //        : score >= 0.8 ? 'B'
        //        : score >= 0.7 ? 'C'
        //        : score >= 0.6 ? 'D'
        //        : 'F';
        //}


        //public static char Grader(double score)
        //{
        //    switch ((int)(score*10))
        //    {
        //        case 6: return 'D';
        //        case 7: return 'C';
        //        case 8: return 'B';
        //        case 9: return 'A';
        //        default: return (score == 1.0) ? 'A' : 'F';
        //    }
        //}



        //public static char Grader(double score)
        //{
        //    if (score > 1) { return 'F'; }
        //    else if (score >= 0.9) { return 'A'; }
        //    else if (score >= 0.8) { return 'B'; }
        //    else if (score >= 0.7) { return 'C'; }
        //    else if (score >= 0.6) { return 'D'; }
        //    else { return 'F'; }
        //}



        //public static char Grader(double n)
        //{
        //    return n > 1 ? 'F':
        //        n >= .9 ? 'A' :
        //        n >= .8 ? 'B' :
        //        n >= .7 ? 'C' :
        //        n >= .6 ? 'D' :
        //        'F';
        //}


        //public static char Grader(double score)
        //{
        //    return score < 0.6 ? 'F'
        //        : score < 0.7 ? 'D'
        //        : score < 0.8 ? 'C'
        //        : score < 0.9 ? 'B'
        //        : score <= 1 ? 'A' : 'F';
        //}


        //public static char Grader(double score)
        //{
        //    if (score <= 1)
        //    {
        //        if (0.9d <= score) return 'A';
        //        if (0.8d <= score) return 'B';
        //        if (0.7d <= score) return 'C';
        //        if (0.6d <= score) return 'D';
        //    }

        //    return 'F';
        //}

        //public static char Grader(double score)
        //{
        //    if (score > 1 | score < 0.6) return 'F';
        //    if (score >= 0.9 & score <= 1) return 'A';
        //    if (score >= 0.8) return 'B';
        //    if (score >= 0.7) return 'C';
        //    if (score >= 0.6) return 'D';
        //    return ' ';
        //}


        //public static char Grader(double score)
        //{
        //    if (score >= 0.9 && score <= 1) return 'A';
        //    if (score >= 0.8 && score <= 1) return 'B';
        //    if (score >= 0.7 && score <= 1) return 'C';
        //    if (score >= 0.6 && score <= 1) return 'D';
        //    return 'F';
        //}





    }
}