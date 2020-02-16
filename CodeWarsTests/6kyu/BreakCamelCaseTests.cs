using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataBreakCamelCaseTests
    {
        // [TestFixture]
        // public class Sample_Tests
        // {
        //     private static IEnumerable<TestCaseData> testCases
        //     {
        //         get
        //         {
        //             yield return new TestCaseData("camelCasing").Returns("camel Casing");
        //             yield return new TestCaseData("camelCasingTest").Returns("camel Casing Test");
        //         }
        //     }
        //
        //     [Test, TestCaseSource("testCases")]
        //     public string Test(string str) => KataBreakCamelCase.BreakCamelCase(str);
        // }


        // [TestFixture]
        // public class Random_Tests
        // {
        //     private static Random rnd = new Random();
        //
        //     private static string solution(string str) => new Regex("([A-Z])").Replace(str, " $1");
        //
        //     [Test, Description("Random Tests")]
        //     public void RandomTests()
        //     {
        //         const int Tests = 100;
        //
        //         for (int i = 0; i < Tests; ++i)
        //         {
        //             StringBuilder sb = new StringBuilder();
        //             sb.Append((char) rnd.Next(97, 123));
        //             int length = rnd.Next(10, 200);
        //
        //             for (int j = 0; j < length; ++j)
        //             {
        //                 char c = (char) rnd.Next(97, 123);
        //                 if (rnd.Next(0, 5) == 0)
        //                 {
        //                     c = Char.ToUpper(c);
        //                 }
        //
        //                 sb.Append(c);
        //             }
        //
        //             string str = sb.ToString();
        //
        //             string expected = solution(str);
        //             string actual = KataBreakCamelCase.BreakCamelCase(str);
        //
        //             Assert.AreEqual(expected, actual);
        //         }
        //     }
        //}
    }
}