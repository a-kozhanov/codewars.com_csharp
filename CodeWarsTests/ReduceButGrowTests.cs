using System;
using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ReduceButGrowTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(6, ReduceButGrow.Grow(new[] { 1, 2, 3 }));
            Assert.AreEqual(16, ReduceButGrow.Grow(new[] { 4, 1, 1, 1, 4 }));
            Assert.AreEqual(64, ReduceButGrow.Grow(new[] { 2, 2, 2, 2, 2, 2 }));
        }


        [Test]
        public void RandomTests()
        {
            var rand = new Random();
            for (var i = 0; i < 100; i++)
            {
                var len = rand.Next(2, 8);
                var x = Enumerable.Range(0, len).Select(a => rand.Next(1, 10)).ToArray();

                var expected = x.Aggregate((a, b) => a * b);

                Assert.AreEqual(expected, ReduceButGrow.Grow(x), "It should work for random inputs too");
            }
        }
    }
}