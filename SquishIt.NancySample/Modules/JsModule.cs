using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using SquishIt.Framework;

namespace SquishIt.NancySample.Modules
{
    public class JsModule : NancyModule
    {
        public JsModule() : base("/js")
        {
            Get["/{name}"] = parameters =>
            {
                return Bundle.JavaScript().RenderCached((string)parameters.name);
            };
        }
    }
}