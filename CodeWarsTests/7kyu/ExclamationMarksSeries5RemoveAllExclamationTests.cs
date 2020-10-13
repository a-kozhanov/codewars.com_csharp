using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ExclamationMarksSeries5RemoveAllExclamationTests
    {
        [Test, Description("It should work for basic tests")]
        public void SampleTest()
        {
            Assert.AreEqual("Hi", ExclamationMarksSeries5RemoveAllExclamation.Remove("Hi!"));
            Assert.AreEqual("Hi", ExclamationMarksSeries5RemoveAllExclamation.Remove("Hi!!!"));
            Assert.AreEqual("!Hi", ExclamationMarksSeries5RemoveAllExclamation.Remove("!Hi"));
            Assert.AreEqual("!Hi", ExclamationMarksSeries5RemoveAllExclamation.Remove("!Hi!"));
            Assert.AreEqual("Hi Hi", ExclamationMarksSeries5RemoveAllExclamation.Remove("Hi! Hi"));
            Assert.AreEqual("!!!Hi !!hi !hi", ExclamationMarksSeries5RemoveAllExclamation.Remove("!!!Hi !!hi!!! !hi"));
        }
    }
}