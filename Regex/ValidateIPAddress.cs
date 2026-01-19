/* Validate an IP Address
A valid IPv4 address consists of four groups of numbers (0-255) separated by dots. */

using System;
using System.Text.RegularExpressions;

class ValidateIPAddress
{
    public static void Start()
    {
        string[] ips =
        {
            "192.168.1.1",   
            "255.255.255.0", 
            "256.1.1.1",     
            "192.168.1",     
            "01.2.3.4"       
        };

        foreach (string ip in ips)
        {
            Console.WriteLine($"{ip}" + (IsValidIp(ip) ? "Valid" : "Invalid"));
        }
    }

    // Validates IPv4 address
    static bool IsValidIp(string ip)
    {
        string pattern =
            @"^((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)\.){3}" +
            @"(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)$";

        return System.Text.RegularExpressions.Regex.IsMatch(ip, pattern);
    }
}
