using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CountingArrayElementsTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new Dictionary<string, int> {{"a", 2}, {"b", 3}},
                CountingArrayElements.Count(new List<string> {"a", "b", "b", "a", "b"}));
        }
    }
}