using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun193MomentOfTimeInSpaceTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun193MomentOfTimeInSpace();

            Assert.AreEqual(new bool[] {false, false, true}, kata.MomentOfTimeInSpace("12:30 am"));

            Assert.AreEqual(new bool[] {false, true, false}, kata.MomentOfTimeInSpace("12:02 pm"));

            Assert.AreEqual(new bool[] {true, false, false}, kata.MomentOfTimeInSpace("01:00 pm"));

            Assert.AreEqual(new bool[] {false, false, true}, kata.MomentOfTimeInSpace("11:12 am"));

            Assert.AreEqual(new bool[] {false, false, true}, kata.MomentOfTimeInSpace("05:20 pm"));

            Assert.AreEqual(new bool[] {false, true, false}, kata.MomentOfTimeInSpace("04:20 am"));
        }
    }
}