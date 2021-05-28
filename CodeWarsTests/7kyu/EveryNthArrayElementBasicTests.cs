using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class EveryNthArrayElementBasicTests
    {
        [Test]
        public void MyTest()
        {
            var subject = new List<int> {0, 1, 2, 3, 4};
            Assert.AreEqual(new int[] {0, 1, 2, 3, 4}, new int[] {0, 1, 2, 3, 4}.Every());
            Assert.AreEqual(new List<int> {0, 1, 2, 3, 4}, subject.Every());
            Assert.AreEqual(new List<int> {0, 1, 2, 3, 4}, subject.Every(1));
            Assert.AreEqual(new List<int> {0, 2, 4}, subject.Every(2));
            Assert.AreEqual(new List<int> {0, 3}, subject.Every(3));
            Assert.AreEqual(new List<int> {1, 4}, subject.Every(3, 1));
        }
    }
}