using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SumStringsNumbersTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("579", SumStringsNumbers.sumStrings("123", "456"));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual("8842", SumStringsNumbers.sumStrings("8797", "45"));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual("10367", SumStringsNumbers.sumStrings("800", "9567"));
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual("100", SumStringsNumbers.sumStrings("99", "1"));
        }
        [Test]
        public void Test5()
        {
            Assert.AreEqual("8670", SumStringsNumbers.sumStrings("00103", "08567"));
        }
        [Test]
        public void Test6()
        {
            Assert.AreEqual("5", SumStringsNumbers.sumStrings("", "5"));
        }
        [Test]
        public void Test7()
        {
            Assert.AreEqual("712577413488402631964821329", SumStringsNumbers.sumStrings("712569312664357328695151392", "8100824045303269669937"));
        }
        [Test]
        public void Test8()
        {
            Assert.AreEqual("131151201344081895336534324866", SumStringsNumbers.sumStrings("50095301248058391139327916261", "81055900096023504197206408605"));
        }
    }
}