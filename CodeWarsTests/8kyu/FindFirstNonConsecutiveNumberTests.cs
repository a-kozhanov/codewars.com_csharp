using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindFirstNonConsecutiveNumberTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(6, FindFirstNonConsecutiveNumber.FirstNonConsecutive(new int[] { 1, 2, 3, 4, 6, 7, 8 }));
        }
    }
}