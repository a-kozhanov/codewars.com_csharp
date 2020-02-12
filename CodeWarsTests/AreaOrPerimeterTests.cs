using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataAreaOrPerimeterTests
    {
        [Test]
        public void FixedTest()
        {
            Assert.AreEqual(KataAreaOrPerimeter.AreaOrPerimeter(4, 4), 16);
            Assert.AreEqual(KataAreaOrPerimeter.AreaOrPerimeter(6, 10), 32);
        }
    }
}