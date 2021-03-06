﻿using Nancy;

namespace SquishIt.NancySample.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = parameters => View["Hello.cshtml"];
            Get["/cached"] = parameters => View["HelloCached.cshtml"];
        }
    }
}