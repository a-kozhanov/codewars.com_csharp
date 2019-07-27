using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SuperDuperEasyTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("Error", SuperDuperEasy.Problem("hello"));
            Assert.AreEqual("56", SuperDuperEasy.Problem("1"));
            Assert.AreEqual("256", SuperDuperEasy.Problem("5"));
            Assert.AreEqual("6", SuperDuperEasy.Problem("0"));
            Assert.AreEqual("66", SuperDuperEasy.Problem("1,2"));
        }
    }
}