using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class StringRepeatTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("***", StringRepeat.repeatStr(3, "*"));
        }
    }
}