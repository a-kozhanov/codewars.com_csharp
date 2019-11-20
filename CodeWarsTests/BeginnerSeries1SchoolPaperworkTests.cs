using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BeginnerSeries1SchoolPaperworkTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(25, BeginnerSeries1SchoolPaperwork.Paperwork(5, 5));
        }
    }
}