//https://www.codewars.com/kata/age-range-compatibility-equation/train/csharp
//https://www.codewars.com/kata/5803956ddb07c5c74200144e/solutions/csharp

//8 kyu
//Age Range Compatibility Equation

/*
Everybody knows the classic "half your age plus seven" dating rule that a lot of people follow (including myself). It's the 'recommended' age range in which to date someone.

minimum age <= your age <= maximum age

#Task

Given an integer (1 <= n <= 100) representing a person's age, return their minimum and maximum age range.

This equation doesn't work when the age <= 14, so use this equation instead:

min = age - 0.10 * age
max = age + 0.10 * age
You should floor all your answers so that an integer is given instead of a float (which doesn't represent age). Return your answer in the form [min]-[max]

##Examples:

age = 27   =>   20-40
age = 5    =>   4-5
age = 17   =>   15-20
*/

namespace CodeWars
{
    public class AgeRangeCompatibilityEquation
    {
        public static string DatingRange(int age)
        {
            return age <= 14 ? $"{(int)(age - 0.10 * age)}-{(int)(age + 0.10 * age)}" : $"{age / 2 + 7}-{(age - 7) * 2}";
        }


        //public static string DatingRange(int age)
        //{
        //    int min = age <= 14 ? (int)(age - 0.10 * age) : (int)(age / 2 + 7);
        //    int max = age <= 14 ? (int)(age + 0.10 * age) : (int)((age - 7) * 2.0);
        //    return $"{min}-{max}";
        //}


        //public static string DatingRange(int age)
        //{
        //    return age > 14 ? $"{age / 2 + 7}-{(age - 7) * 2}"
        //        : $"{(int)(age * 0.9)}-{(int)(age * 1.1)}";
        //}

        //public static string DatingRange(int age)
        //{
        //    int min, max;

        //    if (age <= 14)
        //    {
        //        min = (int)(age - 0.1f * age);
        //        max = (int)(age + 0.1f * age);
        //    }
        //    else
        //    {
        //        min = (int)(age / 2f + 7f);
        //        max = (age - 7) * 2;
        //    }
        //    return $"{min}-{max}";
        //}

    }
}