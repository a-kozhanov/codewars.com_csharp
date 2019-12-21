using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ExclamationMarksSeries2Tests
    {
        [Test, Description("It should work for basic tests")]
        public void SampleTest()
        {
            Assert.AreEqual("Hi", ExclamationMarksSeries2.Remove("Hi!"));
            Assert.AreEqual("Hi", ExclamationMarksSeries2.Remove("Hi!!!"));
            Assert.AreEqual("!Hi", ExclamationMarksSeries2.Remove("!Hi"));
            Assert.AreEqual("!Hi", ExclamationMarksSeries2.Remove("!Hi!"));
            Assert.AreEqual("Hi! Hi", ExclamationMarksSeries2.Remove("Hi! Hi"));
            Assert.AreEqual("Hi", ExclamationMarksSeries2.Remove("Hi"));
        }      
    }
}