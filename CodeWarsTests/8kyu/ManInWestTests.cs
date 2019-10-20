using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ManInWestTests
    {
        [Test, Description("should check if the bucket contains gold")]
        public void SampleTest()
        {
            Assert.AreEqual(true, ManInWest.CheckTheBucket(new string[] { "stone", "stone", "gold", "stone", "stone" }), "I will bye a teeth");
            Assert.AreEqual(false, ManInWest.CheckTheBucket(new string[] { "stone", "stone", "stone", "stone", "stone" }), "Not today");
            Assert.AreEqual(true, ManInWest.CheckTheBucket(new string[] { "gold", "gold", "gold", "gold", "gold" }), "I will bye a teeth");
        }
    }
}