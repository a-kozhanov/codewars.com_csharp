//https://www.codewars.com/kata/total-amount-of-points/train/csharp
//https://www.codewars.com/kata/5bb904724c47249b10000131/solutions/csharp

//Total amount of points

//Our football team finished the championship. The result of each match look like "x:y". Results of all matches are recorded in the collection.
//For example: ["3:1", "2:2", "0:1", ...]
//Write a function that takes such collection and counts the points of our team in the championship. Rules for counting points for each match:
//if x>y - 3 points
//if x<y - 0 point
//if x=y - 1 point
//Notes:
//there are 10 matches in the championship
//0 <= x <= 4
//0 <= y <= 4

using System;
using System.Linq;

namespace CodeWars
{
    public class TotalAmountOfPoints
    {
        public static int TotalPoints(string[] games)
        {
            //return games.Sum((x) => (x[0] < x[2]) ? 0 : (x[0] == x[2]) ? 1 : 3);
            //return games.Sum(s => s[0] < s[2] ? 0 : s[0] == s[2] ? 1 : 3);
            //return games.Select(x => x[0] == x[2] ? 1 : x[0] > x[2] ? 3 : 0).Sum();
            //return games.Select(x => x[0] - x[2] == 0 ? 1 : x[0] - x[2] > 0 ? 3 : 0).Sum();
            //return 3 * games.Count(i => i[0] > i[2]) + games.Count(i => i[0] == i[2]);

            var result = 0;
            foreach (var game in games)
            {
                var s = game.Split(":").Select(int.Parse).ToArray();
                if (s[0] > s[1]) result += 3;
                if (s[0] == s[1]) result += 1;
            }

            return result;
        }


        //public static int TotalPoints(string[] games)
        //{
        //    int total = 0;
        //    foreach (string game in games)
        //    {
        //        if (game[0] > game[2])
        //            total += 3;
        //        else if (game[0] == game[2])
        //            total += 1;
        //    }
        //    return total;
        //}


        //public static int TotalPoints(string[] games)
        //{
        //    return games.Select(x =>
        //    {
        //        var values = x.Split(':').Select(int.Parse);

        //        if (values.ElementAt(0) > values.ElementAt(1)) return 3;

        //        return values.ElementAt(0) < values.ElementAt(1)
        //            ? 0
        //            : 1;
        //    }).Sum(x => x);
        //}


        //public static int TotalPoints(string[] games) =>
        //    games.Select(e => (x: e[0], y: e[2])).Select(e => e.x > e.y ? 3 : e.x == e.y ? 1 : 0).Sum();


        //public static int TotalPoints(string[] games)
        //{
        //    var points = 0;
        //    foreach (var item in games)
        //    {
        //        points += (item[0] > item[2]) ? 3 : (item[0] == item[2]) ? 1 : 0;
        //    }
        //    return points;
        //}


        //public static int TotalPoints(string[] games)
        //{
        //    return games.Where(x => x[0] > x[2]).Count() * 3 + games.Where(y => y[0] == y[2]).Count();
        //}


        //public static int TotalPoints(string[] games) 
        //{  
        //    return games.Sum((x) => (x[0] < x[2]) ? 0 : (x[0] == x[2]) ? 1 : 3);
        //}


        //public static int TotalPoints(string[] games) 
        //    => games
        //        .Select(g => new { x = g[0], y = g[2] })
        //        .Aggregate(0, (c, n) => c + (n.x > n.y ? 3 : (n.x < n.y ? 0 : 1)));
    }
}