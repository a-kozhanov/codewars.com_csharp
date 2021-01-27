using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class EqualizeArrayTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new[] {"+0", "+10", "+15", "-10"}, EqualizeArray.Equalize(new[] {20, 30, 35, 10}));
            Assert.AreEqual(new string[] { }, EqualizeArray.Equalize(new int[] { }));
            Assert.AreEqual(new[] {"+0", "+2", "+14", "+40", "-10", "+5", "+10"},
                EqualizeArray.Equalize(new[] {10, 12, 24, 50, 0, 15, 20}));
        }
    }
}