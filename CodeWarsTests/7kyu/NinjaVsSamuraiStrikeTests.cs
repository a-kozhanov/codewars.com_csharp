using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NinjaVsSamuraiStrikeTests
    {
        private NinjaVsSamuraiStrike.Warrior ninja = new NinjaVsSamuraiStrike.Warrior("Ninja");
        private NinjaVsSamuraiStrike.Warrior samurai = new NinjaVsSamuraiStrike.Warrior("Samurai");

        [Test]
        public void Tests()
        {
            samurai.Strike(ninja, 4);
            Assert.AreEqual(60, ninja.Health);
        }      
    }
}