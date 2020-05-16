using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RemoveDuplicates7kyuTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(new List<int>() { }, RemoveDuplicates7kyu.Unique(new List<int>() { }));
            Assert.AreEqual(new List<int>() {5, 2, 1, 3}, RemoveDuplicates7kyu.Unique(new List<int>() {5, 2, 1, 3}));
            Assert.AreEqual(new List<int>() {1, 5, 2, 0, -3, 10},
                RemoveDuplicates7kyu.Unique(new List<int>() {1, 5, 2, 0, 2, -3, 1, 10}));
        }
    }
}