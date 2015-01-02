using System;
using Nancy.Hosting.Self;

using Saitek.X52.WebApi;

namespace X52ApiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = NancyHostFactory.CreateHost(33327))
            {
                host.Start();
                Console.WriteLine("Push any key to stop...");
                Console.Read();
            }
        }
    }
}
