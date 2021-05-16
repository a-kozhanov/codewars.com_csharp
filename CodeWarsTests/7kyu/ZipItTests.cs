using NUnit.Framework;

namespace CodeWars
{
    public class KataZipItTests
    {
        [Test]
        public void BasicTests()
        {
            var a = new object[] {1, 2, 3, 4, 5};
            var b = new object[] {'a', 'b', 'c', 'd', 'e'};

            Assert.AreEqual(new object[] {"1a", "2b", "3c", "4d", "5e"}, a.ZipIt(b, (c, d) => c + "" + d));
            Assert.AreEqual(new object[] {"a1", "b2", "c3", "d4", "e5"}, b.ZipIt(a, (c, d) => c + "" + d));
            Assert.AreEqual(new object[] {"a97", "b196", "c297", "d400", "e505"},
                b.ZipIt(a.ZipIt(b, (c, d) => ((int) c) * ((int) (char) d)), (c, d) => c + "" + d));
        }
    }
}