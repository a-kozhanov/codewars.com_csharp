using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ConvertStringToNumberTests
    {
        [Test]
        public void test1()
        {
            Assert.AreEqual(1234, ConvertStringToNumber.StringToNumber("1234"));
        }

        [Test]
        public void test2()
        {
            Assert.AreEqual(605, ConvertStringToNumber.StringToNumber("605"));
        }

        [Test]
        public void test3()
        {
            Assert.AreEqual(1405, ConvertStringToNumber.StringToNumber("1405"));
        }

        [Test]
        public void test4()
        {
            Assert.AreEqual(-7, ConvertStringToNumber.StringToNumber("-7"));
        }
    }
}