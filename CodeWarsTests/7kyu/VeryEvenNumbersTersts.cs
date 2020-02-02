using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class VeryEvenNumbersTersts
    {
        [Test]
        public void Test()
        {
            Assert.IsTrue(VeryEvenNumbers.IsVeryEvenNumber(4));
        }
    }
}