

//https://www.codewars.com/kata/calculate-bmi/train/csharp
//https://www.codewars.com/kata/57a429e253ba3381850000fb/solutions/csharp

//8 kyu
//Calculate BMI

//Write function bmi that calculates body mass index (bmi = weight / height ^ 2).
//if bmi <= 18.5 return "Underweight"
//if bmi <= 25.0 return "Normal"
//if bmi <= 30.0 return "Overweight"
//if bmi > 30 return "Obese"

using System;

namespace CodeWars
{
    public class CalculateBMI
    {
        public static string Bmi(double weight, double height)
        {
            var bmi = weight / (height * height);
            if (bmi <= 18.5) return "Underweight";
            if (bmi <= 25.0) return "Normal";
            if (bmi <= 30.0) return "Overweight";
            return "Obese";
        }


        //public static string Bmi(double weight, double height)
        //{
        //    var bmi = Math.Round(weight / ( height * height ),1);
        //    return
        //        bmi <= 18.5 ? "Underweight" :
        //        bmi <= 25 ? "Normal" :
        //        bmi <= 30 ? "Overweight" : "Obese";
        //}



        //public static string Bmi(double weight, double height)
        //{
        //    var bmi = weight / (height * height);

        //    if(bmi<=18.5) return "Underweight";
        //    if(bmi<=25) return "Normal";
        //    if(bmi<=30) return "Overweight";
        //    return "Obese";
        //}

        //public static string Bmi(double weight, double height) {
        //    double bmi = weight / (height * height);
        //    if(bmi <= 18.5) return "Underweight";
        //    else if(bmi <= 25) return "Normal";
        //    else if(bmi <= 30) return "Overweight";
        //    else return "Obese";
        //}



        //public static string Bmi(double weight, double height)
        //{
        //    double bmi = weight/(height*height);

        //    if (bmi <= 18.5d) return "Underweight";
        //    if (bmi <= 25.0d) return "Normal";
        //    if (bmi <= 30.0d) return "Overweight";
        //    return "Obese";
        //}




    }

}