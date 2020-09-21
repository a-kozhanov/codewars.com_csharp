using System;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // byte[] hash = Encoding.ASCII.GetBytes("12345");
            // MD5 md5 = new MD5CryptoServiceProvider();
            // byte[] hashenc = md5.ComputeHash(hash);
            // string result = "";
            // foreach (var b in hashenc)
            // {
            //     result += b.ToString("x2");
            // }
            //
            // Console.WriteLine(result);
            Console.WriteLine("827ccb0eea8a706c4c34a16891f84e7b");

            //Console.WriteLine(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes("12345")));
            // string hash1 = BitConverter.ToString(MD5.Create().ComputeHash(Encoding.ASCII.GetBytes("12345")))
                // .Replace("-", "");
            // Console.WriteLine(hash1);


            string pin = "";
            string h1 = "827ccb0eea8a706c4c34a16891f84e7b"; 
            for (var i = 1; i < 99999; i++)
            {
                pin = i.ToString().PadLeft(5, '0');
                string hash2 = BitConverter.ToString(MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(pin)))
                    .Replace("-", "");

                if (hash2.ToLower() == h1.ToLower())
                {
                    Console.WriteLine("!!!!" + pin);
                    break;
                }
                //Console.WriteLine(pin);
            }
        }
    }
}