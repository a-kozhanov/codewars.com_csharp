using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SushiGoRoundBeginnersTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(4, SushiGoRoundBeginners.TotalBill("rr"));
            Assert.AreEqual(8, SushiGoRoundBeginners.TotalBill("rr rrr"));
            Assert.AreEqual(16, SushiGoRoundBeginners.TotalBill("rr rrr rrr rr"));
            Assert.AreEqual(34, SushiGoRoundBeginners.TotalBill("rrrrrrrrrrrrrrrrrr   rr r"));
            Assert.AreEqual(0, SushiGoRoundBeginners.TotalBill(""));
        }
    }
}