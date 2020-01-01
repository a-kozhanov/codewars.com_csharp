using System;
using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RetrieveArrayValueByIndexWithDefaultTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            int[] range = Enumerable.Range(1, 3).ToArray();
            Assert.AreEqual(2, RetrieveArrayValueByIndexWithDefault.Solution(range, 1, -1));
            Assert.AreEqual(3, RetrieveArrayValueByIndexWithDefault.Solution(range, -1, -1));
            Assert.AreEqual(-1, RetrieveArrayValueByIndexWithDefault.Solution(range, -5, -1));
            Assert.AreEqual(1, RetrieveArrayValueByIndexWithDefault.Solution(range, -3, -1));
        }

        private static Random rnd = new Random();

        // [Test, Description("Random Tests")]
        // public void RandomTest()
        // {
        //     const int Tests = 100;
        //
        //     for (int i = 0; i < Tests; ++i)
        //     {
        //         int[] items = Enumerable.Range(rnd.Next(0, 1000), rnd.Next(0, 1000)).ToArray();
        //         int index = rnd.Next(-1000, 1000);
        //         int defaultValue = rnd.Next(-1000, 1000);
        //
        //         int expected = Sol.Solution(items, index, defaultValue);
        //         int actual = Kata.Solution(items, index, defaultValue);
        //
        //         Assert.AreEqual(expected, actual);
        //     }
        // }
    }
}