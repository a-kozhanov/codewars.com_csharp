using System;
using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FunES62AnimalsAndInheritanceTests
    {
        public static class Utility
        {
            private static Random rnd = new Random();

            public static string RandomToken() =>
                string.Concat(new char[rnd.Next(10, 20)].Select(_ => (char) rnd.Next(97, 123)));

            public static int RandomAge() => rnd.Next(0, 101);
        }


        [Test, Description("should construct an object properly")]
        public void ConstructorTest()
        {
            FunES62AnimalsAndInheritance.Dog doug =
                new FunES62AnimalsAndInheritance.Dog("Doug", 12, "Serving his master", "Eliza");
            Assert.AreEqual("Doug", doug.Name);
            Assert.AreEqual(12, doug.Age);
            Assert.AreEqual(4, doug.Legs);
            Assert.AreEqual("dog", doug.Species);
            Assert.AreEqual("Serving his master", doug.Status);
            Assert.AreEqual("Hello Eliza", doug.GreetMaster());
        }


        [TestFixture]
        public class SharkTest
        {
            [Test, Description("should construct an object properly")]
            public void ConstructorTest()
            {
                FunES62AnimalsAndInheritance.Shark billy =
                    new FunES62AnimalsAndInheritance.Shark("Billy", 3, "Alive and well");
                Assert.AreEqual("Billy", billy.Name);
                Assert.AreEqual(3, billy.Age);
                Assert.AreEqual(0, billy.Legs);
                Assert.AreEqual("shark", billy.Species);
                Assert.AreEqual("Alive and well", billy.Status);
                Assert.AreEqual("Hello, my name is Billy and I am 3 years old.", billy.Introduce());
                FunES62AnimalsAndInheritance.Shark charles =
                    new FunES62AnimalsAndInheritance.Shark("Charles", 8, "Looking for a mate");
                Assert.AreEqual("Charles", charles.Name);
                Assert.AreEqual(8, charles.Age);
                Assert.AreEqual(0, charles.Legs);
                Assert.AreEqual("shark", charles.Species);
                Assert.AreEqual("Looking for a mate", charles.Status);
                Assert.AreEqual("Hello, my name is Charles and I am 8 years old.", charles.Introduce());
            }

            [Test, Description("should work for random tests as well")]
            public void RandomTest()
            {
                for (int i = 0; i < 100; ++i)
                {
                    string a = Utility.RandomToken();
                    int b = Utility.RandomAge();
                    string c = Utility.RandomToken();
                    FunES62AnimalsAndInheritance.Shark s = new FunES62AnimalsAndInheritance.Shark(a, b, c);

                    Assert.AreEqual(a, s.Name);
                    Assert.AreEqual(b, s.Age);
                    Assert.AreEqual(0, s.Legs);
                    Assert.AreEqual("shark", s.Species);
                    Assert.AreEqual(c, s.Status);
                    Assert.AreEqual($"Hello, my name is {a} and I am {b} years old.", s.Introduce());
                }
            }
        }


        [TestFixture]
        public class CatTest
        {
            [Test, Description("should construct an object properly")]
            public void ConstructorTest()
            {
                FunES62AnimalsAndInheritance.Cat cathy =
                    new FunES62AnimalsAndInheritance.Cat("Cathy", 7, "Playing with a ball of yarn");
                Assert.AreEqual("Cathy", cathy.Name);
                Assert.AreEqual(7, cathy.Age);
                Assert.AreEqual(4, cathy.Legs);
                Assert.AreEqual("cat", cathy.Species);
                Assert.AreEqual("Playing with a ball of yarn", cathy.Status);
                Assert.AreEqual("Hello, my name is Cathy and I am 7 years old.  Meow meow!", cathy.Introduce());

                FunES62AnimalsAndInheritance.Cat spitsy = new FunES62AnimalsAndInheritance.Cat("Spitsy", 6, "sleeping");
                Assert.AreEqual("Spitsy", spitsy.Name);
                Assert.AreEqual(6, spitsy.Age);
                Assert.AreEqual(4, spitsy.Legs);
                Assert.AreEqual("cat", spitsy.Species);
                Assert.AreEqual("sleeping", spitsy.Status);
                Assert.AreEqual("Hello, my name is Spitsy and I am 6 years old.  Meow meow!", spitsy.Introduce());
            }

            [Test, Description("should work for random tests as well")]
            public void RandomTest()
            {
                for (int i = 0; i < 100; ++i)
                {
                    string a = Utility.RandomToken();
                    int b = Utility.RandomAge();
                    string c = Utility.RandomToken();
                    FunES62AnimalsAndInheritance.Cat s = new FunES62AnimalsAndInheritance.Cat(a, b, c);

                    Assert.AreEqual(a, s.Name);
                    Assert.AreEqual(b, s.Age);
                    Assert.AreEqual(4, s.Legs);
                    Assert.AreEqual("cat", s.Species);
                    Assert.AreEqual(c, s.Status);
                    Assert.AreEqual($"Hello, my name is {a} and I am {b} years old.  Meow meow!", s.Introduce());
                }
            }
        }

        [TestFixture]
        public class DogTest
        {
            [Test, Description("should construct an object properly")]
            public void ConstructorTest()
            {
                FunES62AnimalsAndInheritance.Dog doug =
                    new FunES62AnimalsAndInheritance.Dog("Doug", 12, "Serving his master", "Eliza");
                Assert.AreEqual("Doug", doug.Name);
                Assert.AreEqual(12, doug.Age);
                Assert.AreEqual(4, doug.Legs);
                Assert.AreEqual("dog", doug.Species);
                Assert.AreEqual("Serving his master", doug.Status);
                Assert.AreEqual("Hello Eliza", doug.GreetMaster());
            }

            [Test, Description("should work for random tests as well")]
            public void RandomTest()
            {
                for (int i = 0; i < 100; ++i)
                {
                    string a = Utility.RandomToken();
                    int b = Utility.RandomAge();
                    string c = Utility.RandomToken(),
                        d = Utility.RandomToken();
                    FunES62AnimalsAndInheritance.Dog s = new FunES62AnimalsAndInheritance.Dog(a, b, c, d);

                    Assert.AreEqual(a, s.Name);
                    Assert.AreEqual(b, s.Age);
                    Assert.AreEqual(4, s.Legs);
                    Assert.AreEqual("dog", s.Species);
                    Assert.AreEqual(c, s.Status);
                    Assert.AreEqual($"Hello, my name is {a} and I am {b} years old.", s.Introduce());
                    Assert.AreEqual($"Hello {d}", s.GreetMaster());
                }
            }
        }
    }
}