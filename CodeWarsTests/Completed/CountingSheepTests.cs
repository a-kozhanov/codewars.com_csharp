using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CountingSheepTests
    {
        [Test]
        public void NumberOfTruesInArrayReturned()
        {
            var sheeps = new bool[] { true, false, true };

            Assert.AreEqual(2, CountingSheep.CountSheeps(sheeps));

            sheeps = new bool[] { true, false, true, true, false, true, true, false, true };

            Assert.AreEqual(6, CountingSheep.CountSheeps(sheeps));

            sheeps = new bool[] { true, true, true, true, true, true, true, true, true };

            Assert.AreEqual(9, CountingSheep.CountSheeps(sheeps));

            sheeps = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false };

            Assert.AreEqual(0, CountingSheep.CountSheeps(sheeps));
        }
    }
}