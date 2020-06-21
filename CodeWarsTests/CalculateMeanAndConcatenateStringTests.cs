using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CalculateMeanAndConcatenateStringTests
    {
        [Test]
        public void BasicTests()
        {
            var lst1 = new[]
                {'u', '6', 'd', '1', 'i', 'w', '6', 's', 't', '4', 'a', '6', 'g', '1', '2', 'w', '8', 'o', '2', '0'};
            Assert.AreEqual(new object[] {3.6, "udiwstagwo"}, CalculateMeanAndConcatenateString.Mean(lst1));

            var lst2 = new[]
                {'0', 'c', '7', 'x', '6', '2', '3', '5', 'w', '7', '0', 'y', 'v', 'u', 'h', 'i', 'n', 'u', '0', '0'};
            Assert.AreEqual(new object[] {3.0, "cxwyvuhinu"}, CalculateMeanAndConcatenateString.Mean(lst2));

            var lst3 = new[]
                {'0', 'u', 'a', 'y', '0', 'a', '9', 'q', '3', 'v', 'g', '7', '6', '4', 'y', 'd', '8', '6', '0', 'd'};
            Assert.AreEqual(new object[] {4.3, "uayaqvgydd"}, CalculateMeanAndConcatenateString.Mean(lst3));

            var lst4 = new[]
                {'s', 'n', '9', 'l', '0', 'm', 'i', 'z', '9', '7', 'y', '4', 'z', '3', '3', 'k', '4', '1', '0', 'k'};
            Assert.AreEqual(new object[] {4.0, "snlmizyzkk"}, CalculateMeanAndConcatenateString.Mean(lst4));

            var lst5 = new[]
                {'5', 'v', 'u', 'k', '8', '4', '9', 'b', '9', 'g', '5', 'z', '3', 'f', '6', 'u', 'i', '6', '6', 't'};
            Assert.AreEqual(new object[] {6.1, "vukbgzfuit"}, CalculateMeanAndConcatenateString.Mean(lst5));

            var lst6 = new[]
                {'1', '1', '1', '1', '1', '1', '1', '1', '1', '0', 'a', 'a', 'd', 'd', 'g', 'q', 'u', 'v', 'y', 'y'};
            Assert.AreEqual(new object[] {0.9, "aaddgquvyy"}, CalculateMeanAndConcatenateString.Mean(lst6));

            var lst7 = new[]
                {'1', '1', '1', '1', '1', '1', '1', '1', '1', '1', 'a', 'a', 'd', 'd', 'g', 'q', 'u', 'v', 'y', 'y'};
            Assert.AreEqual(new object[] {1.0, "aaddgquvyy"}, CalculateMeanAndConcatenateString.Mean(lst7));
        }
    }
}