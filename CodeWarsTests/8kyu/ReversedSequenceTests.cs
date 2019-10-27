using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ReversedSequenceTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(ReversedSequence.ReverseSeq(5), Is.EqualTo(new int[] { 5, 4, 3, 2, 1 }));
        }
    }
}