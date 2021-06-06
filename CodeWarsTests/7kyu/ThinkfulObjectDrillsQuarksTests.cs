using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ThinkfulObjectDrillsQuarksTests
    {
        [Test]
        public void SampleTest()
        {
            ThinkfulObjectDrillsQuarks.Quark q1 = new ThinkfulObjectDrillsQuarks.Quark("red", "up");
            ThinkfulObjectDrillsQuarks.Quark q2 = new ThinkfulObjectDrillsQuarks.Quark("blue", "strange");
            Assert.AreEqual("red", q1.Color);
            Assert.AreEqual("strange", q2.Flavor);
            Assert.AreEqual(1 / 3d, q2.BaryonNumber);

            q1.Interact(q2);
            Assert.AreEqual("blue", q1.Color);
        }
    }
}