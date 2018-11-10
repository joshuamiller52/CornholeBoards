using System;
using ws281x.Net;
namespace Scoreboard
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Neopixel(1, 18);
            a.Begin();
        }
    }
}