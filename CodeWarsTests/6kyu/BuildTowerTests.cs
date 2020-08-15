using System;
using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BuildTowerTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(string.Join(",", new[] {"*"}), string.Join(",", BuildTower.TowerBuilder(1)));
            Assert.AreEqual(string.Join(",", new[] {" * ", "***"}), string.Join(",", BuildTower.TowerBuilder(2)));
            Assert.AreEqual(string.Join(",", new[] {"  *  ", " *** ", "*****"}),
                string.Join(",", BuildTower.TowerBuilder(3)));
        }

        [Test]
        public void RandomTests()
        {
            var rand = new Random();

            Func<int, string[]> myTowerBuilder = delegate(int nFloors)
            {
                string[] lines = new string[nFloors];
                for (var i = 1; i <= nFloors; i++)
                {
                    lines[i - 1] = (new string(' ', nFloors - i) + new string('*', i * 2 - 1) +
                                    new string(' ', nFloors - i));
                }

                return lines;
            };

            var seq = Enumerable.Range(1, 100).ToArray();
            for (int r = 0; r < 100; r++)
            {
                for (int p = 0; p < 100; p++)
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        var temp = seq[r];
                        seq[r] = seq[p];
                        seq[p] = temp;
                    }
                }
            }

            for (int r = 0; r < 100; r++)
            {
                var n = seq[r];
                //Console.WriteLine(n);
                Assert.AreEqual(string.Join(",", myTowerBuilder(n)), string.Join(",", BuildTower.TowerBuilder(n)));
            }
        }
    }
}