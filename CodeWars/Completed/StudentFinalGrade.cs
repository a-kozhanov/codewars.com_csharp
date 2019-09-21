

//https://www.codewars.com/kata/students-final-grade/train/csharp
//https://www.codewars.com/kata/5ad0d8356165e63c140014d4/solutions/csharp

//Student's Final Grade

//Create a function finalGrade, which calculates the final grade of a student depending on two parameters: a grade for the exam and a number of completed projects.
//This function should take two arguments: exam - grade for exam (from 0 to 100); projects - number of completed projects (from 0 and above);
//This function should return a number (final grade). There are four types of final grades:
//100, if a grade for the exam is more than 90 or if a number of completed projects more than 10.
//90, if a grade for the exam is more than 75 and if a number of completed projects is minimum 5.
//75, if a grade for the exam is more than 50 and if a number of completed projects is minimum 2.
//0, in other cases
//Examples:
//FinalGrade(100, 12);  // 100
//FinalGrade(99, 0);    // 100
//FinalGrade(10, 15);   // 100
//FinalGrade(85, 5);    // 90
//FinalGrade(55, 3);    // 75

//FinalGrade(55, 0);    // 0
//FinalGrade(20, 2);    // 0
//*Use Comparison and Logical Operators.

using System;

namespace CodeWars
{
    public class StudentFinalGrade
    {
        public static int FinalGrade(int exam, int projects)
        {
            if (exam > 90 || projects > 10) return 100;
            if (exam > 75 && projects >= 5) return 90;
            if (exam > 50 && projects >= 2) return 75;
            return 0;
        }


        //public static int FinalGrade(int exam, int projects)
        //{
        //    if (exam > 90 || projects > 10) return 100;
        //    if (exam > 75 && projects > 4) return 90;
        //    if (exam > 50 && projects > 1) return 75;
        //    return 0;
        //}


        //public static int FinalGrade(int exam, int projects)
        //{
        //    return
        //        exam > 90 | projects > 10 ? 100 :
        //        exam > 75 & projects >= 5 ? 90 :
        //        exam > 50 & projects >= 2 ? 75 :
        //        0;
        //}


        //public static int FinalGrade(int exam, int projects)
        //{
        //    int grade = 0;

        //    if (exam > 90 || projects > 10)
        //        grade = 100;
        //    else if (exam > 75 && projects >= 5)
        //        grade = 90;
        //    else if (exam > 50 && projects >= 2)
        //        grade = 75;

        //    return grade;
        //}


        //public static int FinalGrade(int exam, int projects)
        //{
        //    return (exam > 90 || projects > 10) ? 100 : ((exam > 75 && exam <= 90) && projects >= 5) ? 90 : ((exam > 50) && (projects >= 2)) ? 75 : 0;
        //}

        //public static int FinalGrade(int exam, int projects)
        //{
        //    return exam > 90 ? 100 : projects > 10 ? 100 : exam > 75 && projects >= 5 ? 90 : exam > 50 && projects >= 2 ? 75 : 0;
        //}




    }
}