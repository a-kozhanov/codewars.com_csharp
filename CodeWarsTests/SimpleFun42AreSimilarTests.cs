using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun42AreSimilarTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun42AreSimilar();

            Assert.AreEqual(true, kata.AreSimilar(new int[] {1, 2, 3}, new int[] {2, 1, 3}));

            Assert.AreEqual(true, kata.AreSimilar(new int[] {1, 2, 3}, new int[] {1, 2, 3}));

            Assert.AreEqual(false, kata.AreSimilar(new int[] {1, 2, 2}, new int[] {2, 1, 1}));

            Assert.AreEqual(false, kata.AreSimilar(new int[] {1, 2, 3}, new int[] {1, 10, 2}));

            Assert.AreEqual(true, kata.AreSimilar(new int[] {2, 3, 1}, new int[] {1, 3, 2}));

            Assert.AreEqual(false, kata.AreSimilar(new int[] {290, 341, 854}, new int[] {290, 341, 290}));

            Assert.AreEqual(false, kata.AreSimilar(new int[] {1, 1, 2}, new int[] {1, 2, 2}));

            Assert.AreEqual(false, kata.AreSimilar(
                new int[]
                {
                    57, 237, 965, 951, 520, 123, 926, 182, 236, 801, 295, 864, 196, 763, 296, 169, 668, 855, 67, 44,
                    808, 810, 794, 723, 204, 505, 404, 275, 359, 668, 413, 995, 167, 639, 514, 747, 259, 426, 87, 434,
                    60, 119, 295, 369, 357, 476, 522, 291, 760, 189, 34, 924, 522, 810, 976, 247, 443, 241, 746, 15,
                    719, 650, 824, 569, 388, 301, 696, 558, 248, 549, 911, 242, 767, 633, 985, 689, 514, 425, 365, 729,
                    983, 112, 515, 169, 633, 489
                },
                new int[]
                {
                    57, 746, 965, 951, 520, 123, 926, 182, 236, 801, 295, 864, 196, 763, 296, 169, 668, 855, 67, 44,
                    808, 810, 404, 723, 204, 505, 794, 275, 359, 668, 241, 995, 167, 639, 514, 747, 259, 426, 87, 434,
                    60, 119, 295, 369, 357, 476, 522, 291, 760, 189, 34, 924, 522, 810, 976, 247, 443, 413, 237, 15,
                    719, 650, 824, 569, 388, 301, 696, 558, 248, 549, 911, 242, 767, 633, 985, 689, 514, 425, 365, 729,
                    983, 112, 515, 169, 633, 489
                }));
        }
    }
}