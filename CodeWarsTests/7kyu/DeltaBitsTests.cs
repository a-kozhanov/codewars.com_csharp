using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DeltaBitsTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(2, DeltaBits.ConvertBits(31, 14));
        }
    }
}