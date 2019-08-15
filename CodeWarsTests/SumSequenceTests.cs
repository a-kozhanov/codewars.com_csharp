using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class SumSequenceTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(12, SumSequence.SequenceSum(2, 6, 2));
            Assert.AreEqual(15, SumSequence.SequenceSum(1, 5, 1));
            Assert.AreEqual(5, SumSequence.SequenceSum(1, 5, 3));
            Assert.AreEqual(45, SumSequence.SequenceSum(0, 15, 3));
            Assert.AreEqual(0, SumSequence.SequenceSum(16, 15, 3));
            Assert.AreEqual(26, SumSequence.SequenceSum(2, 24, 22));
            Assert.AreEqual(2, SumSequence.SequenceSum(2, 2, 2));
            Assert.AreEqual(2, SumSequence.SequenceSum(2, 2, 1));
            Assert.AreEqual(35, SumSequence.SequenceSum(1, 15, 3));
            Assert.AreEqual(0, SumSequence.SequenceSum(15, 1, 3));
        }
    }
}