using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class WeightOfItsContentsTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(80, WeightOfItsContents.ContentWeight(120, "2 times larger"));
        }

        [Test]
        public void LargerTest()
        {
            Assert.AreEqual(80, WeightOfItsContents.ContentWeight(120, "2 times larger"));
            Assert.AreEqual(120, WeightOfItsContents.ContentWeight(180, "2 times larger"));
            Assert.AreEqual(450, WeightOfItsContents.ContentWeight(500, "9 times larger"));
            Assert.AreEqual(980, WeightOfItsContents.ContentWeight(1000, "49 times larger"));
            Assert.AreEqual(999, WeightOfItsContents.ContentWeight(1000, "999 times larger"));
        }

        [Test]
        public void SmallerTest()
        {
            Assert.AreEqual(40, WeightOfItsContents.ContentWeight(120, "2 times smaller"));
            Assert.AreEqual(100, WeightOfItsContents.ContentWeight(300, "2 times smaller"));
            Assert.AreEqual(200, WeightOfItsContents.ContentWeight(1000, "4 times smaller"));
            Assert.AreEqual(20, WeightOfItsContents.ContentWeight(1000, "49 times smaller"));
            Assert.AreEqual(10, WeightOfItsContents.ContentWeight(10000, "999 times smaller"));
        }
    }
}