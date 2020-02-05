using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SumOfAnglesTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(180, SumOfAngles.Angle(3));
            Assert.AreEqual(360, SumOfAngles.Angle(4));
        }
    }
}