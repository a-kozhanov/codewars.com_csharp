using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KookaCounterTests
    {
        private static object[] Basic_Test_Cases = new object[]
        {
            new object[] {String.Empty, 0},
            new object[] {"hahahahaha", 1},
            new object[] {"hahahahahaHaHaHa", 2},
            new object[] {"HaHaHahahaHaHa", 3}
        };

        [Test, TestCaseSource(typeof(KookaCounterTests), "Basic_Test_Cases")]
        public void Basic_Test(string laughing, int expected)
        {
            Assert.AreEqual(expected, KataKookaCounter.KookaCounter(laughing));
        }
    }
}