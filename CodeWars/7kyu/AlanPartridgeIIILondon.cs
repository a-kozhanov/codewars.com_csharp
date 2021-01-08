/*
https://www.codewars.com/kata/580a41b6d6df740d6100030c/csharp

7 kyu
Alan Partridge III - London

Ever the learned traveller, Alan Partridge has pretty strong views on London:

"Go to London. I guarantee you'll either be mugged or not appreciated.
Catch the train to London, stopping at Rejection, Disappointment, Backstabbing Central and Shattered Dreams Parkway."
Your job is to check that the provided list of stations contains all of the stops Alan mentions. There will be other stations in the array. Example:

['Rejection', 'Disappointment', 'Backstabbing Central', 'Shattered Dreams Parkway']
If the stations all appear, return 'Smell my cheese you mother!', if not, return 'No, seriously, run. You will miss it.'.

Other katas in this series:

Alan Partridge I - Partridge Watch
Alan Partridge II - Apple Turnover
*/


using System;
using System.Linq;

namespace CodeWars
{
    public class AlanPartridgeIIILondon
    {
        public static string Alan(string[] x)
        {
            // string[] stations = {"Rejection", "Disappointment", "Backstabbing Central", "Shattered Dreams Parkway"};
            // return x.Distinct().Count(s => stations.Contains(s)) == 4
            //     ? "Smell my cheese you mother!"
            //     : "No, seriously, run. You will miss it.";

            // string[] stations = {"Rejection", "Disappointment", "Backstabbing Central", "Shattered Dreams Parkway"};
            // return stations.Intersect(x).SequenceEqual(stations)
            //     ? "Smell my cheese you mother!"
            //     : "No, seriously, run. You will miss it.";

            // return !new[] {"Rejection", "Disappointment", "Backstabbing Central", "Shattered Dreams Parkway"}.Except(x).Any()
            //     ? "Smell my cheese you mother!"
            //     : "No, seriously, run. You will miss it.";

            return new[]
                {"Rejection", "Disappointment", "Backstabbing Central", "Shattered Dreams Parkway"}.All(x.Contains)
                ? "Smell my cheese you mother!"
                : "No, seriously, run. You will miss it.";
        }
    }
}