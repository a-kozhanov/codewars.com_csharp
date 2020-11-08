using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataStringTaskTests
    {
        private static object[] Basic_Test_Cases = new object[]
        {
            new object[] {"tour", ".t.r"},
            new object[] {"Codewars", ".c.d.w.r.s"},
            new object[] {"aBAcAba", ".b.c.b"},
        };

        [Test, TestCaseSource(typeof(KataStringTaskTests), "Basic_Test_Cases")]
        public void BasicTest(string test, string expected)
        {
            Assert.AreEqual(expected, KataStringTask.StringTask(test));
        }
    }
}