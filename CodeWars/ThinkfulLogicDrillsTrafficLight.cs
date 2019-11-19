/*
https://www.codewars.com/kata/thinkful-logic-drills-traffic-light/train/csharp
https://www.codewars.com/kata/58649884a1659ed6cb000072/solutions/csharp

8 kyu
Thinkful - Logic Drills: Traffic light

You're writing code to control your town's traffic lights. 
You need a function to handle each change from green, to yellow, to red, and then to green again.

Complete the function that takes a string as an argument representing the current state of the light and returns a string representing the state the light should change to.

For example, update_light('green') should return 'yellow'.
*/

using System;
using System.Collections.Generic;

namespace CodeWars
{
    public class ThinkfulLogicDrillsTrafficLight
    {
        public static string UpdateLight(string current)
        {
            switch (current)
            {
                case "green": return "yellow";
                case "yellow": return "red";
                case "red": return "green";
                default: return "";
            }
        }


        //public static string UpdateLight(string current)
        //{
        //    string result;

        //    switch (current)
        //    {
        //        case "green": result = "yellow"; break;
        //        case "yellow": result = "red"; break;
        //        case "red": result = "green"; break;
        //        default:
        //            throw new ArgumentException($"{nameof(current)} is not a valid traffic light state.");
        //    }

        //    return result;
        //}



        //public static string UpdateLight(string current)
        //{
        //    return current == "green" ? "yellow" :
        //        current == "yellow" ? "red" : "green";
        //}


        //public static string UpdateLight(string current)
        //{
        //    return current == "red" ? "green" : current == "green" ? "yellow" : "red";
        //}


        //public static string UpdateLight(string current) =>
        //    new Dictionary<string, string>{
        //        {"green","yellow"}, {"yellow","red"}, {"red","green"}}[current];



        //public static string UpdateLight(string current)
        //{
        //    var colors = new[] { "green", "yellow", "red" };
        //    return (Array.IndexOf(colors, current) == colors.Length - 1) ? colors[0] : colors[Array.IndexOf(colors, current) + 1];
        //}


        //public static string UpdateLight(string current)
        //{
        //    return current == "green" ? "yellow"
        //        : current == "yellow" ? "red"
        //        : current == "red" ? "green"
        //        : "unknown";
        //}


        //static readonly List<string> a = new List<string> { "green", "yellow", "red", "green" };
        //public static string UpdateLight(string current) => a[a.IndexOf(current) + 1];



        //public static string UpdateLight(string c)
        //{
        //    //Do Some Magic
        //    return c == "green" ? "yellow" : c == "yellow" ? "red" : "green";
        //}

        //public static string UpdateLight(string current)
        //{
        //    return current.Equals("green") ? "yellow" : current.Equals("yellow") ? "red" : "green";
        //}



        //public static string UpdateLight(string current)
        //{
        //    Dictionary<string, string> lights = new Dictionary<string, string>
        //    {
        //        { "green", "yellow" },
        //        { "yellow", "red" },
        //        { "red", "green" }
        //    };
        //    return lights[current];
        //}





    }
}