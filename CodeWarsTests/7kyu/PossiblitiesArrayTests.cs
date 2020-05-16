using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PossiblitiesArrayTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual(true, PossiblitiesArray.IsAllPossibilities(new int[] {0, 1, 2, 3}));
            Assert.AreEqual(false, PossiblitiesArray.IsAllPossibilities(new int[] {1, 2, 3, 4}));
        }
    }
}