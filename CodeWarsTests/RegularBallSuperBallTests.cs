using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RegularBallSuperBallTests
    {
        [Test]
        public void DefaultConstructorShouldSetBallTypeToRegular()
        {
            Assert.AreEqual("regular", new RegularBallSuperBall().ballType);
        }

        [Test]
        public void ConstructorWithArgumentShouldSetBallTypeAsExpected()
        {
            Assert.AreEqual("super", new RegularBallSuperBall("super").ballType);
        }
    }
}