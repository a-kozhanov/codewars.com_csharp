using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GrasshopperTerminalGameMoveTests
    {
        [Test]
        public void Test1()
        {
            Assert.That(GrasshopperTerminalGameMove.Move(0, 4), Is.EqualTo(8));
        }
    }
}