using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class RemoveAnchorURLTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTests()
        {
            Assert.AreEqual("www.codewars.com", RemoveAnchorURL.RemoveUrlAnchor("www.codewars.com#about"));
            Assert.AreEqual("www.codewars.com/katas/?page=1", RemoveAnchorURL.RemoveUrlAnchor("www.codewars.com/katas/?page=1#about"));
            Assert.AreEqual("www.codewars.com/katas/", RemoveAnchorURL.RemoveUrlAnchor("www.codewars.com/katas/"));
        }
    }
}