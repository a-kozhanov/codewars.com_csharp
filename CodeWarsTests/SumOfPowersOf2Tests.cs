using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SumOfPowersOf2Tests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(new int[] {1}, SumOfPowersOf2.Powers(1));
            Assert.AreEqual(new int[] {2}, SumOfPowersOf2.Powers(2));
            Assert.AreEqual(new int[] {2, 4}, SumOfPowersOf2.Powers(6));
        }
    }
}