using System;
using CodeWars;
using NUnit.Framework;
using System.Reflection;

namespace CodeWarsTests
{
    public static class Helper
    {
        public static int GetUnalteredNumber(this CustomAccessors na)
        {
            FieldInfo fi = typeof(CustomAccessors).GetField("_number", BindingFlags.NonPublic | BindingFlags.Instance);
            return (int) fi.GetValue(na);
        }
    }

    [TestFixture]
    public class CustomAccessorsTests
    {
        [Test]
        public void ValidSetterOnlyCheck1()
        {
            //sut --> subject under test
            var sut = new CustomAccessors();
            sut.Number = 26;
            Assert.AreEqual(26, sut.GetUnalteredNumber());
        }

        [Test]
        public void ValidSetterOnlyCheck2()
        {
            var sut = new CustomAccessors();
            sut.Number = 24;
            Assert.AreEqual(24, sut.GetUnalteredNumber());
        }

        [Test]
        public void ValidSetterOnlyCheck3()
        {
            var sut = new CustomAccessors();
            sut.Number = 0;
            Assert.AreEqual(0, sut.GetUnalteredNumber());
        }

        [Test]
        public void OddValuedSetterCheck1()
        {
            var sut = new CustomAccessors();
            try
            {
                sut.Number = 11;
            }
            catch (ArgumentException e)
            {
                Assert.Pass("Correct exception type thrown");
            }

            Assert.Fail("Expected exception on odd value input");
        }

        [Test]
        public void OddValuedSetterCheck2()
        {
            var sut = new CustomAccessors();
            try
            {
                sut.Number = 19;
            }
            catch (ArgumentException e)
            {
                Assert.Pass("Correct exception type thrown");
            }

            Assert.Fail("Expected exception on odd value input");
        }

        [Test]
        public void OddValuedSetterCheck3()
        {
            var sut = new CustomAccessors();
            try
            {
                sut.Number = 77;
            }
            catch (ArgumentException e)
            {
                Assert.Pass("Correct exception type thrown");
            }

            Assert.Fail("Expected exception on odd value input");
        }

        [Test]
        public void OddValuedSetterCheck4()
        {
            var sut = new CustomAccessors();
            try
            {
                sut.Number = -33;
            }
            catch (ArgumentException e)
            {
                Assert.Pass("Correct exception type thrown");
            }

            Assert.Fail("Expected exception on odd value input");
        }

        [Test]
        public void GetterAndSetterCheck1()
        {
            //sut --> subject under test
            var sut = new CustomAccessors();
            sut.Number = 4;
            Assert.AreEqual(2, sut.Number);
        }

        [Test]
        public void GetterAndSetterCheck2()
        {
            //sut --> subject under test
            var sut = new CustomAccessors();
            sut.Number = 6;
            Assert.AreEqual(3, sut.Number);
        }

        [Test]
        public void GetterAndSetterCheck3()
        {
            //sut --> subject under test
            var sut = new CustomAccessors();
            sut.Number = -8;
            Assert.AreEqual(-4, sut.Number);
        }

        [Test]
        public void GetterAndSetterCheck4()
        {
            //sut --> subject under test
            var sut = new CustomAccessors();
            sut.Number = 104;
            Assert.AreEqual(52, sut.Number);
        }

        [Test]
        public void RandomValueCheck()
        {
            var sut = new CustomAccessors();
            Random rng = new Random();
            for (var i = 0; i < 100; i++)
            {
                var a = rng.Next(-2000, 2000);
                if (a % 2 == 0)
                {
                    sut.Number = a;
                    Assert.AreEqual(a / 2, sut.Number);
                    Assert.AreEqual(a, sut.GetUnalteredNumber());
                }
                else
                {
                    try
                    {
                        sut.Number = a;
                    }
                    catch (ArgumentException e)
                    {
                        continue;
                    }

                    Assert.Fail("Expected exception on odd value input");
                }
            }
        }
    }
}