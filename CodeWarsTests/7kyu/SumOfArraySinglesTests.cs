using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SumOfArraySinglesTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(15, SumOfArraySingles.Repeats(new List<int> {4, 5, 7, 5, 4, 8}));
            Assert.AreEqual(19, SumOfArraySingles.Repeats(new List<int> {9, 10, 19, 13, 19, 13}));
            Assert.AreEqual(12, SumOfArraySingles.Repeats(new List<int> {16, 0, 11, 4, 8, 16, 0, 11}));
            Assert.AreEqual(22, SumOfArraySingles.Repeats(new List<int> {5, 17, 18, 11, 13, 18, 11, 13}));
            Assert.AreEqual(24, SumOfArraySingles.Repeats(new List<int> {5, 10, 19, 13, 10, 13}));
        }
    }
}