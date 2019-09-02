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
            Assert.AreEqual("#####", StringRepeat.repeatStr(5, "#"));
            Assert.AreEqual("ha ha ", StringRepeat.repeatStr(2, "ha "));
        }

    }
}