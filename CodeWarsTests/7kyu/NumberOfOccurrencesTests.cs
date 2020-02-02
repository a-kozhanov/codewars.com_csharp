using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataNumberOfOccurrencesTests
    {
        [Test]
        public void Should_Work_On_Empty_List()
        {
            Assert.AreEqual(0,
                KataNumberOfOccurrences.NumberOfOccurrences(2, new int[0]));
        }

        [Test]
        public void Should_Work_On_Examples()
        {
            var example = new int[] {4, 0, 4};

            Assert.AreEqual(2,
                KataNumberOfOccurrences.NumberOfOccurrences(4, example));

            Assert.AreEqual(0,
                KataNumberOfOccurrences.NumberOfOccurrences(1, example));

            Assert.AreEqual(1,
                KataNumberOfOccurrences.NumberOfOccurrences(0, example));
        }
    }
}