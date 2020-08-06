using System;
using System.Collections.Generic;
using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ConsecutiveStringsTests
    {
        private static void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            Console.WriteLine("Basic Tests");
            testing(
                ConsecutiveStrings.LongestConsec(
                    new String[] {"zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"}, 2),
                "abigailtheta");
            testing(
                ConsecutiveStrings.LongestConsec(
                    new String[] {"ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh"},
                    1), "oocccffuucccjjjkkkjyyyeehh");
            testing(ConsecutiveStrings.LongestConsec(new String[] { }, 3), "");
            testing(
                ConsecutiveStrings.LongestConsec(
                    new String[]
                        {"itvayloxrp", "wkppqsztdkmvcuwvereiupccauycnjutlv", "vweqilsfytihvrzlaodfixoyxvyuyvgpck"}, 2),
                "wkppqsztdkmvcuwvereiupccauycnjutlvvweqilsfytihvrzlaodfixoyxvyuyvgpck");
            testing(
                ConsecutiveStrings.LongestConsec(new String[] {"wlwsasphmxx", "owiaxujylentrklctozmymu", "wpgozvxxiu"},
                    2), "wlwsasphmxxowiaxujylentrklctozmymu");
            testing(
                ConsecutiveStrings.LongestConsec(new String[] {"zone", "abigail", "theta", "form", "libe", "zas"}, -2),
                "");
            testing(ConsecutiveStrings.LongestConsec(new String[] {"it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz"}, 3),
                "ixoyx3452zzzzzzzzzzzz");
            testing(
                ConsecutiveStrings.LongestConsec(new String[] {"it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz"}, 15),
                "");
            testing(ConsecutiveStrings.LongestConsec(new String[] {"it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz"}, 0),
                "");
        }

        //-----------------------        
        private static String LongestConsecSol(string[] strarr, int k)
        {
            int n = strarr.Length;
            if ((n == 0) || (k > n) || (k <= 0)) return "";
            int[] arr = strarr.Select(w => w.Length).ToArray();
            int sm = 0;
            for (int i = 0; i < k; i++) sm += arr[i];
            int mx_sm = sm, mx_nd = k - 1;
            for (int u = k; u < n; u++)
            {
                sm = sm + arr[u] - arr[u - k];
                if (sm > mx_sm)
                {
                    mx_sm = sm;
                    mx_nd = u;
                }
            }

            int start = mx_nd - k + 1;
            string[] sl = new List<string>(strarr).GetRange(start, k).ToArray();
            return String.Join("", sl);
        }

        private static string[] DoEx(int k)
        {
            int j = 0;
            string[] a1 = new string[k];
            while (j < k)
            {
                string res = "";
                int n = -1;
                for (int i = 0; i < rnd.Next(3, 10); i++)
                {
                    n = rnd.Next(97, 122);
                    for (int u = 0; u < rnd.Next(1, 3); u++)
                        res += (char) n;
                }

                a1[j] = res;
                j++;
            }

            return a1;
        }

        //-----------------------
        private static Random rnd = new Random();

        [Test]
        public static void RandomTest1()
        {
            Console.WriteLine("200 Random Tests");
            for (int i = 0; i < 200; i++)
            {
                String[] s1 = DoEx(rnd.Next(100, 200));
                int n = rnd.Next(1, s1.Length + 2);
                testing(ConsecutiveStrings.LongestConsec(s1, n), LongestConsecSol(s1, n));
            }
        }
    }
}