using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SleighAuthenticationTests
    {
        [Test, Description("The Sleigh must authenticate with correct credentials")]
        public void CorrectTest()
        {
            Assert.That(SleighAuthentication.Authenticate("Santa Claus", "Ho Ho Ho!"));
        }

        [Test, Description("The Sleigh must not authenticate with incorrect credentials")]
        public void IncorrectTest()
        {
            Assert.That(!SleighAuthentication.Authenticate("Santa", "Ho Ho Ho!"));
            Assert.That(!SleighAuthentication.Authenticate("Santa Claus", "Ho Ho!"));
            Assert.That(!SleighAuthentication.Authenticate("jhoffner", "CodeWars"));
        }
    }
}