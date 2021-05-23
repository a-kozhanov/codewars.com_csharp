using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ASCIIingOnAlpsTests
    {
        [Test]
        public void SampleDecimal()
        {
            string result = ASCIIingOnAlps.DetermineCool(10, "ThisIsADecimal");
            Console.WriteLine(result);
            Assert.AreEqual("1348", result);
        }
    }
}