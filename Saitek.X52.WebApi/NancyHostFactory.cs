using System;
using Nancy.Hosting.Self;

namespace Saitek.X52.WebApi
{
    public sealed class NancyHostFactory
    {
        public static NancyHost CreateHost(UInt16 port)
        {
            Uri uri = new Uri(String.Format("http://localhost:{0}", port));

            HostConfiguration config = new HostConfiguration();
            config.UrlReservations.CreateAutomatically = true;

            return new NancyHost(config, uri);
        }
    }
}
