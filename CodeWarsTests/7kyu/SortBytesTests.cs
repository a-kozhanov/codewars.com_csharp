using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataSortBytesTests
    {
        [TestCase(0U, 0U)]
        [TestCase(1U, 16777216U)]
        [TestCase(2U, 33554432U)]
        [TestCase(4294967295U, 4294967295U)]
        [TestCase(3735928559U, 4024352429U)]
        [TestCase(255U, 4278190080U)]
        [TestCase(305419896U, 2018915346U)]
        [TestCase(19088743U, 1732584193U)]
        [TestCase(555885348U, 606282273U)]
        [TestCase(43839U, 2873032704U)]
        [TestCase(723893U, 3037399808U)]
        [TestCase(3567U, 4010606592U)]
        public void SampleTests(uint number, uint expected)
        {
            var actual = KataSortBytes.SortBytes(number);
            Assert.AreEqual(expected, actual, $"For number: {number}");
        }
    }
}