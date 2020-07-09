using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SuzukiNeedsHelpLiningUpHisStudentsTests
    {
        [Test]
        public void BasicTest1()
        {
            String students = "Tadashi Takahiro Takao Takashi Takayuki Takehiko Takeo Takeshi Takeshi";

            String[] expected =
                {"Takehiko", "Takayuki", "Takahiro", "Takeshi", "Takeshi", "Takashi", "Tadashi", "Takeo", "Takao"};

            Assert.AreEqual(expected, SuzukiNeedsHelpLiningUpHisStudents.LineupStudents(students));
        }

        [Test]
        public void BasicTest2()
        {
            String students =
                "Michio Miki Mikio Minori Minoru Mitsuo Mitsuru Nao Naoki Naoko Noboru Nobu Nobuo Nobuyuki Nori Norio Osamu Rafu Raiden Ringo Rokuro Ronin Ryo Ryoichi Ryota Ryozo Ryuichi Ryuu Saburo Sadao Samuru Satoru Satoshi Seiichi Seiji Senichi Shichiro Shig Shigekazu Shigeo Shigeru Shima Shin Shinichi Shinji Shiro Shoichi Shoji Shuichi Shuji Shunichi Susumu Tadao Tadashi Takahiro Takao Takashi Takayuki Takehiko Takeo Takeshi Takeshi Takumi Tama Tamotsu Taro Tatsuo Tatsuya Teruo Tetsip Tetsuya Tomi Tomio Toru Toshi Toshiaki Toshihiro Toshio Toshiyuki Toyo Tsuneo Tsutomu Tsuyoshi Uyeda Yasahiro Yasuhiro Yasuo Yasushi Yemon Yogi Yoichi Yori Yoshi Yoshiaki Yoshihiro Yoshikazu Yoshimitsu Yoshinori Yoshio Yoshiro Yoshito Yoshiyuki Yuichi Yuji Yuki";

            String[] expected =
            {
                "Yoshimitsu", "Yoshiyuki", "Yoshinori", "Yoshikazu", "Yoshihiro", "Toshiyuki",
                "Toshihiro", "Shigekazu", "Yoshiaki", "Yasuhiro", "Yasahiro", "Tsuyoshi", "Toshiaki",
                "Takehiko", "Takayuki", "Takahiro", "Shunichi", "Shinichi", "Shichiro",
                "Nobuyuki", "Yoshito", "Yoshiro", "Yasushi", "Tsutomu", "Tetsuya", "Tatsuya",
                "Tamotsu", "Takeshi", "Takeshi", "Takashi", "Tadashi", "Shuichi", "Shoichi",
                "Shigeru", "Senichi", "Seiichi", "Satoshi", "Ryuichi", "Ryoichi", "Mitsuru",
                "Yuichi", "Yoshio", "Yoichi", "Tsuneo", "Toshio", "Tetsip", "Tatsuo", "Takumi",
                "Susumu", "Shinji", "Shigeo", "Satoru", "Samuru", "Saburo", "Rokuro", "Raiden",
                "Noboru", "Mitsuo", "Minoru", "Minori", "Michio", "Yoshi", "Yemon", "Yasuo",
                "Uyeda", "Toshi", "Tomio", "Teruo", "Takeo", "Takao", "Tadao", "Shuji", "Shoji",
                "Shiro", "Shima", "Seiji", "Sadao", "Ryozo", "Ryota", "Ronin", "Ringo", "Osamu",
                "Norio", "Nobuo", "Naoko", "Naoki", "Mikio", "Yuki", "Yuji", "Yori", "Yogi",
                "Toyo", "Toru", "Tomi", "Taro", "Tama", "Shin", "Shig", "Ryuu", "Rafu", "Nori",
                "Nobu", "Miki", "Ryo", "Nao"
            };

            Assert.AreEqual(expected, SuzukiNeedsHelpLiningUpHisStudents.LineupStudents(students));
        }
    }
}