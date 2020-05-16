using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataElapsedSecondsTests
    {
        [Test]
        public void BasicTests()
        {
            var start = new DateTime(2013, 1, 1, 0, 0, 1);
            var end = new DateTime(2013, 1, 1, 0, 0, 2);
            var end2 = new DateTime(2013, 1, 1, 0, 0, 20);
            var end3 = new DateTime(2013, 1, 1, 0, 1, 20);
            Assert.AreEqual(1, KataElapsedSeconds.ElapsedSeconds(start, end));
            Assert.AreEqual(19, KataElapsedSeconds.ElapsedSeconds(start, end2));
            Assert.AreEqual(79, KataElapsedSeconds.ElapsedSeconds(start, end3));
        }
    }
}