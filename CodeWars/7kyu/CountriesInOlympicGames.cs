/*
https://www.codewars.com/kata/566df9b0911626095b000013/csharp

7 kyu
Countries in Olympic Games

#Order Countries in Olympics Games

In Olympic games countries are ranked based on the gold, and then silver, and then bronze medals.

You get a list of countries in form of a dictionary; the key is the country name, 
and the value is a string that indicate the number of gold, silver and bronze medals.

For example in this list:

Dictionary<string, string> list = new Dictionary<string, string>()
            {
                {"China","54,32,44"},
                {"Korea","55,33,45"},
                {"Iraq","54,33,45"},
                {"Iran","54,33,45"},
                {"Norway","56,32,45"},
                {"Finland","55,34,45"}
            };
China has 54 gold medals, 32 silver medals and 44 bronze medals.

The result should be a string ordering the countries and separating them by - In abovementioned example the output should be:

Norway-Finland-Korea-Iran-Iraq-China

If two counties get similar medals, then you sort them based on alphabetical order.
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class CountriesInOlympicGames
    {
        public static string OrderCountries(Dictionary<string, string> listOfCountries)
        {
            return string.Join("-", listOfCountries
                .Select(n => new {n.Key, Medals = n.Value.Split(",").Aggregate(0, (a, b) => a * 1000 + int.Parse(b))})
                .OrderByDescending(x => x.Medals)
                .ThenBy(x => x.Key)
                .Select(x => x.Key));

            // return string.Join("-",
            //     listOfCountries.Select(x => new {x.Key, Medals = x.Value.Split(",").Select(int.Parse).ToArray()})
            //         .OrderByDescending(o => o.Medals[0])
            //         .ThenByDescending(o => o.Medals[1])
            //         .ThenByDescending(o => o.Medals[2])
            //         .ThenBy(o => o.Key)
            //         .Select(x => x.Key));


            // return string.Join("-",
            //     listOfCountries
            //         .OrderByDescending(country =>
            //             country.Value.Split(',').Aggregate(0, (x, y) => x * 1000 + int.Parse(y)))
            //         .ThenBy(country => country.Key)
            //         .Select(country => country.Key));


            // return string.Join("-", listOfCountries
            //     .Select(c => new {Name = c.Key, Medals = c.Value.Split(',')})
            //     .OrderByDescending(c => int.Parse(c.Medals[0]))
            //     .ThenByDescending(c => int.Parse(c.Medals[1]))
            //     .ThenByDescending(c => int.Parse(c.Medals[2]))
            //     .ThenBy(c => c.Name)
            //     .Select(c => c.Name));
        }
    }
}