using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CompletePattern10ParallelogramTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("  123\n 123 \n123  ", CompletePattern10Parallelogram.Pattern(3));

            Assert.AreEqual("    12345\n   12345 \n  12345  \n 12345   \n12345    ",
                CompletePattern10Parallelogram.Pattern(5));

            Assert.AreEqual(
                "       12345678\n      12345678 \n     12345678  \n    12345678   \n   12345678    \n  12345678     \n 12345678      \n12345678       ",
                CompletePattern10Parallelogram.Pattern(8));
        }
    }
}