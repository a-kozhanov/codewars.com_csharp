using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ValidateMyPasswordTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("VALID", ValidateMyPassword.validator("Username123"));
            Assert.AreEqual("INVALID", ValidateMyPassword.validator("Username"));
            Assert.AreEqual("INVALID", ValidateMyPassword.validator("123"));
            Assert.AreEqual("INVALID", ValidateMyPassword.validator("Username123!"));
            Assert.AreEqual("INVALID", ValidateMyPassword.validator("ThisPasswordIsTooLong1234"));
        }
    }
}