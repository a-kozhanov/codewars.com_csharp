/*
https://www.codewars.com/kata/59e72bdcfc3c4974190000d9/csharp

7 kyu
Cogs 2

Kata Task
You are given a list of cogs in a gear train

Each element represents the number of teeth of that cog

e.g. [100, 50, 25] means

1st cog has 100 teeth
2nd cog has 50 teeth
3rd cog has 25 teeth
If the nth cog rotates clockwise at 1 RPM what is the RPM of the cogs at each end of the gear train?

Notes

no two cogs share the same shaft
return an array whose two elements are RPM of the first and last cogs respectively
use negative numbers for anti-clockwise rotation
for convenience n is zero-based
For C and NASM coders, the returned array will be free'd.
Series:

Cogs
Cogs 2
*/

namespace CodeWars
{
    public class Cogs2
    {
        public static double[] CogRpm(int[] cogs, int n)
        {
            return new[]
            {
                (n % 2 == 1 ? -1d : 1d) * cogs[n] / cogs[0],
                ((cogs.Length - n) % 2 == 1 ? 1d : -1d) * cogs[n] / cogs[^1]
            };

            // return new[]
            // {
            //     cogs[n] * 1.0 / cogs[0] * (n % 2 == 0 ? 1 : -1),
            //     cogs[n] * 1.0 / cogs[^1] * ((cogs.Length - n) % 2 == 1 ? 1 : -1)
            // };
        }
    }
}