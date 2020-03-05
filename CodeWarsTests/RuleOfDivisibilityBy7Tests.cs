using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RuleOfDivisibilityBy7Tests
    {
        [Test]
        public void Test1()
        {
            Console.WriteLine("****** Basic Tests");
            Assert.AreEqual(new long[] {10, 2}, RuleOfDivisibilityBy7.Seven(1021));
            Assert.AreEqual(new long[] {7, 2}, RuleOfDivisibilityBy7.Seven(1603));
            Assert.AreEqual(new long[] {35, 1}, RuleOfDivisibilityBy7.Seven(371));
            Assert.AreEqual(new long[] {42, 1}, RuleOfDivisibilityBy7.Seven(483));
        }
    }
}