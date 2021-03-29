using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HellsKitchenTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("WH@T!!!! F*CK!!!! D@MN!!!! C@K*!!!!", HellsKitchen.Gordon("What feck damn cake"));
            Assert.AreEqual("@R*!!!! Y**!!!! ST*!!!! P*D!!!!", HellsKitchen.Gordon("are you stu pid"));
            Assert.AreEqual("*!!!! @M!!!! @!!!! CH*F!!!!", HellsKitchen.Gordon("i am a chef"));
        }
    }
}