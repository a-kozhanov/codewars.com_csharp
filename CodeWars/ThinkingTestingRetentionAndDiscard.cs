/*
https://www.codewars.com/kata/56ee0448588cbb60740013b9/train/csharp
https://www.codewars.com/kata/56ee0448588cbb60740013b9/solutions

7 kyu
Thinking & Testing : Retention and discard

No Story
No Description
Only by Thinking and Testing
Look at the results of the testcases, and guess the code!
*/

using System.Linq;

namespace CodeWars
{
    public class ThinkingTestingRetentionAndDiscard
    {
        public int[] Testit(int n)
        {
            return n < 1 ? new int[0] : Enumerable.Range(1, n).Where(x => x % 2 != 0 && n % x == 0).ToArray();
        }

        // public int[] Testit(int n)
        // {
        //     return n < 1 ? new int[0] : Enumerable.Range(1, n).Where(i => i % 2 == 1 && n % i == 0).ToArray();
        // }


        // public int[] Testit(int n)
        // {
        //     return n <= 0
        //         ? new int[] { }
        //         : Enumerable.Range(1, n / 2).Concat(new[] {n})
        //             .Where(x => (x & 1) == 1 && n % x == 0)
        //             .ToArray();
        // }


        // public int[] Testit(int n)
        // {
        //     return n < 1 ? new int[] { } : Enumerable.Range(1, n).Where(x => (x & 1) != 0 && n % x == 0).ToArray();
        // }


        // public int[] Testit(int n)
        // {
        //     if (n <= 0) return new int[0];
        //     return Enumerable.Range(0, (n + 1) / 2).Select(i => 2 * i + 1).Where(i => n % i == 0).ToArray();
        // }


        // public int[] Testit(int n)
        // {
        //     if (n < 1)
        //         return new int[] { };
        //
        //     System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
        //     for (int i = 1; i <= n; i += 2)
        //     {
        //         if (n % i == 0)
        //             list.Add(i);
        //     }
        //
        //     int[] res = new int[list.Count];
        //     list.CopyTo(res);
        //
        //     return res;
        // }


        // public int[] Testit(int n)
        // {
        //     var l = new List<int>();
        //     for (int i = 1; i <= n; i += 2)
        //     {
        //         if (n % i == 0)
        //         {
        //             l.Add(i);
        //         }
        //     }
        //
        //     return l.ToArray();
        // }
    }
}