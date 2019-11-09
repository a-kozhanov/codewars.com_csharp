
/*
https://www.codewars.com/kata/get-planet-name-by-id/train/csharp
https://www.codewars.com/kata/515e188a311df01cba000003/solutions/csharp

8 kyu
Get Planet Name By ID

The function is not returning the correct values. Can you figure out why?
getPlanetName(3); // should return 'Earth'
*/

using System.Collections.Generic;

namespace CodeWars
{
    public class KataGetPlanetNameByID
    {
        public static string GetPlanetName(int id)
        {
            switch (id)
            {
                case 1: return "Mercury";
                case 2: return "Venus";
                case 3: return "Earth";
                case 4: return "Mars";
                case 5: return "Jupiter";
                case 6: return "Saturn";
                case 7: return "Uranus";
                case 8: return "Neptune";
                default: return "";
            }
        }



        //public static string GetPlanetName(int id) {
        //    switch(id) {
        //        case 1: return "Mercury";
        //        case 2: return "Venus";
        //        case 3: return "Earth";
        //        case 4: return "Mars";
        //        case 5: return "Jupiter";
        //        case 6: return "Saturn";
        //        case 7: return "Uranus";
        //        case 8: return "Neptune";
        //        default: return null;
        //    }
        //}


        //private static readonly string[] planets = new string[] { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"};
        //public static string GetPlanetName(int id)
        //{
        //    return planets[id - 1];
        //}


        //enum Planet
        //{
        //    Mercury = 1, Venus, Earth, Mars,
        //    Jupiter, Saturn, Uranus, Neptune
        //};

        //public static string GetPlanetName(int id)
        //{
        //    var e = (Planet) id;
        //    return e.ToString();
        //}


        //public static string GetPlanetName(int id) => planets[id];

        //private static readonly Dictionary<int, string> planets = new Dictionary<int, string>()
        //{
        //    { 1, "Mercury" },
        //    { 2, "Venus" },
        //    { 3, "Earth" },
        //    { 4, "Mars" },
        //    { 5, "Jupiter" },
        //    { 6, "Saturn" },
        //    { 7, "Uranus" },
        //    { 8, "Neptune" }
        //};


        //public static string GetPlanetName(int id)
        //{
        //    return new[] {"Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune", "Unknown"}[id - 1];
        //}


    }
}