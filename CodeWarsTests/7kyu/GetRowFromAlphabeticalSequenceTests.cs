using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GetRowFromAlphabeticalSequenceTests
    {
        [Test]
        public void TestRowOne()
        {
            Assert.AreEqual("ABCDEFGHIJKLMNOPQRSTUVWXYZ", GetRowFromAlphabeticalSequence.GetRow(1));
        }

        [Test]
        public void TestRowTwentySix()
        {
            Assert.AreEqual("ZZZZZZZZZZZZZZZZZZZZZZZZZZ", GetRowFromAlphabeticalSequence.GetRow(26));
        }

        [Test]
        public void TestRowFifthteen()
        {
            Assert.AreEqual("OOOOOOOOOOOOOOOPQRSTUVWXYZ", GetRowFromAlphabeticalSequence.GetRow(15));
        }

        [Test]
        public void TestRowTwentySeven()
        {
            Assert.AreEqual("ABCDEFGHIJKLMNOPQRSTUVWXYZ", GetRowFromAlphabeticalSequence.GetRow(27));
        }
    }
}