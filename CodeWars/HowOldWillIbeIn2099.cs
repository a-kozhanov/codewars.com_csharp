/*
https://www.codewars.com/kata/how-old-will-i-be-in-2099/train/csharp
https://www.codewars.com/kata/5761a717780f8950ce001473/solutions/csharp

8 kyu
How old will I be in 2099?

Philip's just turned four and he wants to know how old he will be in various years in the future such as 2090 or 3044. 
His parents can't keep up calculating this so they've begged you to help them out by writing a programme that can answer Philip's endless questions.

Your task is to write a function that takes two parameters: the year of birth and the year to count years in relation to. 
As Philip is getting more curious every day he may soon want to know how many years it was until he would be born, 
so your function needs to work with both dates in the future and in the past.

Provide output in this format: For dates in the future: "You are ... year(s) old." 
For dates in the past: "You will be born in ... year(s)." 
If the year of birth equals the year requested return: "You were born this very year!"

"..." are to be replaced by the number, followed and proceeded by a single space. 
Mind that you need to account for both "year" and "years", depending on the result.

Good Luck!
*/


using System;

namespace CodeWars
{
    public class HowOldWillIbeIn2099
    {
        public static string CalculateAge(int birth, int yearTo)
        {
            var old= yearTo - birth;
            switch (old)
            {
                case 0:
                    return "You were born this very year!";
                case 1:
                    return "You are 1 year old.";
                case -1:
                    return "You will be born in 1 year.";
                default:
                    return old < -1 ? $"You will be born in {-old} years." : $"You are {old} years old.";
            }
        }
    }
}


// public static string CalculateAge(int birth, int yearTo) 
// {
// if(birth == yearTo)
// return "You were born this very year!";
//     
// int x = yearTo - birth;
// string s = Math.Abs(x) > 1 ? "s" : "";
//       
//     return x > 0 ? $"You are {x} year{s} old." : $"You will be born in {-x} year{s}.";
// }


// public static string CalculateAge(int birth, int yearTo) 
// {
// if (birth == yearTo) return $"You were born this very year!";
// if (yearTo - birth == 1 || yearTo - birth == -1 ) return (yearTo - birth > 0)? $"You are {yearTo - birth} year old." : $"You will be born in {birth - yearTo} year.";
// return (yearTo - birth > 0)? $"You are {yearTo - birth} years old." : $"You will be born in {birth - yearTo} years.";
// }