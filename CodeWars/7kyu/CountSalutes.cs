/*
https://www.codewars.com/kata/605ae9e1d2be8a0023b494ed/csharp

7 kyu
Count salutes

Description
There is a narrow hallway in which people can go right and left only. 
When two people meet in the hallway, by tradition they must salute each other. 
People move at the same speed left and right.

Your task is to write a function that, given a string representation of people moving in the hallway, 
will count the number of salutes that will occur.
Note: 2 salutes occur when people meet, one to the other and vice versa.

Input
People moving right will be represented by >; people moving left will be represented by <. An example input would be >--<--->->. 
The - character represents empty space, which you need not worry about.

Examples
Input: >----->-----<--<
Output: 8

Explanation: Both guys moving right will meet both guys moving left.
Hence a total of 4 meetings will occur and 8 salutes will occur.

Input: <---<--->----<
Output: 2

Explanation: Only one meeting occurs.
*/

using System.Linq;

namespace CodeWars
{
    public class KataCountSalutes
    {
        public static int CountSalutes(string hallway)
        {
            return hallway.Aggregate(new[] {0, 0}, (i, c) =>
            {
                if (c == '>') i[0]++;
                else if (c == '<') i[1] += i[0] * 2;
                return i;
            })[1];


            // return 2 * hallway.Select((c, i) => new {Idx = i, Dir = c})
            //     .Where(x => x.Dir == '>')
            //     .Select(x => hallway[x.Idx..].Count(c => c == '<'))
            //     .Sum();


            // int salutes = 0, count = 0;
            // foreach (var c in hallway)
            // {
            //     switch (c)
            //     {
            //         case '>':
            //             count += 1;
            //             break;
            //         case '<':
            //             salutes += count;
            //             break;
            //     }
            // }
            //
            // return 2 * salutes;


            // return 2 * hallway.Select((c, i) => new {Idx = i, Dir = c})
            //     .Where(x=> x.Dir == '>')
            //     .Select(x=> hallway.Substring(x.Idx).Count(c=> c == '<'))
            //     .Sum();

            // if (hallway.Length == 0)
            //     return acc;
            // return CountSalutes(string.Concat(hallway.Skip(1)), hallway[0] != '>' ? acc : acc + 2 * hallway.Count(c => c == '<'));


            // int ns = 0, nr = 0;
            // foreach (char c in hallway)
            // {
            //     switch (c)
            //     {
            //         case '>':
            //             nr++;
            //             break;
            //         case '<':
            //             ns += nr;
            //             break;
            //     }
            // }
            //
            // return ns * 2;
        }
    }
}