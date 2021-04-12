using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class EasyWallpaperTests
    {
        private static void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            testing(EasyWallpaper.WallPaper(6.3, 4.5, 3.29), "sixteen");
            testing(EasyWallpaper.WallPaper(7.8, 2.9, 3.29), "sixteen");
            testing(EasyWallpaper.WallPaper(6.3, 5.8, 3.13), "seventeen");
            testing(EasyWallpaper.WallPaper(6.1, 6.7, 2.81), "sixteen");
        }
    }
}