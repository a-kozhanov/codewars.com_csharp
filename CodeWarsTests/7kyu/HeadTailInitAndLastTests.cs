using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HeadTailInitAndLastTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual(5, new List<int> {5, 1}.Head());
            Assert.AreEqual(new List<int> {2, 3}, new List<int> {1, 2, 3}.Tail());
            Assert.AreEqual(new List<int> {1, 5, 7}, new List<int> {1, 5, 7, 9}.Init());
            Assert.AreEqual(2, new List<int> {7, 2}.Last_());
        }
    }
}