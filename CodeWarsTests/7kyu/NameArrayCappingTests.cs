using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NameArrayCappingTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new string[] {"Expected"}, NameArrayCapping.CapMe(new string[] {"ExPeCteD"}));
        }
    }
}