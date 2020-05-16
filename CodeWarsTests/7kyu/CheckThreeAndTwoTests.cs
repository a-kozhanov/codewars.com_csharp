using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataCheckThreeAndTwoTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(true, KataCheckThreeAndTwo.CheckThreeAndTwo(new string[] {"a", "a", "a", "b", "b"}));
            Assert.AreEqual(false, KataCheckThreeAndTwo.CheckThreeAndTwo(new string[] {"a", "c", "a", "c", "b"}));
            Assert.AreEqual(false, KataCheckThreeAndTwo.CheckThreeAndTwo(new string[] {"a", "a", "a", "a", "a"}));
        }
    }
}