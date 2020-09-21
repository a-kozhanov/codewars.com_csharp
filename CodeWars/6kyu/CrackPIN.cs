/*
https://www.codewars.com/kata/5efae11e2d12df00331f91a6/csharp

6 kyu
Crack the PIN

Given is a md5 hash of a five digits long PIN. It is given as string. 
Md5 is a function to hash your password: "password123" ===> "482c811da5d5b4bc6d497ffa98491e38"

Why is this usefull? Hash functions like md5 can create a hash from string in a short time and it is impossible to find out the password, 
if you only got the hash. 
The only way is cracking it, means try every combination, hash it and compare it with the hash you want to crack. 
(There are also other ways of attacking md5 but that's another story) 
Every Website and OS is storing their passwords as hashes, so if a hacker gets access to the database, 
he can do nothing, as long the password is safe enough.

What is a hash: https://en.wikipedia.org/wiki/Hash_function#:~:text=A%20hash%20function%20is%20any,table%20called%20a%20hash%20table.

What is md5: https://en.wikipedia.org/wiki/MD5

Note: Many languages have build in tools to hash md5. If not, you can write your own md5 function or google for an example.

Here is another kata on generating md5 hashes: https://www.codewars.com/kata/password-hashes

Your task is to return the cracked PIN as string.

This is a little fun kata, to show you, how weak PINs are and how important a bruteforce protection is, if you create your own login.

If you liked this kata, here is an extension with short passwords: https://www.codewars.com/kata/59146f7b4670ba520900000a
*/

using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CodeWars
{
    public class CrackPIN
    {
        public static string crack(string hash)
        {
            return Enumerable.Range(0, 99999)
                .Select(x => $"{x:D5}")
                .First(s => string.Concat(MD5.Create().ComputeHash(new ASCIIEncoding().GetBytes(s))
                    .Select(x => $"{x:x2}")) == hash);


            // return Enumerable.Range(0, 99999).Select(x => $"{x:D5}").First(s =>
            //     hash == string.Concat(new MD5CryptoServiceProvider().ComputeHash(new ASCIIEncoding().GetBytes(s))
            //         .Select(x => $"{x:x2}")));


            // return Enumerable.Range(0, 99999).Select(x => $"{x:D5}").First(i =>
            //     hash == string.Concat(
            //         MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(i)).Select(x => $"{x:x2}")));


            // return Enumerable.Range(0, 99999)
            //     .Select(x => (string) x.ToString().PadLeft(5, '0'))
            //     .First(x => hash == BitConverter
            //         .ToString(MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(x)))
            //         .Replace("-", "").ToLower());


            // for (var i = 1; i <= 99999; i++)
            // {
            //     string pin = i.ToString().PadLeft(5, '0');
            //     string hash2 = BitConverter.ToString(MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(pin)))
            //         .Replace("-", "");
            //
            //     if (hash2.ToLower() == hash.ToLower())
            //     {
            //         return pin;
            //     }
            // }
            //
            // return "";
        }
    }
}