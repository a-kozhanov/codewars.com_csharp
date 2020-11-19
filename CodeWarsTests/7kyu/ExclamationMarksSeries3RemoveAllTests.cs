using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ExclamationMarksSeries3RemoveAllTests
    {
        [TestFixture]
        public class SolutionTest
        {
            [Test, Description("It should work for basic tests")]
            public void SampleTest()
            {
                Assert.AreEqual("Hi!", ExclamationMarksSeries3RemoveAll.Remove("Hi!"));
                Assert.AreEqual("Hi!!!", ExclamationMarksSeries3RemoveAll.Remove("Hi!!!"));
                Assert.AreEqual("Hi", ExclamationMarksSeries3RemoveAll.Remove("!Hi"));
                Assert.AreEqual("Hi!", ExclamationMarksSeries3RemoveAll.Remove("!Hi!"));
                Assert.AreEqual("Hi Hi!", ExclamationMarksSeries3RemoveAll.Remove("Hi! Hi!"));
                Assert.AreEqual("Hi", ExclamationMarksSeries3RemoveAll.Remove("Hi"));
            }
        }
    }
}