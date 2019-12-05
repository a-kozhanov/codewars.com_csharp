using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    class EnumerableMagic2TrueForAnyTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(true, EnumerableMagic2TrueForAny.Any(new int[] { 1, 2, 3, 4 }, v => v > 3));
            Assert.AreEqual(false, EnumerableMagic2TrueForAny.Any(new int[] { 1, 2, 3, 4 }, v => v > 4));
        }
    }
}
