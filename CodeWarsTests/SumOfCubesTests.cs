using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SumOfCubesTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual(1, SumOfCubes.SumCubes(1));
            Assert.AreEqual(9, SumOfCubes.SumCubes(2));
            Assert.AreEqual(36, SumOfCubes.SumCubes(3));
            Assert.AreEqual(100, SumOfCubes.SumCubes(4));
            Assert.AreEqual(3025, SumOfCubes.SumCubes(10));
            Assert.AreEqual(58155876, SumOfCubes.SumCubes(123));
        }
    }
}