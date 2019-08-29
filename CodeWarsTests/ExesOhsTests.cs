using System;
using System.Collections.Generic;
using System.Text;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    class ExesOhsTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(true, ExesOhs.XO("xo"));
            Assert.AreEqual(true, ExesOhs.XO("xxOo"));
            Assert.AreEqual(false, ExesOhs.XO("xxxm"));
            Assert.AreEqual(false, ExesOhs.XO("Oo"));
            Assert.AreEqual(false, ExesOhs.XO("ooom"));
        }

        [Test]
        public void Tests()
        {
            Assert.AreEqual(true, ExesOhs.XO("xo"));
            Assert.AreEqual(true, ExesOhs.XO("XO"));
            Assert.AreEqual(true, ExesOhs.XO("xo0"));
            Assert.AreEqual(false, ExesOhs.XO("xxxoo"));
            Assert.AreEqual(true, ExesOhs.XO("xxOo"));
            Assert.AreEqual(true, ExesOhs.XO(""), "Empty string contains equal amount of x and o");
            Assert.AreEqual(true, ExesOhs.XO("xxxxxoooxooo"));
            Assert.AreEqual(false, ExesOhs.XO("xxxm"));
            Assert.AreEqual(false, ExesOhs.XO("ooom"));
            Assert.AreEqual(false, ExesOhs.XO("Oo"));
            Assert.AreEqual(true, ExesOhs.XO("abcdefghijklmnopqrstuvwxyz"), "Alphabet contains equal amount of x and o");
        }

    }
}
