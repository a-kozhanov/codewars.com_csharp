using System.Collections.Generic;
using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CartesianNeighborsTests
    {
        public static IEnumerable<int[]> sortedList(IEnumerable<int[]> list)
        {
            return list.OrderBy(l => l[0]).ThenBy(l => l[1]);
        }

        public static IEnumerable<int[]> solution(int x, int y)
        {
            int[] m = {-1, 0, 1};
            return m.Select(d => m.Select(d2 => new int[] {x + d, y + d2})).SelectMany(d => d)
                .Where(d => !(d[0] == x && d[1] == y));
        }

        [Test]
        public void ExampleTests()
        {
            var r = new List<int[]>()
            {
                new int[] {1, 1},
                new int[] {1, 2},
                new int[] {1, 3},
                new int[] {2, 1},
                new int[] {2, 3},
                new int[] {3, 1},
                new int[] {3, 2},
                new int[] {3, 3},
            };
            var list = CartesianNeighbors.cartesianNeighbor(2, 2);
            Assert.AreEqual(r, sortedList(list));
        }

        [Test]
        public void ZeroValueTest()
        {
            var r = new List<int[]>()
            {
                new int[] {-1, -1},
                new int[] {-1, 0},
                new int[] {-1, 1},
                new int[] {0, -1},
                new int[] {0, 1},
                new int[] {1, -1},
                new int[] {1, 0},
                new int[] {1, 1},
            };
            var list = CartesianNeighbors.cartesianNeighbor(0, 0);
            Assert.AreEqual(r, sortedList(list), "Wrong Answer with input x=0, y=0");
        }

        [Test]
        public void NegativeValueTest()
        {
            var r = new List<int[]>()
            {
                new int[] {-6, -6},
                new int[] {-6, -5},
                new int[] {-6, -4},
                new int[] {-5, -6},
                new int[] {-5, -4},
                new int[] {-4, -6},
                new int[] {-4, -5},
                new int[] {-4, -4},
            };
            var list = CartesianNeighbors.cartesianNeighbor(-5, -5);
            Assert.AreEqual(r, sortedList(list), "Wrong Answer with input x=-5, y=-5");
        }

        [Test]
        public void MixedValueTest()
        {
            var r = new List<int[]>()
            {
                new int[] {-18, 6},
                new int[] {-18, 7},
                new int[] {-18, 8},
                new int[] {-17, 6},
                new int[] {-17, 8},
                new int[] {-16, 6},
                new int[] {-16, 7},
                new int[] {-16, 8},
            };
            var list = CartesianNeighbors.cartesianNeighbor(-17, 7);
            Assert.AreEqual(r, sortedList(list), "Wrong Answer with input x=-17, y=7");
        }

        [Test]
        public void RandomValueTest([Random(-100000, 100000, 10)] int x, [Random(-100000, 100000, 10)] int y)
        {
            var list = CartesianNeighbors.cartesianNeighbor(x, y);
            Assert.AreEqual(solution(x, y), sortedList(list));
        }
    }
}