using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BrokenCounterTests
    {
        [Test]
        public void Test()
        {
            BrokenCounter counter = new BrokenCounter();
            Assert.AreEqual(0, counter.Value, "Initial counter value must be 0");
            counter.Increase();
            Assert.AreEqual(1, counter.Value, "Counter value must be incremented.");
            counter.Reset();
            Assert.AreEqual(0, counter.Value, "Counter value must be reset.");
        }
    }
}