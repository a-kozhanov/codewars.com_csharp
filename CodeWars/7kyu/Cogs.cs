/*
https://www.codewars.com/kata/59e1b9ce7997cbecb9000014/csharp

7 kyu
Cogs

Kata Task
You are given a list of cogs in a gear train

Each element represents the number of teeth of that cog

e.g. [100, 75] means

1st cog has 100 teeth
2nd cog has 75 teeth
If the first cog rotates clockwise at 1 RPM what is the RPM of the final cog?

(use negative numbers for anti-clockwise rotation)

Notes
no two cogs share the same shaft
Series:

Cogs
Cogs 2
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class Cogs
    {
        public static double cogRpm(int[] cogs)
        {
            return (cogs.Length % 2 == 0 ? -1d : 1d) * cogs[0] / cogs[^1];
            // return (cogs.Length % 2 == 0 ? -1.0 : 1.0) * cogs[0] / cogs[^1];
            // return (double) cogs[0] / cogs[^1] * Math.Pow(-1, cogs.Length + 1);
            // return (cogs.Length % 2 == 0 ? -1.0 : 1.0) * cogs.First() / cogs.Last();
        }
    }
}