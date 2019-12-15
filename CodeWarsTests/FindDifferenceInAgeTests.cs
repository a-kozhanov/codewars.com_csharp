using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindDifferenceInAgeTests
    {
        [Test, Description("Should return expected results for sample tests")]
        public void SampleTest()
        {
            Assert.AreEqual(new int[] { 6, 82, 76 }, FindDifferenceInAge.DifferenceInAges(new int[] { 82, 15, 6, 38, 35 }));
            Assert.AreEqual(new int[] { 14, 99, 85 }, FindDifferenceInAge.DifferenceInAges(new int[] { 57, 99, 14, 32 }));
        }
    }
}