using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BasicCalculatorTests
    {
        [Test]
        public void Test_01()
        {
            Assert.AreEqual(11.2, BasicCalculator.Execute(3.2, '+', 8));
        }

        [Test]
        public void Test_02()
        {
            Assert.AreEqual(-4.8, BasicCalculator.Execute(3.2, '-', 8));
        }

        [Test]
        public void Test_03()
        {
            Assert.AreEqual(0.4, BasicCalculator.Execute(3.2, '/', 8));
        }

        [Test]
        public void Test_04()
        {
            Assert.AreEqual(25.6, BasicCalculator.Execute(3.2, '*', 8));
        }

        [Test]
        public void Test_10()
        {
            Assert.Throws<ArgumentException>(() => BasicCalculator.Execute(-3, 'w', 1));
        }
    }
}