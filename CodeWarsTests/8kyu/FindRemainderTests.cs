using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindRemainderTests
    {
        [Test, Description("Your solution should handle arguments and math as defined in specifications")]
        public void FixedTest()
        {
            Assert.AreEqual(2, FindRemainder.Remainder(17, 5), "Returned value should be the value left over after dividing as much as possible.");
            Assert.AreEqual(FindRemainder.Remainder(72, 13), FindRemainder.Remainder(13, 72), "The order the arguments are passed should not matter.");
            Assert.Throws<DivideByZeroException>(() => FindRemainder.Remainder(0, 1));
            Assert.Throws<DivideByZeroException>(() => FindRemainder.Remainder(0, 0));
        }
    }
}