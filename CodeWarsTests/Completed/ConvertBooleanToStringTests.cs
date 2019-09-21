using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ConvertBooleanToStringTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("True", ConvertBooleanToString.boolean_to_string(true));
            Assert.AreEqual("False", ConvertBooleanToString.boolean_to_string(false));
        }
    }
}