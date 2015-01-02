using System;
using Nancy;

namespace X52WebService
{
    public class X52ApiModule : NancyModule
    {
        public X52ApiModule()
        {
            Get["/foo"] = parameters => "Hello World!";
        }
    }
}
