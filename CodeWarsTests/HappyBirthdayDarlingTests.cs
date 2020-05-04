using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HappyBirthdayDarlingTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("32? That's just 20, in base 16!", HappyBirthdayDarling.WomensAge(32));
            Assert.AreEqual("39? That's just 21, in base 19!", HappyBirthdayDarling.WomensAge(39));
            Assert.AreEqual("22? That's just 20, in base 11!", HappyBirthdayDarling.WomensAge(22));
            Assert.AreEqual("65? That's just 21, in base 32!", HappyBirthdayDarling.WomensAge(65));
            Assert.AreEqual("83? That's just 21, in base 41!", HappyBirthdayDarling.WomensAge(83));
        }
    }
}