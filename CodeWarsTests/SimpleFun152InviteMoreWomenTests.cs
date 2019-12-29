using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun152InviteMoreWomenTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun152InviteMoreWomen();
            Assert.AreEqual(true, kata.InviteMoreWomen(new int[] {1, -1, 1}));
            Assert.AreEqual(true, kata.InviteMoreWomen(new int[] {1, 1, 1}));
            Assert.AreEqual(false, kata.InviteMoreWomen(new int[] {-1, -1, -1}));
            Assert.AreEqual(false, kata.InviteMoreWomen(new int[] {1, -1}));
        }
    }
}