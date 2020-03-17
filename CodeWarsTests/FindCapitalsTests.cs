using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindCapitalsTests
    {
        [Test]
        public void CodEWaRs()
        {
            Assert.AreEqual(FindCapitals.Capitals("CodEWaRs"), new int[] {0, 3, 4, 6});
        }
    }
}