using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ReturnFirstMMultiplesOfNTests
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual(new double[] {5, 10, 15}, ReturnFirstMMultiplesOfN.Multiples(3, 5));
        }
    }
}