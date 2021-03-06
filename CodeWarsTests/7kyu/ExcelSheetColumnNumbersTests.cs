using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ExcelSheetColumnNumbersTests
    {
        [Test]
        public void Test1()
        {
            Console.WriteLine("****** Basic Tests");
            Assert.AreEqual(1, ExcelSheetColumnNumbers.TitleToNumber("A"));
            Assert.AreEqual(27, ExcelSheetColumnNumbers.TitleToNumber("AA"));
            Assert.AreEqual(52, ExcelSheetColumnNumbers.TitleToNumber("AZ"));
            Assert.AreEqual(53, ExcelSheetColumnNumbers.TitleToNumber("BA"));
            Assert.AreEqual(28779382963L, ExcelSheetColumnNumbers.TitleToNumber("CODEWARS"));
        }
    }
}