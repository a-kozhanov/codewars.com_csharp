using System;
using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NeedleInHaystackTests
    {
        [Test]
        public void GenericTests()
        {
            var haystack_1 = new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false };
            var haystack_2 = new object[]
            {
                "283497238987234", "a dog", "a cat", "some random junk", "a piece of hay", "needle",
                "something somebody lost a while ago"
            };
            var haystack_3 = new object[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 8, 7, 5, 4, 3, 4, 5, 6, 67, 5, 5, 3, 3, 4, 2, 34, 234, 23, 4, 234, 324, 324,
                "needle", 1, 2, 3, 4, 5, 5, 6, 5, 4, 32, 3, 45, 54
            };

            Assert.AreEqual("found the needle at position 3", NeedleInHaystack.FindNeedle(haystack_1));
            Assert.AreEqual("found the needle at position 5", NeedleInHaystack.FindNeedle(haystack_2));
            Assert.AreEqual("found the needle at position 30", NeedleInHaystack.FindNeedle(haystack_3));
        }

        [Test]
        public static void zRandomTests()
        {
            Console.WriteLine("\n ********** 50 Random Tests **********");
            Random rnd = new Random();
            List<object> list = new List<object>();
            for (int i = 0; i < 50; i++)
            {
                list.Clear();
                int rando = rnd.Next(1, 100);
                int randomIndex = rnd.Next(0, rando);
                for (int j = 0; j < rando; j++)
                {
                    if (j == randomIndex)
                    {
                        list.Add("needle");
                    }
                    else
                    {
                        int n = rnd.Next(0, 500);
                        list.Add(n);
                    }
                }

                Assert.AreEqual("found the needle at position " + randomIndex,
                    NeedleInHaystack.FindNeedle(list.ToArray()));
            }
        }
    }
}