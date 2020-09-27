/*
https://www.codewars.com/kata/52e88b39ffb6ac53a400022e/csharp

5 kyu
int32 to IPv4

Take the following IPv4 address: 128.32.10.1

This address has 4 octets where each octet is a single byte (or 8 bits).

1st octet 128 has the binary representation: 10000000
2nd octet 32 has the binary representation: 00100000
3rd octet 10 has the binary representation: 00001010
4th octet 1 has the binary representation: 00000001
So 128.32.10.1 == 10000000.00100000.00001010.00000001

Because the above IP address has 32 bits, we can represent it as the unsigned 32 bit number: 2149583361

Complete the function that takes an unsigned 32 bit number and returns a string representation of its IPv4 address.

Examples
2149583361 ==> "128.32.10.1"
32         ==> "0.0.0.32"
0          ==> "0.0.0.0"
*/


using System;
using System.Linq;
using System.Net;

//using static System.Net.IPAddress;

namespace CodeWars
{
    public class int32ToIPv4
    {
        public static string UInt32ToIP(uint ip)
        {
            //return ((ip & 0xFF000000) >> 24) + "." + ((ip & 0x00FF0000) >> 16) + "." + ((ip & 0x0000FF00) >> 8) + "." + (ip & 0x000000FF);
            //return $"{(byte) (ip >> 24)}.{(byte) (ip >> 16)}.{(byte) (ip >> 8)}.{(byte) ip}";
            //return string.Join(".", (new int[] {24, 16, 8, 0}).Select(e => ip >> e & 255));
            //return new IPAddress(BitConverter.GetBytes(ip).Reverse().ToArray()).ToString();
            //return $"{ip >> 24}.{(ip >> 16) & 0xFF}.{(ip >> 8) & 0xFF}.{ip & 0xFF}";
            //return $"{ip >> 24}.{ip >> 16 & 255}.{ip >> 8 & 255}.{ip & 255}";
            //return string.Join(".", BitConverter.GetBytes(ip).Reverse());
            //return IPAddress.Parse(ip.ToString()).ToString();
            //return IPAddress.Parse($"{ip}").ToString();
            return $"{IPAddress.Parse($"{ip}")}";
        }
    }
}