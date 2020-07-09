using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace ConsoleTestApp
{
    class Program
    {
        public static Byte[] CompressString(string value)
        {
            Byte[] byteArray = new byte[0];
            if (!string.IsNullOrEmpty(value))
            {
                byteArray = Encoding.UTF8.GetBytes(value);
                using (MemoryStream stream = new MemoryStream())
                {
                    using (GZipStream zip = new GZipStream(stream, CompressionMode.Compress))
                    {
                        zip.Write(byteArray, 0, byteArray.Length);
                    }

                    byteArray = stream.ToArray();
                }
            }

            return byteArray;
        }

        public static string DecompressString(Byte[] value)
        {
            string resultString = string.Empty;
            if (value != null && value.Length > 0)
            {
                using (MemoryStream stream = new MemoryStream(value))
                using (GZipStream zip = new GZipStream(stream, CompressionMode.Decompress))
                using (StreamReader reader = new StreamReader(zip))
                {
                    resultString = reader.ReadToEnd();
                }
            }

            return resultString;
        }


        static void Main(string[] args)
        {
            // byte[] arr1 = {31,139,8,0,0,0,0,0,0,10,115,74,76,170,84,40,206,72,44,202,214,81,72,201,207,199,134,121,185,156,104,160,72,145,151,203,55,63,55,151,176,22,26,169,2,218,239,146,152,146,66,88,15,141,84,1,237,119,47,74,204,75,201,77,36,168,139,166,234,96,238,40,32,82,95,1,141,212,1,221,225,147,90,162,94,172,144,158,175,144,81,154,87,130,71,31,77,213,1,221,17,84,154,167,144,88,158,88,169,243,168,97,25,0,159,61,7,108,32,3,0,0};
            //
            // using var stream = new MemoryStream(arr1);
            // using var zip = new GZipStream(stream, CompressionMode.Decompress);
            // using var reader = new StreamReader(zip);
            // //return reader.ReadToEnd();
            // Console.WriteLine(reader.ReadToEnd());
            //
            // //var cs = CompressString("doo doo doo doo doo doo");
            // //var ds = DecompressString(cs);
            //
            // //Console.WriteLine(ds);
            //
            // return;
            //
            // //var v1,v2 = "1", "2";
            // string b = "Baby",
            //     s = " shark",
            //     o = " doo doo doo doo doo doo\n",
            //     m = "Mommy",
            //     d = "Daddy",
            //     g = "Grandma",
            //     p = "Grandpa",
            //     h = "Let's go hunt",
            //     c = ",",
            //     e = "!",
            //     n = "\n";
            //
            // // var b = "Baby";
            // // var s = " shark";
            // // var o = " doo doo doo doo doo doo\n";
            // // var m = "Mommy";
            // // var d = "Daddy";
            // // var g = "Grandma";
            // // var p = "Grandpa";
            // // var h = "Let's go hunt";
            // // var c = ",";
            // // var e = "!";
            // // var n = "\n";
            //
            // var r = b + s + c + o + b + s + c + o + b + s + c + o;
            // r += b + s + e + n;
            //
            //
            // r += m + s + c + o + m + s + c + o + m + s + c + o;
            // r += m + s + e + n;
            //
            //
            // r += d + s + c + o + d + s + c + o + d + s + c + o;
            // r += d + s + e + n;
            //
            // r += g + s + c + o + g + s + c + o + g + s + c + o;
            // r += g + s + e + n;
            //
            // r += p + s + c + o + p + s + c + o + p + s + c + o;
            // r += p + s + e + n;
            //
            // r += h + c + o + h + c + o + h + c + o;
            //
            // r += h + e + n;
            //
            // r += "Run away,…\n";

            //return r;
        }
    }
}