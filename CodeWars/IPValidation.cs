using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

//https://www.codewars.com/kata/ip-validation/csharp
//https://www.codewars.com/kata/515decfd9dcfc23bb6000006/solutions/csharp

//IP Validation

//Write an algorithm that will identify valid IPv4 addresses in dot-decimal format.IPs should be considered valid if they consist of four octets, with values between 0 and 255, inclusive.

//Input to the function is guaranteed to be a single string.

//Examples

//Valid inputs:
//1.2.3.4
//123.45.67.

//Invalid inputs:
//1.2.3
//1.2.3.4.5
//123.456.78.90
//123.045.067.089

//Note that leading zeros (e.g. 01.02.03.04) are considered invalid.

namespace CodeWars
{
    public class IPValidation
    {
        public static bool is_valid_IP(string ipAddres)
        {
            const string pattern = @"^(?:(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])(\.(?!$)|$)){4}$";
            return Regex.IsMatch(ipAddres, pattern);
        }

        //Best Practices
        //public static bool is_valid_IP(string IpAddres)
        //{
        //    IPAddress ip;
        //    bool validIp = IPAddress.TryParse(IpAddres, out ip);
        //    return validIp && ip.ToString() == IpAddres;
        //}

    }
}
