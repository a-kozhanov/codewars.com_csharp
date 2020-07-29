using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var timespan = TimeSpan.FromSeconds(359999);

            int total_seconds = 359999;
            int hours = total_seconds / 3600;
            int minutes = total_seconds / 60 % 60;
            int seconds = total_seconds % 60;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
            Console.WriteLine($"{(int) timespan.TotalHours:00}:{timespan.Minutes:00}:{timespan.Seconds:00}");

            //Console.WriteLine(timespan.ToString());
            //Console.WriteLine(timespan.ToString(@"HH\:mm\:ss"));
            //Console.WriteLine(timespan.ToString("hh"));

            //var ts = new TimeSpan(0, 0, 359999);                
            //Console.WriteLine(new DateTime(ts.Ticks).ToString(359999 >= 3600 ? "hh:mm:ss" : "mm:ss"));
        }
    }
}