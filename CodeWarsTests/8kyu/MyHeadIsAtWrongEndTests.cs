using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MyHeadIsAtWrongEndTests
    {
        private static Random rnd = new Random();

        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new string[] { "head", "body", "tail" }, MyHeadIsAtWrongEnd.FixTheMeerkat(new string[] { "tail", "body", "head" }));
            Assert.AreEqual(new string[] { "heads", "body", "tails" }, MyHeadIsAtWrongEnd.FixTheMeerkat(new string[] { "tails", "body", "heads" }));
            Assert.AreEqual(new string[] { "top", "middle", "bottom" }, MyHeadIsAtWrongEnd.FixTheMeerkat(new string[] { "bottom", "middle", "top" }));
            Assert.AreEqual(new string[] { "upper legs", "torso", "lower legs" }, MyHeadIsAtWrongEnd.FixTheMeerkat(new string[] { "lower legs", "torso", "upper legs" }));
            Assert.AreEqual(new string[] { "ground", "rainbow", "sky" }, MyHeadIsAtWrongEnd.FixTheMeerkat(new string[] { "sky", "rainbow", "ground" }));
        }
    }
}