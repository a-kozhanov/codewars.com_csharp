using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DeleteOccurrencesElementTests
    {
        [Test]
        public void TestSimple()
        {
            var expected = new int[] {20, 37, 21};

            var actual = DeleteOccurrencesElement.DeleteNth(new int[] {20, 37, 20, 21}, 1);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSimple2()
        {
            var expected = new int[] {1, 1, 3, 3, 7, 2, 2, 2};

            var actual = DeleteOccurrencesElement.DeleteNth(new int[] {1, 1, 3, 3, 7, 2, 2, 2, 2}, 3);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}