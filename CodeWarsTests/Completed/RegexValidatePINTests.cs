using System;
using System.Collections.Generic;
using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RegexValidatePINTests
    {
        [Test, Description("ValidatePin should return false for pins with length other than 4 or 6")]
        public void LengthTest()
        {
            Assert.AreEqual(false, RegexValidatePIN.ValidatePin("1"), "Wrong output for \"1\"");
            Assert.AreEqual(false, RegexValidatePIN.ValidatePin("12"), "Wrong output for \"12\"");
            Assert.AreEqual(false, RegexValidatePIN.ValidatePin("123"), "Wrong output for \"123\"");
            Assert.AreEqual(false, RegexValidatePIN.ValidatePin("12345"), "Wrong output for \"12345\"");
            Assert.AreEqual(false, RegexValidatePIN.ValidatePin("1234567"), "Wrong output for \"1234567\"");
            Assert.AreEqual(false, RegexValidatePIN.ValidatePin("-1234"), "Wrong output for \"-1234\"");
            Assert.AreEqual(false, RegexValidatePIN.ValidatePin("-12345"), "Wrong output for \"-12345\"");
            Assert.AreEqual(false, RegexValidatePIN.ValidatePin("1.234"), "Wrong output for \"1.234\"");
            Assert.AreEqual(false, RegexValidatePIN.ValidatePin("-1.234"), "Wrong output for \"-1.234\"");
            Assert.AreEqual(false, RegexValidatePIN.ValidatePin("00000000"), "Wrong output for \"00000000\"");
        }

        [Test, Description("ValidatePin should return false for pins which contain characters other than digits")]
        public void NonDigitTest()
        {
            Assert.AreEqual(false, RegexValidatePIN.ValidatePin("a234"), "Wrong output for \"a234\"");
            Assert.AreEqual(false, RegexValidatePIN.ValidatePin(".234"), "Wrong output for \".234\"");
        }

        [Test, Description("ValidatePin should return true for valid pins")]
        public void ValidTest()
        {
            Assert.AreEqual(true, RegexValidatePIN.ValidatePin("1234"), "Wrong output for \"1234\"");
            Assert.AreEqual(true, RegexValidatePIN.ValidatePin("0000"), "Wrong output for \"0000\"");
            Assert.AreEqual(true, RegexValidatePIN.ValidatePin("1111"), "Wrong output for \"1111\"");
            Assert.AreEqual(true, RegexValidatePIN.ValidatePin("123456"), "Wrong output for \"123456\"");
            Assert.AreEqual(true, RegexValidatePIN.ValidatePin("098765"), "Wrong output for \"098765\"");
            Assert.AreEqual(true, RegexValidatePIN.ValidatePin("000000"), "Wrong output for \"000000\"");
            Assert.AreEqual(true, RegexValidatePIN.ValidatePin("090909"), "Wrong output for \"090909\"");
        }

        [Test, Description("ValidatePin should return false in various edge cases")]
        public void EdgeCaseTest()
        {
            foreach (string s in edgeCaseStrings)
                Assert.AreEqual(false, RegexValidatePIN.ValidatePin(s), String.Format("Wrong output for \"{0}\"", s));
        }
        static readonly string[] edgeCaseStrings = new string[]{
      "",
      "123",
      "12345",
      "1234567",
      "1234567890",
      "1234x",
      "123456x",
      "12.0",
      "1234.0",
      "123456.0",
      "123\n",
      "1234\n",
      "09876\n",
      "098765\n",
      "-111",
      "111-",
      "-44444",
      "44444-",
      "+111",
      "+88888",
      "+1111",
      "-2018",
      "+234567",
      "-234567",
      "123/",
      "456:",
      "9¾9¾",
    };
    }

    [TestFixture]
    public class RandomTest
    {
        private static Random rnd = new Random();

        private static string digits = "0123456789";

        private static bool solution(string pin) => (pin.Length == 4 || pin.Length == 6) && pin.All(Char.IsDigit);

        private static IEnumerable<TestCaseData> randomTestCases
        {
            get
            {
                const int Tests = 100;

                for (int i = 0; i < Tests; ++i)
                {
                    List<char> validPin = new char[rnd.Next(2, 4) * 2].Select(_ => digits[rnd.Next(0, digits.Length)]).ToList();
                    if (rnd.Next(0, 2) == 0) { validPin[rnd.Next(0, validPin.Count)] = (char)rnd.Next(32, 127); }
                    string pin = String.Concat(validPin);

                    bool expected = solution(pin);

                    yield return new TestCaseData(pin).Returns(expected).SetDescription($"{pin} should be {(expected ? "valid" : "invalid")}");
                }
            }
        }

        [Test, TestCaseSource("randomTestCases")]
        public bool RandomTests(string pin) => RegexValidatePIN.ValidatePin(pin);

    }
}