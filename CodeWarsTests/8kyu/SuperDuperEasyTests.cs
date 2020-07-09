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
            //Assert.AreEqual("66", SuperDuperEasy.Problem("1.2"));
        }

        [Test]
        public void Randoms()
        {
            Console.WriteLine("***Random tests");
            var i = 0;
            var rand = new Random();
            while (i < 50)
            {
                var num = rand.Next(0, i + 1);
                var expected = (num * 50 + 6).ToString();
                Assert.AreEqual(expected, SuperDuperEasy.Problem(num.ToString()));
                i++;
            }
        }
    }
}