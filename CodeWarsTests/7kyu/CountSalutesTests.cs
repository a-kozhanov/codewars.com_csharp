using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataCountSalutesTests
    {
        private static void Act(string hallway, int expected)
        {
            var actual = KataCountSalutes.CountSalutes(hallway);
            Console.WriteLine($"input: {hallway} expected: {expected} actual: {actual}");
            Assert.AreEqual(expected, actual, $"Input:  {hallway}");
        }

        [Test(Description = "Fixed Tests")]
        public void FixedTests()
        {
            Act("<---->---<---<-->", 4);
            Act("------", 0);
            Act(">>>>>>>>>>>>>>>>>>>>>----<->", 42);
            Act("<<----<>---<", 2);
            Act(">", 0);
        }
    }
}