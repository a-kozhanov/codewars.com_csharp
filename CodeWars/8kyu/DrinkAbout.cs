
//https://www.codewars.com/kata/drink-about/train/csharp
//https://www.codewars.com/kata/56170e844da7c6f647000063/solutions/csharp

//Drink about
//8 kyu

//Kids drink toddy.
//Teens drink coke.
//Young adults drink beer.
//Adults drink whisky.
//Make a function that receive age, and return what they drink.

//Rules:
//Children under 14 old.
//Teens under 18 old.
//Young under 21 old.
//Adults have 21 or more.

//Examples:
//PeopleWithAgeDrink(13) == "drink toddy"
//PeopleWithAgeDrink(17) == "drink coke"
//PeopleWithAgeDrink(18) == "drink beer"
//PeopleWithAgeDrink(20) == "drink beer"
//PeopleWithAgeDrink(30) == "drink whisky"

using System;

namespace CodeWars
{
    public class DrinkAbout
    {
        public static string PeopleWithAgeDrink(int old)
        {
            if (old >= 21) return "drink whisky";
            if (old >= 18) return "drink beer";
            if (old >= 14) return "drink coke";
            return "drink toddy";
        }


        //public static string PeopleWithAgeDrink(int old)
        //{
        //    return "drink " + (old < 14 ? "toddy" : old < 18 ? "coke" : old < 21 ? "beer" : "whisky");
        //}


        //public static string PeopleWithAgeDrink(int old)
        //{
        //    var drink = old < 14 ? "toddy"
        //        : old < 18 ? "coke"
        //        : old < 21 ? "beer"
        //        : "whisky";
        //    return $"drink {drink}";
        //}


        //public static string PeopleWithAgeDrink(int old)
        //{
        //    return "drink "+((old<14)?"toddy":(old<18)?"coke":(old <21)?"beer":"whisky").ToString();
        //}


        //public static string PeopleWithAgeDrink(int old)
        //{
        //    switch (old) {
        //        case int n when (n < 14): return "drink toddy";
        //        case int n when (n < 18): return "drink coke";
        //        case int n when (n < 21): return "drink beer";
        //        default: return "drink whisky";
        //    }
        //}


        //public static string PeopleWithAgeDrink(int old)
        //{
        //    return String.Format("drink {0}", old < 14 ? "toddy" : old < 18 ? "coke" : old < 21 ? "beer" : "whisky");
        //}


        //public static string PeopleWithAgeDrink(int a) => "drink " + (a<14?"toddy":a<18?"coke":a<21?"beer":"whisky");


        //public static class Kata
        //{
        //    public static string PeopleWithAgeDrink(int old) => 
        //        "drink "
        //            .AppendPartOrNot("toddy", () => old < 14)
        //            .AppendPartOrNot("coke", () => old >= 14 && old < 18)
        //            .AppendPartOrNot("beer", () => old >= 18 && old < 21)
        //            .AppendPartOrNot("whisky", () => old >= 21);

        //    private static string AppendPartOrNot(this string inputString, string value, Func<bool> testExpression) =>
        //        testExpression() == true ? $"{inputString}{value}" : inputString;
        //}


        //public static string PeopleWithAgeDrink(int a) => a < 14 ? "drink toddy" : a < 18 ? "drink coke" : a < 21 ? "drink beer" : "drink whisky";


    }
}