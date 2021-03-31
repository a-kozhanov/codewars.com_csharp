/*
https://www.codewars.com/kata/57a72cb872292dc43100000c/csharp

7 kyu
Airport itinerary

Travel itinerary
When you travel around the world you pass though different airports.

TRN -> FCO -> JFK
And then return back to home

JFK - TRN
In order to propose the unique list of airports that your trip uses we have to create an itinerary feature that can compress the list of airports including only the list of unique in/out combination.

For example, a trip with:

[TRN-FCO] [FCO-JFK] [JFK-TRN]
Should be represented as:

TRN-FCO-JFK-TRN
That is the unique list of airport steps.

Now in our database we save the travel as a list of objects with in/out properties and you will receive that list always sorted in the right way.

[
  {in: "TRN", out: "FCO"},
  {in: "FCO", out: "JFK"},
  {in: "JFK", out: "FCO"}
]
Now we have to create a helper function itinerary for JS that extract the unique airport list:

travel = itinerary([
  {in: "TRN", out: "FCO"},
  {in: "FCO", out: "JFK"},
  {in: "JFK", out: "FCO"}
]); // TRN-FCO-JFK-FCO
Or a helper class Route for C#/C++:

public class Route
{
  public string In;
  public string Out;
}
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class AirportItinerary
    {
        public class Route
        {
            public string In;
            public string Out;
        }

        public static string Itinerary(Route[] travel)
        {
            return travel.SelectMany(r => new[] {r.In, r.Out}).Aggregate((x, y) => x.EndsWith(y) ? x : $"{x}-{y}");
            //return travel.SelectMany(x => new string[2] {x.In, x.Out}).Aggregate((a, b) => a.EndsWith(b) ? a : $"{a}-{b}");
            //return travel.SelectMany(r => new[] {r.In, r.Out}).Aggregate((a, b) => a.EndsWith(b) ? a : $"{a}-{b}");
            //return travel.Aggregate("", (a, b) => a == "" ? $"{b.In}-{b.Out}" : $"{a}-{(a.EndsWith(b.In) ? b.Out : $"{b.In}-{b.Out}")}");

            // List<string> airports = new List<string>();
            // foreach (var route in travel)
            // {
            //     if (airports.Count == 0 || route.In != airports.Last())
            //         airports.Add(route.In);
            //     airports.Add(route.Out);
            // }
            //
            // return string.Join("-", airports);
        }
    }
}