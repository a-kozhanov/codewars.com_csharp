/*
https://www.codewars.com/kata/5d2659626c7aec0022cb8006/csharp

7 kyu
The Baum-Sweet sequence

Wikipedia: The Baum–Sweet sequence is an infinite automatic sequence of 0s and 1s defined by the rule:

bn = 1 if the binary representation of n contains no block of consecutive 0s of odd length;
bn = 0 otherwise;

for n ≥ 0.

Define an iterator BaumSweet that sequentially generates the values of this sequence.

It will be tested for up to 1 000 000 values.

Note that the binary representation of 0 used here is not 0 but the empty string ( which does not contain any blocks of consecutive 0s ).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class BaumSweetSequence
    {
        public static IEnumerable<int> BaumSweet()
        {
            // yield return 1;
            // for (int i = 1; i < 1000000; i++)
            // {
            //     MatchCollection m = Regex.Matches(Convert.ToString(i, 2), "0+");
            //     yield return m.Any(x => x.Length % 2 == 1) ? 0 : 1;
            // }


            int[] arr = {1, 3, 5, 7, 9, 11, 13, 15, 17, 19};
            for (int i = 0; i < 1000000; i++)
            {
                string s = Convert.ToString(i, 2);
                var result = 1;
                if (i != 0)
                    foreach (int k in arr)
                    {
                        if (s.EndsWith("1" + new string('0', k)) || s.Contains("1" + new string('0', k) + "1"))
                            result = 0;
                    }

                yield return result;
            }
        }
    }
}