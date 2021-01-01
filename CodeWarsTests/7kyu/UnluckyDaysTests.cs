using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataUnluckyDaysTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(1, KataUnluckyDays.UnluckyDays(1586));
            Assert.AreEqual(3, KataUnluckyDays.UnluckyDays(1001));
            Assert.AreEqual(2, KataUnluckyDays.UnluckyDays(2819));
            Assert.AreEqual(2, KataUnluckyDays.UnluckyDays(2792));
            Assert.AreEqual(2, KataUnluckyDays.UnluckyDays(2723));
            Assert.AreEqual(1, KataUnluckyDays.UnluckyDays(1909));
            Assert.AreEqual(2, KataUnluckyDays.UnluckyDays(1812));
            Assert.AreEqual(2, KataUnluckyDays.UnluckyDays(1618));
            Assert.AreEqual(1, KataUnluckyDays.UnluckyDays(2132));
            Assert.AreEqual(3, KataUnluckyDays.UnluckyDays(2065));
        }
    }
}