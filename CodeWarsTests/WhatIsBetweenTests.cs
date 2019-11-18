using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class WhatIsBetweenTests
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual(new int[] { 0, 1, 2, 3 }, WhatIsBetween.Between(0, 3));
        }
    }
}