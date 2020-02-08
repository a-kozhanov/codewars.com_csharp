using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CompletePattern1Tests
    {
        CompletePattern1 k = new CompletePattern1();

        [Test]
        public void SimpleNumbers()
        {
            Assert.AreEqual("1", k.Pattern(1));
            Assert.AreEqual("1\n22", k.Pattern(2));
            Assert.AreEqual("1\n22\n333\n4444\n55555", k.Pattern(5));
        }
    }
}