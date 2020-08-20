using System;
using System.Linq;
using System.Text.RegularExpressions;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataValidPhoneNumberTests
    {
        [Test]
        public void Tests()
        {
            Assert.IsTrue(KataValidPhoneNumber.ValidPhoneNumber("(123) 456-7890"));
            Assert.IsFalse(KataValidPhoneNumber.ValidPhoneNumber("(1111)5X5 2345"));
        }

        [Test]
        public void FixedTests()
        {
            Assert.IsTrue(KataValidPhoneNumber.ValidPhoneNumber("(123) 456-7890"));
            Assert.IsFalse(KataValidPhoneNumber.ValidPhoneNumber("(1111)555 2345"));
            Assert.IsFalse(KataValidPhoneNumber.ValidPhoneNumber("(098) 123 4567"));
            Assert.IsFalse(KataValidPhoneNumber.ValidPhoneNumber("(123)456-7890"));
            Assert.IsFalse(KataValidPhoneNumber.ValidPhoneNumber("abc(123)456-7890"));
            Assert.IsFalse(KataValidPhoneNumber.ValidPhoneNumber("(123)456-7890abc"));
            Assert.IsFalse(KataValidPhoneNumber.ValidPhoneNumber("abc(123)456-7890abc"));
            Assert.IsFalse(KataValidPhoneNumber.ValidPhoneNumber("abc(123) 456-7890"));
            Assert.IsFalse(KataValidPhoneNumber.ValidPhoneNumber("(123) 456-7890abc"));
            Assert.IsFalse(KataValidPhoneNumber.ValidPhoneNumber("abc(123) 456-7890abc"));
            Assert.IsFalse(KataValidPhoneNumber.ValidPhoneNumber("xyz(123) 456-7890xyz"));
        }

        private static Random rnd = new Random();

        private static string generatePhoneNumber()
        {
            return
                $"({(char) rnd.Next(48, 58)}{(char) rnd.Next(48, 58)}{(char) rnd.Next(48, 58)}) {(char) rnd.Next(48, 58)}{(char) rnd.Next(48, 58)}{(char) rnd.Next(48, 58)}-{(char) rnd.Next(48, 58)}{(char) rnd.Next(48, 58)}{(char) rnd.Next(48, 58)}{(char) rnd.Next(48, 58)}";
        }

        private static string generateFakePhoneNumber()
        {
            return String.Concat(generatePhoneNumber().OrderBy(_ => rnd.Next()));
        }

        private static bool solution(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\(\d{3}\) \d{3}-\d{4}$");
        }

        [Test]
        public void RandomTest()
        {
            const int Tests = 1000;

            for (int i = 0; i < Tests; ++i)
            {
                string phoneNumber =
                    new Func<string>[] {generatePhoneNumber, generateFakePhoneNumber}[rnd.Next(0, 2)]();

                bool expected = solution(phoneNumber);
                bool actual = KataValidPhoneNumber.ValidPhoneNumber(phoneNumber);

                Assert.AreEqual(expected, actual);
            }
        }
    }
}