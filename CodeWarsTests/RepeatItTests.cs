using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RepeatItTests
    {
        [Test]
        public void Test1()
        {
            Assert.That(RepeatIt.RepeatString("*", 3), Is.EqualTo("***"));
        }
    }
}