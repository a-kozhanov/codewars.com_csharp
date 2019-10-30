using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class IfFunctionTests
    {
        [Test]
        public void BasicTest()
        {
            var a = false;

            IfFunction.If(true, () => a = true, () => a = false);

            Assert.True(a, "func1 should be called");
        }
    }
}