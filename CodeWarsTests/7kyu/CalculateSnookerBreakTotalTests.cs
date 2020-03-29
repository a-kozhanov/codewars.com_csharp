using System;
using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CalculateSnookerBreakTotalTests
    {
        [Test]
        public void BasicTestFoul()
        {
            var pots = new CalculateSnookerBreakTotal.SnookerBall[] {CalculateSnookerBreakTotal.SnookerBall.Pink,};
            Assert.Throws<Exception>(() => { CalculateSnookerBreakTotal.SumBreak(pots); });
        }

        public static int ActualSnookerBreak(CalculateSnookerBreakTotal.SnookerBall[] pots)
        {
            if (pots == null || pots.Length == 0)
            {
                return 0;
            }

            int tot = 0;
            for (int i = 0; i < pots.Length; i++)
            {
                int shot = i + 1;
                CalculateSnookerBreakTotal.SnookerBall colour = pots[i];

                bool even = shot % 2 == 0;

                if (shot <= 30)
                {
                    if (even)
                    {
                        if (colour == CalculateSnookerBreakTotal.SnookerBall.Red)
                        {
                            throw new Exception("FOUL");
                        }
                    }
                    else
                    {
                        if (colour != CalculateSnookerBreakTotal.SnookerBall.Red)
                        {
                            throw new Exception("FOUL");
                        }
                    }
                }
                else if (shot == 31)
                {
                    if (colour != CalculateSnookerBreakTotal.SnookerBall.Yellow)
                    {
                        throw new Exception("FOUL");
                    }
                }
                else if (shot == 32)
                {
                    if (colour != CalculateSnookerBreakTotal.SnookerBall.Green)
                    {
                        throw new Exception("FOUL");
                    }
                }
                else if (shot == 33)
                {
                    if (colour != CalculateSnookerBreakTotal.SnookerBall.Brown)
                    {
                        throw new Exception("FOUL");
                    }
                }
                else if (shot == 34)
                {
                    if (colour != CalculateSnookerBreakTotal.SnookerBall.Blue)
                    {
                        throw new Exception("FOUL");
                    }
                }
                else if (shot == 35)
                {
                    if (colour != CalculateSnookerBreakTotal.SnookerBall.Pink)
                    {
                        throw new Exception("FOUL");
                    }
                }
                else if (shot == 36)
                {
                    if (colour != CalculateSnookerBreakTotal.SnookerBall.Black)
                    {
                        throw new Exception("FOUL");
                    }
                }

                tot += (int) colour;
            }

            return tot;
        }

        [Test]
        public void BasicTest()
        {
            var pots = new CalculateSnookerBreakTotal.SnookerBall[]
            {
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Pink
            };
            int tot = CalculateSnookerBreakTotal.SumBreak(pots);

            Assert.AreEqual(15, tot);
        }

        [Test]
        public void BasicTest147()
        {
            var pots = new CalculateSnookerBreakTotal.SnookerBall[]
            {
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Yellow, CalculateSnookerBreakTotal.SnookerBall.Green,
                CalculateSnookerBreakTotal.SnookerBall.Brown, CalculateSnookerBreakTotal.SnookerBall.Blue,
                CalculateSnookerBreakTotal.SnookerBall.Pink,
                CalculateSnookerBreakTotal.SnookerBall.Black,
            };
            int tot = CalculateSnookerBreakTotal.SumBreak(pots);

            Assert.AreEqual(147, tot);
        }

        [Test]
        public void SoClose()
        {
            var pots = new CalculateSnookerBreakTotal.SnookerBall[]
            {
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Yellow, CalculateSnookerBreakTotal.SnookerBall.Green,
                CalculateSnookerBreakTotal.SnookerBall.Brown, CalculateSnookerBreakTotal.SnookerBall.Blue,
                CalculateSnookerBreakTotal.SnookerBall.Pink,
            };
            int tot = CalculateSnookerBreakTotal.SumBreak(pots);

            Assert.AreEqual(140, tot);
        }

        [Test]
        public void Invalid()
        {
            var pots = new CalculateSnookerBreakTotal.SnookerBall[]
            {
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Yellow, CalculateSnookerBreakTotal.SnookerBall.Green,
                CalculateSnookerBreakTotal.SnookerBall.Brown, CalculateSnookerBreakTotal.SnookerBall.Blue,
                CalculateSnookerBreakTotal.SnookerBall.Pink,
                CalculateSnookerBreakTotal.SnookerBall.Pink,
            };
            Assert.Throws<Exception>(() => { CalculateSnookerBreakTotal.SumBreak(pots); });
        }

        [Test]
        public void BasicTestInvalidOrder()
        {
            var pots = new CalculateSnookerBreakTotal.SnookerBall[]
            {
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red, CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black, CalculateSnookerBreakTotal.SnookerBall.Red,
                CalculateSnookerBreakTotal.SnookerBall.Black,
                CalculateSnookerBreakTotal.SnookerBall.Yellow, CalculateSnookerBreakTotal.SnookerBall.Brown,
                CalculateSnookerBreakTotal.SnookerBall.Green, CalculateSnookerBreakTotal.SnookerBall.Pink,
                CalculateSnookerBreakTotal.SnookerBall.Blue,
                CalculateSnookerBreakTotal.SnookerBall.Black,
            };
            Assert.Throws<Exception>(() => { CalculateSnookerBreakTotal.SumBreak(pots); });
        }

        [Test]
        public void RandomTests()
        {
            var r = new Random();

            for (int i = 0; i < 50; i++)
            {
                var pots = new List<CalculateSnookerBreakTotal.SnookerBall>();

                int length = (r.Next() % 36) + 1;
                for (int j = 0; j < length; j++)
                {
                    int shot = j + 1;
                    bool even = shot % 2 == 0;

                    // 50/50 chance for potting a red on odd go...
                    if (shot <= 30 && !even)
                    {
                        bool isRed = r.Next() % 2 == 0;
                        if (isRed)
                        {
                            pots.Add(CalculateSnookerBreakTotal.SnookerBall.Red);
                        }
                        else
                        {
                            var pot = (CalculateSnookerBreakTotal.SnookerBall) ((r.Next() % 6) + 2);
                            pots.Add(pot);
                        }
                    }
                    else
                    {
                        var pot = (CalculateSnookerBreakTotal.SnookerBall) ((r.Next() % 7) + 1);
                        pots.Add(pot);
                    }
                }

                try
                {
                    int expected = ActualSnookerBreak(pots.ToArray());
                    int actual = CalculateSnookerBreakTotal.SumBreak(pots.ToArray());

                    Assert.AreEqual(expected, actual);
                }
                catch
                {
                    Assert.Throws<Exception>(() => { CalculateSnookerBreakTotal.SumBreak(pots.ToArray()); });
                }
            }
        }
    }
}