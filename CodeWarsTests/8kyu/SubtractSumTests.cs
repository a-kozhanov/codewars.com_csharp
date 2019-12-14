using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataSubtractSumTests
    {
        [Test]
        public void Test1()
        {
            StringAssert.AreEqualIgnoringCase("apple", KataSubtractSum.SubtractSum(11));
        }
    }
}