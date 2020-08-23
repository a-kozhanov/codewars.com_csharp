using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SmallEnoughBeginnerTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(true, SmallEnoughBeginner.SmallEnough(new int[] {66, 101}, 200));

            Assert.AreEqual(false,
                SmallEnoughBeginner.SmallEnough(new int[] {78, 117, 110, 99, 104, 117, 107, 115}, 100));

            Assert.AreEqual(true, SmallEnoughBeginner.SmallEnough(new int[] {101, 45, 75, 105, 99, 107}, 107));

            Assert.AreEqual(true,
                SmallEnoughBeginner.SmallEnough(new int[] {80, 117, 115, 104, 45, 85, 112, 115}, 120));
        }
    }
}