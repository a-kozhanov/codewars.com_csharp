using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AllStarCodeChallenge22Tests
    {
        private static void Act(int seconds, string expected)
        {
            var actual = AllStarCodeChallenge22.ToTime(seconds);
            Console.WriteLine($"   Input: seconds = {seconds}\nExpected: {expected}\n  Actual: {actual}\n");
            Assert.AreEqual(expected, actual, $"Input: seconds = {seconds}");
        }

        [Test(Description = "Fixed Tests")]
        public void FixedTests()
        {
            Act(3600, "1 hour(s) and 0 minute(s)");
            Act(3601, "1 hour(s) and 0 minute(s)");
            Act(3500, "0 hour(s) and 58 minute(s)");
            Act(323500, "89 hour(s) and 51 minute(s)");
            Act(0, "0 hour(s) and 0 minute(s)");
        }
    }
}