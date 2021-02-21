using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class WhichSectionDidYouScrollToTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(0, WhichSectionDidYouScrollTo.GetSectionId(1, new int[] {300, 200, 400, 600, 100}));
            Assert.AreEqual(0, WhichSectionDidYouScrollTo.GetSectionId(299, new int[] {300, 200, 400, 600, 100}));
            Assert.AreEqual(1, WhichSectionDidYouScrollTo.GetSectionId(300, new int[] {300, 200, 400, 600, 100}));
            Assert.AreEqual(4, WhichSectionDidYouScrollTo.GetSectionId(1599, new int[] {300, 200, 400, 600, 100}));
            Assert.AreEqual(-1, WhichSectionDidYouScrollTo.GetSectionId(1600, new int[] {300, 200, 400, 600, 100}));
        }
    }
}