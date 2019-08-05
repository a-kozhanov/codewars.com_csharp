using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    class BeginnerLostWithoutMapTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new[] { 2, 4, 6 }, BeginnerLostWithoutMap.Maps(new[] { 1, 2, 3 }));
            Assert.AreEqual(new[] { 8, 2, 2, 2, 8 }, BeginnerLostWithoutMap.Maps(new[] { 4, 1, 1, 1, 4 }));
            Assert.AreEqual(new[] { 4, 4, 4, 4, 4, 4 }, BeginnerLostWithoutMap.Maps(new[] { 2, 2, 2, 2, 2, 2 }));
        }
    }
}
