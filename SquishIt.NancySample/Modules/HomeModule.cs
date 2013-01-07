using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace SquishIt.NancySample.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = parameters => "Hello World";
        }
    }
}