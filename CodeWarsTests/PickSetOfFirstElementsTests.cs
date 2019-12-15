using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PickSetOfFirstElementsTests
    {
        [Test]
        public void BasicTests()
        {
            var arr = new object[] { 'a', 'b', 'c', 'd', 'e' };
            Assert.AreEqual(new object[] { 'a' }, PickSetOfFirstElements.TakeFirstElements(arr));
            Assert.AreEqual(new object[] { 'a', 'b' }, PickSetOfFirstElements.TakeFirstElements(arr, 2));
        }
    }
}