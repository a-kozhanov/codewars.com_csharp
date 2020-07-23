using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MultiplesOf3Or5Tests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(23, MultiplesOf3Or5.Solution(10));
            Assert.AreEqual(78, MultiplesOf3Or5.Solution(20));
        }
    }
}