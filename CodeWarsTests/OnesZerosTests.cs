using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class OnesZerosTests
    {
        int[] Test1 = new int[] { 0, 0, 0, 0 };
        int[] Test2 = new int[] { 1, 1, 1, 1 };
        int[] Test3 = new int[] { 0, 1, 1, 0 };
        int[] Test4 = new int[] { 0, 1, 0, 1 };
        [Test]
        public void BasicTesting()
        {
            Assert.AreEqual(0, OnesZeros.binaryArrayToNumber(Test1));
            Assert.AreEqual(15, OnesZeros.binaryArrayToNumber(Test2));
            Assert.AreEqual(6, OnesZeros.binaryArrayToNumber(Test3));
            Assert.AreEqual(5, OnesZeros.binaryArrayToNumber(Test4));
        }
    }
}