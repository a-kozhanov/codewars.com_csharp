using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class LargestElementsTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual(new List<int> {9, 10},
                LargestElements.Largest(2, new List<int> {10, 9, 8, 7, 6, 5, 4, 3, 2, 1}));

            Assert.AreEqual(new List<int> {5, 5, 5},
                LargestElements.Largest(3, new List<int> {5, 1, 5, 2, 3, 1, 2, 3, 5}));

            Assert.AreEqual(new List<int> {3, 5, 9, 13, 22, 50, 63},
                LargestElements.Largest(7, new List<int> {9, 1, 50, 22, 3, 13, 2, 63, 5}));

            Assert.AreEqual(new List<int> { }, LargestElements.Largest(0, new List<int> {1, 2, 3, 4, 8, 7, 6, 5}));
        }
    }
}