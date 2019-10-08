using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class StrangeTripToMarketTests
    {

        [Category("Happy Path")]
        [TestCase("Your girlscout cookies are ready to ship. Your total comes to tree fiddy")]
        public void HappyTest(string sentence)
        {
            Assert.IsTrue(StrangeTripToMarket.IsLockNessMonster(sentence), sentence);
        }

        [Category("Sad Path")]
        [TestCase("Yo, I heard you were on the lookout for Nessie. Let me know if you need assistance.")]
        public void SadTests(string sentence)
        {
            Assert.IsFalse(StrangeTripToMarket.IsLockNessMonster(sentence), sentence);
        }
    }
}