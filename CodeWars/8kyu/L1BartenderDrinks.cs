/*
https://www.codewars.com/kata/l1-bartender-drinks/train/csharp
https://www.codewars.com/kata/568dc014440f03b13900001d/solutions/csharp

8 kyu
L1: Bartender, drinks!

Write a function getDrinkByProfession/get_drink_by_profession() that receives as input parameter a string, and produces outputs according to the following table:

Input	Output
"Jabroni"	"Patron Tequila"
"School Counselor"	"Anything with Alcohol"
"Programmer"	"Hipster Craft Beer"
"Bike Gang Member"	"Moonshine"
"Politician"	"Your tax dollars"
"Rapper"	"Cristal"
*anything else*	"Beer"
Note: anything else is the default case: if the input to the function is not any of the values in the table, then the return value should be "Beer."

Make sure you cover the cases where certain words do not show up with correct capitalization. For example, getDrinkByProfession("pOLitiCIaN") should still return "Your tax dollars".
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class L1BartenderDrinks
    {
        public static string GetDrinkByProfession(string p)
        {
            switch (p.ToLower())
            {
                case "jabroni": return "Patron Tequila";
                case "school counselor": return "Anything with Alcohol";
                case "programmer": return "Hipster Craft Beer";
                case "bike gang member": return "Moonshine";
                case "politician": return "Your tax dollars";
                case "rapper": return "Cristal";
                default: return "Beer";
            }
        }

        //public static string GetDrinkByProfession(string p)
        //{
        //    return new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase)
        //    {
        //        { "Jabroni", "Patron Tequila" },
        //        { "School Counselor", "Anything with Alcohol" },
        //        { "Programmer", "Hipster Craft Beer" },
        //        { "Bike Gang Member", "Moonshine" },
        //        { "Politician", "Your tax dollars" },
        //        { "Rapper", "Cristal" }
        //    }.TryGetValue(p, out string value) ? value : "Beer";
        //}


        //public static string GetDrinkByProfession(string input)
        //{
        //    string[] p = new string[] { "Jabroni", "School Counselor", "Programmer", "Bike Gang Member", "Politician", "Rapper" };
        //    string[] d = new string[] { "Beer", "Patron Tequila", "Anything with Alcohol", "Hipster Craft Beer", "Moonshine", "Your tax dollars", "Cristal", "Beer" };
        //    return d[p.TakeWhile(t => !new Regex(t, RegexOptions.IgnoreCase).IsMatch(input)).Count() + 1];
        //}


        //public static string GetDrinkByProfession(string p)
        //{
        //    string pl = p.ToLower();

        //    if (pl == "jabroni") return "Patron Tequila";
        //    if (pl == "school counselor") return "Anything with Alcohol";
        //    if (pl == "programmer") return "Hipster Craft Beer";
        //    if (pl == "bike gang member") return "Moonshine";
        //    if (pl == "politician") return "Your tax dollars";
        //    if (pl == "rapper") return "Cristal";

        //    return "Beer";
        //}


        //public static string GetDrinkByProfession(string p)
        //{
        //    Dictionary<string, string> drinks = new Dictionary<string, string>();
        //    drinks.Add("jabroni", "Patron Tequila");
        //    drinks.Add("school counselor", "Anything with Alcohol");
        //    drinks.Add("programmer", "Hipster Craft Beer");
        //    drinks.Add("bike gang member", "Moonshine");
        //    drinks.Add("politician", "Your tax dollars");
        //    drinks.Add("rapper", "Cristal");

        //    if (drinks.ContainsKey(p.ToLower()))
        //        return drinks[p.ToLower()];
        //    else
        //        return "Beer";
        //}


        //public static string GetDrinkByProfession(string p)
        //{
        //    var drink = new Dictionary<string, string>();
        //    drink["jabroni"] = "Patron Tequila";
        //    drink["school counselor"] = "Anything with Alcohol";
        //    drink["programmer"] = "Hipster Craft Beer";
        //    drink["bike gang member"] = "Moonshine";
        //    drink["politician"] = "Your tax dollars";
        //    drink["rapper"] = "Cristal";
        //    if (drink.ContainsKey(p.ToLower()))
        //        return drink[p.ToLower()];
        //    return "Beer";
        //}


    }
}