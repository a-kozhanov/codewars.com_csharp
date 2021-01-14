using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DetermineIfPokerHandIsFlushTests
    {
        [Test]
        public void BasicTests()
        {
            string[] cards = {"AS", "3S", "9S", "KS", "4S"};
            Assert.AreEqual(true, DetermineIfPokerHandIsFlush.CheckIfFlush(cards));
            string[] cards2 = {"AD", "4S", "7H", "KC", "5S"};
            Assert.AreEqual(false, DetermineIfPokerHandIsFlush.CheckIfFlush(cards2));
            string[] cards3 = {"10D", "4S", "7H", "KC", "5S"};
            Assert.AreEqual(false, DetermineIfPokerHandIsFlush.CheckIfFlush(cards3));
            string[] cards4 = {"10D", "QD", "7D", "KD", "5D"};
            Assert.AreEqual(true, DetermineIfPokerHandIsFlush.CheckIfFlush(cards4));
        }
    }
}