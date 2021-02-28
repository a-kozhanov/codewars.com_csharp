using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ConvertImproperFractionToMixedNumeralTests
    {
        [Test]
        public void convertToMixedNumeral()
        {
            ConvertImproperFractionToMixedNumeral cov = new ConvertImproperFractionToMixedNumeral();
            Assert.AreEqual(cov.convertToMixedNumeral("6/2"), "3");
            Assert.AreEqual(cov.convertToMixedNumeral("74/3"), "24 2/3");
            Assert.AreEqual(cov.convertToMixedNumeral("-504/26"), "-19 10/26");
            Assert.AreEqual(cov.convertToMixedNumeral("9/18"), "9/18");
        }
    }
}