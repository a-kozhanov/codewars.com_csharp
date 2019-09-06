using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RemoveStringSpacesTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual("8j8mBliB8gimjB8B8jlB", RemoveStringSpaces.NoSpace("8 j 8   mBliB8g  imjB8B8  jl  B"));
            Assert.AreEqual("88Bifk8hB8BB8BBBB888chl8BhBfd", RemoveStringSpaces.NoSpace("8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd"));
            Assert.AreEqual("8aaaaaddddr", RemoveStringSpaces.NoSpace("8aaaaa dddd r     "));
        }
    }
}