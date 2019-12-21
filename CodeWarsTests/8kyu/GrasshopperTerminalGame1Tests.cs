using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GrasshopperTerminalGame1Tests
    {
        [Test, Description("Hero should create a Hero")]
        public void InitTest()
        {
            GrasshopperTerminalGame1.Hero myHero = new GrasshopperTerminalGame1.Hero();
            Assert.AreEqual("Hero", myHero.Name);
        }

#pragma warning disable CS0183 // Suppress specific compiler warning, asserting a strongly typed property is that type will throw a warning
        [Test, Description("Hero should have appropriate types for its properties")]
        public void TypeTest()
        {
            GrasshopperTerminalGame1.Hero myHero = new GrasshopperTerminalGame1.Hero();
            Assert.That(myHero.Health is float);
        }
#pragma warning restore CS0183
    }
}
