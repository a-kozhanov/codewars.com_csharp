using System;
using System.Text.RegularExpressions;
using CodeWars;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun172CountNumberTests
    {
        public int An(double n, double x)
        {
            double r = 0, i = 1;
            for (; i * i < x; i++)
                if (x % i == 0 && n * i >= x)
                    r += (i <= n ? 1 : 0) + (x / i <= n ? 1 : 0);
            return (int) r + (i * i == x && i <= n ? 1 : 0);
        }

        public double[] rndtest()
        {
            double n, x, nn;
            var jl = rand(0, 3);
            if (jl == 0)
            {
                n = rand(1, 50);
                x = rand(1, 500);
            }
            else if (jl == 1)
            {
                nn = rand(1, 10);
                n = rand(2, 10) * rand(2, 10) * rand(2, 10) * rand(2, 10) * nn;
                x = rand(2, 10) * rand(2, 10) * rand(2, 10) * rand(2, 10) * nn;
            }
            else if (jl == 2)
            {
                n = rand(1, 10000);
                x = rand(1, 10000) * rand(1, 100000);
            }
            else
            {
                nn = rand(1, 1000);
                n = rand(2, 10) * rand(2, 10) * rand(2, 10) * rand(2, 10) * rand(2, 10) * rand(2, 10) * rand(2, 10) *
                    nn;
                x = rand(2, 10) * rand(2, 10) * rand(2, 10) * rand(2, 10) * rand(2, 10) * rand(2, 10) * rand(2, 10) *
                    nn;
            }

            return new double[] {n, x};
        }

        //Tools
        public void shuff(List<int> r)
        {
            for (int i = 0; i < 50; i++)
            {
                int idx1 = rand(0, r.Count - 1), idx2 = rand(0, r.Count - 1);
                var tt = r[idx1];
                r[idx1] = r[idx2];
                r[idx2] = tt;
            }
        }

        public string repeat(string c, int n)
        {
            var s = new string('&', n);
            return Regex.Replace(s, "&", c);
        }


        Random rndnum = new Random(unchecked((int) DateTime.Now.Ticks));

        public int rand(int a, int b)
        {
            return a > b ? rand(b, a) : rndnum.Next(a, b + 1);
        }

        public int[] rndarr(int minlen, int maxlen, int minv, int maxv)
        {
            var len = rand(minlen, maxlen);
            var r = new int[len];
            for (var i = 0; i < len; i++) r[i] = rand(minv, maxv);
            return r;
        }

        public string rnds(int n)
        {
            var len = n;
            var rs = new List<char>();
            for (int i = 0; i < len; i++) rs.Add(rndcl());
            return string.Join("", rs);
        }

        public string rndss(int n)
        {
            var len = n;
            var rs = new List<string>();
            for (int i = 0; i < len; i++) rs.Add(rnds(rand(3, 7)));
            return string.Join(" ", rs);
        }

        public string rnds2(int n)
        {
            var len = n;
            var rs = new List<char>();
            for (int i = 0; i < len; i++) rs.Add(rndch());
            return string.Join("", rs);
        }

        public char rndcl()
        {
            var allc = "abcdefghijklmnopqrstuvwxyz";
            return allc[rand(0, allc.Length - 1)];
        }

        public char rndchl()
        {
            var allc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return allc[rand(0, allc.Length - 1)];
        }

        public char rndch()
        {
            var allc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return allc[rand(0, allc.Length - 1)];
        }


        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun172CountNumber();

            Assert.AreEqual(2, kata.CountNumber(5, 5));

            Assert.AreEqual(2, kata.CountNumber(10, 5));

            Assert.AreEqual(4, kata.CountNumber(6, 12));

            Assert.AreEqual(16, kata.CountNumber(100000, 1000000000));

            Assert.AreEqual(0, kata.CountNumber(9, 484));
        }


        [Test]
        public void Test2__100_Random_Tests()
        {
            var kata = new SimpleFun172CountNumber();
            // var passed = "<font size=2 color='#8FBC8F'><b>Test Passed!</b></font>";

            for (int i = 0; i < 100; i++)
            {
                //var ab = rndtest();
                Console.WriteLine(string.Join(", ", rndtest()));

                var ab = new double[] {100, 1000};

                //var cd=rand(0,3)>0?rand(10000,1048576):rand(1,10000);
                //var cd=rand(0,100000);

                // Console.WriteLine("<font size=2 color='#CFB53B'>Testing for: " +
                //                   //"\narr = new int[]{"+string.Join(", ",ab)+"}"
                //                   //+"\nb = new int[]{"+string.Join(", ",ab[1])+"}"
                //                   "\nn = " + ab[0]
                //                   + "\nx = " + ab[1]
                //                   //+"\nc = "+ab[2]
                //                   //+", numberOfDigits = "+ab[1]
                //                   //+", loved = "+ab[2]
                //                   //+"\ncandy = "+ab[3]
                //                   + "</font>");

                //var answer = An(ab[0], ab[1]);
                var answer = An(ab[0], ab[1]);
                Assert.AreEqual(answer, kata.CountNumber(ab[0], ab[1]));

                Console.WriteLine("<font size=2 color='#8FBC8F'>" +
                                  "Pass Value = " + answer + "</font>\n");

                Console.WriteLine(" ");
            }
        }
    }
}