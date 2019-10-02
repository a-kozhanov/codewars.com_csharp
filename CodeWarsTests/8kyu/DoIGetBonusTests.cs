using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DoIGetBonusTests
    {
        [Test]
        public void BasicTest()
        {
            StringAssert.AreEqualIgnoringCase("$100000", DoIGetBonus.bonus_time(10000, true));
            StringAssert.AreEqualIgnoringCase("$250000", DoIGetBonus.bonus_time(25000, true));
            StringAssert.AreEqualIgnoringCase("$10000", DoIGetBonus.bonus_time(10000, false));
            StringAssert.AreEqualIgnoringCase("$60000", DoIGetBonus.bonus_time(60000, false));
            StringAssert.AreEqualIgnoringCase("$20", DoIGetBonus.bonus_time(2, true));
            StringAssert.AreEqualIgnoringCase("$78", DoIGetBonus.bonus_time(78, false));
            StringAssert.AreEqualIgnoringCase("$678900", DoIGetBonus.bonus_time(67890, true));
        }
    }
}