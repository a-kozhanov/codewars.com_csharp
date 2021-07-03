using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CogsTests
    {
        [Test]
        public void basicTest()
        {
            double expected = -4.0 / 3;
            Assert.AreEqual(expected, Cogs.cogRpm(new[] {100, 75}), 1e-6);
        }
    }
}